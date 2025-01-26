using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AmadeusWeb.IViewer.UI
{
	/// <summary>
	/// 
	/// </summary>
	public class VidPlaylist
	{
		#region "vars, ctor, handlers"

		public readonly TreeNode PlsNode;

		private readonly string PlsFol = VidEngine.PlaylistFolder;

		private string PlaylistName;
		private bool PlaylistDirty;
		private bool ShowingContext;

		public VidPlaylist(TreeNode pls)
		{
			PlsNode = pls;

			Main.Menu.PlsNew.Click += PlsNewMnu_Click;
			Main.Menu.PlsOpen.Click += PlsOpenMnu_Click;
			Main.Menu.PlsSave.Click += PlsSaveMnu_Click;
			Main.Menu.PlsSaveAs.Click += PlsSaveAsMnu_Click;
			Main.Menu.PlsFix.Click += PlsFixMnu_Click;

			Main.Menu.File.DropDown.Opening += PlsMenu_Opening;

			Main.Menu.PlsOpenFolder.Click += new EventHandler(PlsOpenFolderMnu_Click);
			Main.Menu.PlsRefresh.Click += new EventHandler(PlsRefreshMnu_Click);

			Main.Inst.Filelist.ItemChecked += fils_ItemChecked;
			Main.Inst.Playlist.KeyDown += playlist_KeyDown;
			Main.Inst.Fols.NodeMouseDoubleClick += fols_NodeDoubleClick;
			ReloadPlaylists();
		}

		public void ShowContextMenu()
		{
			ShowingContext = true;
			Main.Menu.File.PopupAtPointer();
		}

		#endregion

		#region Menu Handlers

		private void PlsMenu_Opening(object sender, EventArgs e)
		{
			Main.Menu.PlsFix.Visible = ShowingContext && Main.Inst.Playlist.HasBroken();
			Main.Menu.SepFile2.Visible = Main.Menu.FileExit.Visible = !ShowingContext;
			ShowingContext = false;
		}

		private void PlsNewMnu_Click(object sender, EventArgs e)
		{
			CheckPlaylistNotDirty();
			Main.Inst.Playlist.Items.Clear();
			PlaylistName = null;
			PlaylistDirty = false;
		}

		private void PlsOpenMnu_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("To open, double click an icon in the Playlists node in the tree. Did you mean to reload playlists?", "Open Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;
			ReloadPlaylists();
		}

		private void PlsSaveMnu_Click(object sender, EventArgs e)
		{
			SavePlaylist();
		}

		private void PlsSaveAsMnu_Click(object sender, EventArgs e)
		{
			var orig = PlaylistName;
			PlaylistName = null;
			SavePlaylist(orig);
			if (string.IsNullOrEmpty(PlaylistName))
				PlaylistName = orig;
			////user cancelled
		}

		private void PlsRefreshMnu_Click(object sender, EventArgs e)
		{
			ReloadPlaylists();
		}

		private void PlsOpenFolderMnu_Click(object sender, EventArgs e)
		{
			IOHelper.Run("explorer.exe", PlsFol);
		}


		private void PlsFixMnu_Click(object sender, EventArgs e)
		{
			var broken = Main.Inst.Playlist.GetBroken();
			var fix = new Suggestions(broken);
			if (fix.ShowDialog() == DialogResult.Cancel) return;

			var list = fix.GetSuggestions();
			foreach (var item in list)
			{
				var itm = Main.Inst.Playlist.HavingLibItem(item.Item1);
				itm.Tag = item.Item2;
				itm.SubItems.Clear();
				itm.Text = item.Item2.Name;
				item.Item2.CheckInfo();
				itm.UpdateLvwItem(item.Item2, Main.Inst.Playlist);
			}

			PlaylistDirty = true;
		}

		#endregion

		#region More Handlers
		
		private void fils_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (VidEngine.ChangingFiles)
				return;

			var itm = (ListViewItem)e.Item;
			if (itm.Checked)
			{
				itm.LibItem().AddIntoList(Main.Inst.Playlist);
			}
			else
			{
				itm.LibItem().RemoveFromList(Main.Inst.Playlist);
			}

			PlaylistDirty = true;
		}

		private void fols_NodeDoubleClick(object sender, TreeNodeMouseClickEventArgs f)
		{
			var fols = PlsNode.TreeView;
			if (fols.SelectedNode.Parent != null && fols.SelectedNode.Parent.Equals(PlsNode))
			{
				LoadPlaylist(fols.SelectedNode.Text);
			}
		}

		private void playlist_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
			{
				var playlist = Main.Inst.Playlist;
				if (playlist.SelectedItems.Count == 0) return;
				var itm = playlist.SelectedItems[0];
				if (itm.Index == 0 && e.KeyCode == Keys.Up) return;
				if (itm.Index == playlist.Items.Count - 1 && e.KeyCode == Keys.Down) return;
				var ix = e.KeyCode == Keys.Up ? itm.Index - 1 : itm.Index + 1;
				playlist.Items.Remove(itm);
				playlist.Items.Insert(ix, itm);
				itm.Selected = true;
			}

			if (e.KeyCode == Keys.Delete & Main.Inst.Playlist.SelectedItems.Count == 1)
			{
				var path = Main.Inst.Playlist.SelectedItems[0].LibItem().FullPath;
				Main.Inst.Playlist.Items.Remove(Main.Inst.Playlist.SelectedItems[0]);
				PlaylistDirty = true;
				foreach (ListViewItem itm in Main.Inst.Filelist.Items)
				{
					if (itm.LibItem().FullPath == path)
					{
						itm.Checked = false;
						return;
					}
				}

				// TODOC: Hows this affected by new LibItem?
				if (MessageBox.Show("playlist item " + path + " not in library / current folder - must have been from a previously loaded folder. Select yes to copy path to clipboard", "Playlist Item Removed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
				{
					Clipboard.SetText(path);
				}
			}
		}

		#endregion

		#region Helper Methods
		
		private void ReloadPlaylists()
		{
			PlsNode.Nodes.Clear();

			foreach (string name in GetList())
			{
				var nod = PlsNode.Nodes.Add(name);
				nod.ImageKey = "fave";
			}
		}

		private void LoadPlaylist(string name)
		{
			CheckPlaylistNotDirty();
			Main.Inst.Playlist.Items.Clear();

			PlaylistName = name;
			var items = Load(name);
			items.AddAllIntoList(Main.Inst.Playlist, ListContext.Types.Search);
			PlaylistDirty = false;
		}

		private void SavePlaylist(string newName = null)
		{
			var changed = false;
			if (PlaylistName == null)
			{
				PlaylistName = Interaction.InputBox("Enter a name for the playlist", "Save Playlist", newName);
				if (string.IsNullOrEmpty(PlaylistName))
					return;
				changed = true;
			}

			var list = new List<string>();
			foreach (ListViewItem itm in Main.Inst.Playlist.Items)
			{
				list.Add(itm.LibItem().FullPath);
			}

			Save(PlaylistName, list);
			PlaylistDirty = false;
			if (changed)
				ReloadPlaylists();
		}

		private void CheckPlaylistNotDirty()
		{
			if (!PlaylistDirty)
				return;
			if (MessageBox.Show("Save Playlist first", "Save Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
			{
				SavePlaylist();
			}
		}

		#endregion

		#region pls file load / save
		
		private string[] GetList()
		{
			var list = new List<string>();
			var files = new DirectoryInfo(PlsFol).GetFiles("*.pls");
			foreach (var fil in files)
			{
				list.Add(Path.GetFileNameWithoutExtension(fil.Name));
			}

			return list.ToArray();
		}

		private LibItem[] Load(string name)
		{
			return File.ReadAllLines(PlsFol + name + ".pls").Select(x => new LibItem(x)).ToArray();
		}

		private void Save(string name, List<string> list)
		{
			File.WriteAllLines(PlsFol + name + ".pls", list.ToArray());
		}

		#endregion
	}
}
