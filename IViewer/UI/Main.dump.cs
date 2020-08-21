using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cselian.IViewer.UI
{
	public partial class Main
	{
		private bool navigatingToFol;
		private bool rightclickingOnFol; // let it not jump to history when right clicking
		private bool loading;

		private ListViewItem SelectedFile = null;

		private SelectorType Selector;

		private bool ViewPlaylistVertically;

		private List<ListContext> History = new List<ListContext>();
		private ListContext Current;
		private bool SettingContext;

		private bool IsValidFolder
		{
			get { return fols.SelectedNode.Tag != null; }
		}

		public void ReloadKnownFols()
		{
			ReloadKnownFolders();
		}

		private void RegisterHandlers()
		{
			SplitFol.SplitterMoved += SplitFol_SplitterMoved;
			FileItemWindows.Click += FileItemWindows_Click;
			ToolsViewOrganizerMnu.Click += ToolsViewOrganizerMnu_Click;
			fols.KeyDown += fols_KeyDown;
			fols.BeforeExpand += fols_BeforeExpand;
			fols.AfterSelect += fols_AfterSelect;
			FolderFilter.TextChanged += FolderFilter_TextChanged;
			fols.MouseDown += fols_Click;
			PlayNext.Tick += PlayNext_Tick;
			SplitPls.SplitterMoved += SplitPls_SplitterMoved;

			HistoryItemClear.Click += HistoryItemClear_Click;
			HistoryItemManage.Click += HistoryItemManage_Click;

			// now the events that are same for multiple controls
			playlist.MouseDown += lvw_Click;
			fils.MouseDown += lvw_Click;

			SplitFol.PreviewKeyDown += Splitter_PreviewKeyDown;
			SplitViewer.PreviewKeyDown += Splitter_PreviewKeyDown;
			SplitPls.PreviewKeyDown += Splitter_PreviewKeyDown;

			ExtensionsFilter.SelectedIndexChanged += ExtensionsFilter_SelectedIndexChanged;
			ExtensionsFilter.KeyDown += ExtensionsFilter_KeyDown;
			SearchFilter.TextChanged += SearchFilter_TextChanged;
			SearchModes.SelectedIndexChanged += SearchFilter_TextChanged;

			TreeItemOpen.Click += TreeMenu_Click;
			TreeItemRefresh.Click += TreeMenu_Click;
			TreeItemFlatten.Click += TreeMenu_Click;

			FileItemCheckAll.Click += FileMenuCheck_Click;
			FileItemUncheckAll.Click += FileMenuCheck_Click;

			fils.KeyDown += fils_KeyDown;
			playlist.KeyDown += fils_KeyDown;

			fils.MouseDoubleClick += fils_MouseDoubleClick;
			playlist.MouseDoubleClick += fils_MouseDoubleClick;

			SelBothBtn.Click += Selector_CheckStateChanged;
			SelFileBtn.Click += Selector_CheckStateChanged;
			SelPlsBtn.Click += Selector_CheckStateChanged;

			ViewPlaylistVerticalMnu.Click += ViewPlaylistVerticalMnu_Clicked;
			PlsVertBtn.Click += ViewPlaylistVerticalMnu_Clicked;
		}

		#region "Rest of Vid"

		private void Splitter_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
		{
			if (!(e.KeyCode == Keys.PageDown) && !(e.KeyCode == Keys.PageUp))
				return;
			SplitContainer spl = (SplitContainer)sender;
			if (e.KeyCode == Keys.PageUp)
			{
				if (spl.Panel2Collapsed)
					spl.Panel2Collapsed = false;
				else
					spl.Panel1Collapsed = true;
			}
			else
			{
				if (spl.Panel1Collapsed)
					spl.Panel1Collapsed = false;
				else
					spl.Panel2Collapsed = true;
			}
		}

		private void FileItemWindows_Click(object sender, EventArgs e)
		{
			// TODO: CS: ShellContextMenu
		}

		private void ToolsViewOrganizerMnu_Click(object sender, EventArgs e)
		{
			var dlg = new UserInput(VidEngine.Settings.KnownFolders, null, true, "show organization");
			if (dlg.ShowDialog() != DialogResult.OK)
				return;
			var fol = dlg.SelectedItems[0];
			var o = new Organizer(fol);
			o.ShowDialog();
		}

		#endregion

		#region "Tree & Folder Load"

		// Refresh for LoadTree
		private void fols_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
				LoadTree();
		}

		private void LoadTree()
		{
			fols.Nodes.Clear();

			loading = true;
			var folRoot = fols.Nodes.Add("Root");
			folRoot.ImageKey = "Root";
			folRoot.SelectedImageKey = folRoot.ImageKey;

			var pls = fols.Nodes.Add("Playlists");
			PlsEngine = new VidPlaylist(pls);
			pls.ImageKey = "fave";

			var fav = fols.Nodes.Add("Favorites");
			pls.ImageKey = "fave";

			VidEngine.SetLoadStatus("Loading Media Library");
			VidEngine.SetLoadStatus("Media Library Loaded with " + VidLibrary.AllFiles.Length.ToString() + " items");
			if (VidLibrary.FileNotFound) IOHelper.RunText("Getting Started");

			var drvNode = default(TreeNode);
			foreach (var drv in DriveInfo.GetDrives())
			{
				if (!drv.IsReady)
				{
					drvNode = folRoot.Nodes.Add(drv.RootDirectory.FullName, drv.Name);
				}
				else
				{
					drvNode = folRoot.Nodes.Add(drv.RootDirectory.FullName, string.Format("{0} ({1})", drv.Name, drv.VolumeLabel));
					var di = new DirectoryInfo(drv.RootDirectory.FullName);
					if (di.GetDirectories().Length > 0)
						drvNode.Nodes.Add(string.Empty);
				}

				drvNode.Tag = drv.RootDirectory.FullName;
				drvNode.ImageKey = "Drive";
				drvNode.SelectedImageKey = drvNode.ImageKey;
			}

			ReloadKnownFolders();
			ReloadFavorites();
		}

		private void ReloadKnownFolders()
		{
			while (fols.Nodes.Count > 3)
				fols.Nodes.RemoveAt(3);

			foreach (var path in VidEngine.Settings.KnownFolders)
			{
				var fol = new DirectoryInfo(path);
				AddFol(fol, fols.Nodes);
			}
		}

		private void ReloadFavorites()
		{
			fols.Nodes[2].Nodes.Clear();

			var faves = IOHelper.Load<ListContext>("Faves.xml");
			if (faves == null) return;
			Options.AddFaveNodes(fols.Nodes[2], faves);
		}

		// if selectednode text = "", expand & addfol
		private void fols_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count == 1 && string.IsNullOrEmpty(e.Node.Nodes[0].Text))
			{
				e.Node.Nodes.Clear();
				var subFols = new DirectoryInfo((string)e.Node.Tag).GetDirectories();
				subFols.SortDirectories();
				foreach (DirectoryInfo fol in subFols)
				{
					AddFol(fol, e.Node.Nodes);
				}
			}
		}

		private void AddFol(DirectoryInfo fol, TreeNodeCollection nodes)
		{
			if (fol.Attributes.HasFlag(FileAttributes.Hidden)) // System Volume Information etc
				return;

			TreeNode folNode = nodes.Add(fol.FullName, fol.Name);
			folNode.ImageKey = "fol";
			folNode.SelectedImageKey = "cur";
			if (fol.Exists && fol.GetDirectories().Length > 0)
				folNode.Nodes.Add(string.Empty);
			folNode.Tag = fol.FullName;
		}

		// LoadFolder into filelist
		private void fols_AfterSelect(object sender, TreeViewEventArgs f)
		{
			if (fols.SelectedNode == null || fols.SelectedNode.Equals(PlsEngine.PlsNode) || (fols.SelectedNode.Parent != null && fols.SelectedNode.Parent.Equals(PlsEngine.PlsNode)))
				return;

			if (rightclickingOnFol || navigatingToFol || fols.SelectedNode == null)
				return;

			if (loading)
			{
				loading = false;
				return;
			}

			// Root
			if (fols.SelectedNode.Tag == null)
			{
				return;
				var ctx = new ListContext(ListContext.Types.All);
				SetFileList(ctx);
			}
			else if (fols.SelectedNode.Tag is ListContext)
			{
				var ctx = fols.SelectedNode.Tag as ListContext;
				SettingContext = true;
				if (ctx.Type == ListContext.Types.Search)
				{
					SearchModes.SelectedIndex = (int)ctx.SearchMode;
					SearchFilter.Text = ctx.SearchText;
					FolderFilter.Text = string.Empty;
				}
				else if (ctx.Type == ListContext.Types.Flat || ctx.Type == ListContext.Types.Folder)
				{
					SearchFilter.Text = string.Empty;
					FolderFilter.Text = ctx.SubFilter;
				}

				SetFileList(ctx);
				SettingContext = false;
			}
			else
			{
				var folName = (string)fols.SelectedNode.Tag;
				if (!Directory.Exists(folName)) return;

				var ctx = new ListContext(ListContext.Types.Folder) { Folder = folName, SubFilter = FolderFilter.Text,
					Filter = !string.IsNullOrEmpty(ExtensionsFilter.Text) ? new ExtensionFilter(ExtensionsFilter.Text) : null };

				SetFileList(ctx);
			}
		}

		#endregion

		#region History

		private void SetFileList(ListContext ctx)
		{
			if (ctx.ReplaceLast(History)) History[0] = ctx;
			else if (!History.Contains(ctx)) History.Insert(0, ctx);

			Current = ctx;
			if (ctx.Type == ListContext.Types.Flat) VidListView.FlatFolderStringLength = ctx.Folder.Length;
			ctx.List = ctx.LoadItems();
			VidListView.IsFileListMixed = ctx.Type != ListContext.Types.Folder;
			fils.Items.Clear();
			ctx.List.AddAllIntoList(fils, ctx.Type);

			StatusSearch.Text = ctx.ToString();
		}

		private void HistoryMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			while (HistoryMenu.Items.Count > 3)
				HistoryMenu.Items.RemoveAt(3);

			foreach (var item in History)
			{
				var img = item.Equals(Current) ? Properties.Resources._checked : null;
				var mnu = HistoryMenu.Items.Add(item.ToString(), img, mnuHistory_Click);
				mnu.Visible = true;
				mnu.Tag = item;
			}
		}

		private void HistoryItemClear_Click(object sender, EventArgs e)
		{
			History.Clear();
			if (Current != null) History.Add(Current);
		}

		private void HistoryItemManage_Click(object sender, EventArgs e)
		{
			var o = new Options(History);
			if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK && o.SavedFavorites)
				ReloadFavorites();
		}

		private void mnuHistory_Click(object sender, EventArgs e)
		{
			var mnu = (ToolStripItem)sender;
			var ctx = (ListContext)mnu.Tag;
			SetFileList(ctx);
		}

		#endregion

		#region "Filter"

		private void SearchFilter_TextChanged(object sender, EventArgs e)
		{
			var mode = SearchModes.SelectedIndex != -1 ? (SearchMode)SearchModes.SelectedIndex : default(SearchMode);
			if (sender.Equals(SearchModes))
			{
				lblMode.Text = (new string[] { "N", "P", "F" })[(int)mode];
				ToolTip.SetToolTip(lblMode, (string)SearchModes.SelectedItem);
			}

			if (SettingContext || SearchFilter.Text.Length < 3)
				return;

			var ctx = new ListContext(ListContext.Types.Search) { SearchMode = mode, SearchText = SearchFilter.Text };
			SetFileList(ctx);
		}

		private void FolderFilter_TextChanged(object sender, EventArgs e)
		{
			if (SettingContext || fols.SelectedNode == null || fols.SelectedNode.Tag == null)
				return;

			fols_AfterSelect(sender, null);
		}

		private void ExtensionsFilter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				ExtensionsFilter_SelectedIndexChanged(sender, EventArgs.Empty);
		}

		private void ExtensionsFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			fols_AfterSelect(sender, null);
		}

		#endregion

		#region "Rest of Vid IO"

		private void fols_Click(object sender, MouseEventArgs e)
		{
			if (e.Button != System.Windows.Forms.MouseButtons.Right) return;

			var hit = fols.HitTest(e.Location);
			if (hit.Node == null) return;

			rightclickingOnFol = true;
			fols.SelectedNode = hit.Node;
			rightclickingOnFol = false;

			if (hit.Node == PlsEngine.PlsNode || hit.Node.Parent == PlsEngine.PlsNode)
				PlsEngine.ShowContextMenu();
			else
				TreeMenu.Show(fols, e.Location);
		}

		private void lvw_Click(object sender, MouseEventArgs e)
		{
			var lvw = (ListView)sender;
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				var hit = lvw.HitTest(e.Location.X, e.Location.Y);
				if (hit.Item != null)
				{
					lvw.SelectedItems.Clear();
					hit.Item.Selected = true;
					OpeningPlaylist = lvw.Equals(playlist);
					FileMenu.Show(lvw, e.Location);
				}
				else if (sender == playlist)
				{
					PlsEngine.ShowContextMenu();
				}
			}
		}

		private void TreeMenu_Click(object sender, EventArgs e)
		{
			if (!IsValidFolder) return;
			var folName = (string)fols.SelectedNode.Tag;

			if (sender.Equals(TreeItemOpen))
			{
				IOHelper.Run(folName);
			}
			else if (sender.Equals(TreeItemFlatten))
			{
				var ctx = new ListContext(ListContext.Types.Flat) { Folder = folName, SubFilter = FolderFilter.Text };
				SetFileList(ctx);
			}
			else if (sender.Equals(TreeItemRefresh))
			{
				fols.SelectedNode.Nodes.Clear();
				var fol = new DirectoryInfo((string)fols.SelectedNode.Tag);
				if (fol.Exists && fol.GetDirectories().Length > 0)
				{
					fols.SelectedNode.Nodes.Add(string.Empty);
					fols_BeforeExpand(null, new TreeViewCancelEventArgs(fols.SelectedNode, false, TreeViewAction.Expand));
				}
			}
		}

		#endregion

		#region "Player Starts"

		private ListView GetMyLvw()
		{
			if ((Selector == SelectorType.Both && PlsStickBtn.Checked) | Selector == SelectorType.Playlist)
			{
				return playlist;
			}
			else
			{
				return fils;
			}
		}

		private LibItem SelectedItm(ListView lvw = null)
		{
			var itm = SelectedItmTuple(lvw);
			return itm != null ? itm.Item2 : null;
		}

		private Tuple<ListViewItem, LibItem> SelectedItmTuple(ListView lvw = null)
		{
			if (lvw == null) lvw = GetMyLvw();

			if (lvw.SelectedItems.Count >= 1)
				return lvw.SelectedItems[0].LibItemTuple();

			return null;
		}

		private void TryPlayFile(ListView ctl = null)
		{
			// override SelectedItm for control events
			Tuple<ListViewItem, LibItem> sel;
			if (ctl != null)
			{
				SelectedFile = ctl.SelectedItems[0];
			}
			else if (((sel = SelectedItmTuple()) != null) && SelectedFile != null && SelectedFile.LibItem().FullPath == sel.Item2.FullPath)
			{
				return;
			}
			else
			{
				SelectedFile = sel != null ? sel.Item1 : null;
			}

			if (SelectedFile == null)
			{
				lblDuration.SetAndAlign();
				return;
			}

			SelectedFile.SubItems[VidListView.PlayedIndex].Text = "yes";

			var itm = SelectedFile.LibItem();
			itm.CheckMeta();
			SelectedFile.SubItems[VidListView.MetaIndex].Text = itm.Meta;

			SplitMeta.Panel2Collapsed = itm.Meta == ExtensionFilter.MetaNone;

			if (LyricInfo.Exists(itm.FullPath))
			{
				LoadLyrics(itm.FullPath);
				MetaText.Visible = false;
				MetaLyrics.Visible = true;
			}
			else
			{
				itm.SetTxt(MetaText);

				DontLyrics();
				MetaLyrics.Visible = false;
			}

			if (!ExtensionFilter.IsText(itm.Extension))
				Player.URL = SelectedFile.LibItem().FullPath;

			StatusFile.Text = SelectedFile.Text;
			StatusFile.ToolTipText = SelectedFile.LibItem().FullPath;
			this.Text = SelectedFile.Text;
		}

		private void fils_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				TryPlayFile((ListView)sender);
		}

		private void fils_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
				TryPlayFile((ListView)sender);
		}

		private void PlayNext_Tick(object sender, EventArgs e)
		{
			if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying && lblDuration.Text != Player.currentMedia.durationString)
			{
				lblDuration.SetAndAlign(Player.currentMedia.durationString);
			}

			var lvw = GetMyLvw();
			if (lvw.SelectedItems.Count < 1)
				return;

			if (!MediaStopMnu.Checked & Player.playState == WMPLib.WMPPlayState.wmppsStopped)
			{
				if (lvw.SelectedIndices[0] == lvw.Items.Count - 1)
				{
					lvw.SelectedItems.Clear();
					lvw.Items[0].Selected = true;
					lvw.Items[0].SubItems[VidListView.PlayedIndex - 1].Text = "yes";
				}
				else
				{
					var ix = lvw.SelectedIndices[0] + 1;
					lvw.SelectedItems.Clear();
					lvw.Items[ix].Selected = true;
					lvw.Items[ix].SubItems[VidListView.PlayedIndex - 1].Text = "yes";
				}

				TryPlayFile();
			}
		}

		#endregion

		#region "Playlist"

		private void Selector_CheckStateChanged(object sender, EventArgs e)
		{
			SelectorType s = SelectorType.Both;
			if (SelPlsBtn.Equals(sender))
				s = SelectorType.Playlist;
			else
				if (SelFileBtn.Equals(sender))
					s = SelectorType.Filelist;
			SetSelector(s);
		}

		private void SetSelector(SelectorType s)
		{
			Selector = s;
			var dirty = VidEngine.Settings.SelectorType != s;
			VidEngine.Settings.SelectorType = s;
			if (dirty) VidEngine.SaveSettings();

			SelPlsBtn.Checked = s == SelectorType.Playlist;
			SelFileBtn.Checked = s == SelectorType.Filelist;
			SelBothBtn.Checked = s == SelectorType.Both;
			PlsStickBtn.Visible = s == SelectorType.Both;
			PlsVertBtn.Visible = PlsStickBtn.Visible;

			VidEngine.ChangingFiles = true;
			fils.CheckBoxes = Selector == SelectorType.Both;
			VidEngine.ChangingFiles = false;

			if (Selector == SelectorType.Playlist)
			{
				SplitPls.Panel1Collapsed = true;
				SplitPls.Panel2Collapsed = false;
			}
			else if (Selector == SelectorType.Both)
			{
				SplitPls.Panel1Collapsed = false;
				SplitPls.Panel2Collapsed = false;
			}
			else
			{
				SplitPls.Panel1Collapsed = false;
				SplitPls.Panel2Collapsed = true;
			}
		}

		private void ViewPlaylistVerticalMnu_Clicked(object sender, EventArgs e)
		{
			MovingHorz = true;

			ViewPlaylistVertically = !ViewPlaylistVertically;
			PlsVertBtn.Checked = ViewPlaylistVertically;
			SplitPls.Orientation = ViewPlaylistVertically ? Orientation.Vertical : Orientation.Horizontal;

			VidEngine.Settings.PlsOrientation = SplitViewer.Orientation;
			VidEngine.SaveSettings();
			SplitPls.SplitterDistance = SplitPls.Orientation == Orientation.Horizontal ? VidEngine.Settings.PlsHorzDistance : VidEngine.Settings.PlsVertDistance;

			MovingHorz = false;
		}

		private void SplitPls_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			if (MovingHorz)
			{
				return;
			}

			if (SplitPls.Orientation == Orientation.Horizontal)
				VidEngine.Settings.PlsHorzDistance = e.SplitY;
			else
				VidEngine.Settings.PlsVertDistance = e.SplitX;

			VidEngine.SaveSettings();
		}

		#endregion
	}
}