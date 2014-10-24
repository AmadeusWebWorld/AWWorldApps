using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cselian.IViewer.UI
{
	public partial class Options : Form
	{
		public Options(List<ListContext> history = null)
		{
			InitializeComponent();
			Load += Options_Load;
			SCKey.KeyDown += SCKey_KeyDown;
			MenuItems.DoubleClick += MenuItems_DoubleClick;
			KnownFolders.KeyDown += KnownFolders_KeyDown;
			KnownFolders.AfterLabelEdit += KnownFolders_AfterLabelEdit;
			Save.Click += Save_Click;

			if (history != null)
			{
				History.DataSource = history;
				LoadFaves();
				TabOptions.TabPages.Remove(TabMenuShortcuts);
				TabOptions.TabPages.Remove(TabFolders);
				Faves.SelectedNode = Faves.Nodes[0];
			}
			else
			{
				TabOptions.TabPages.Remove(TabFavorites);
			}
		}

		public bool SavedKnownFolders { get; set; }

		public bool SavedFavorites { get; set; }

		private void Options_Load(object sender, System.EventArgs e)
		{
			if (TabOptions.TabPages.Contains(TabMenuShortcuts))
				InitMenu();
			if (TabOptions.TabPages.Contains(TabFolders))
				InitKnownFolders();
		}

		private void Save_Click(object sender, System.EventArgs e)
		{
			if (TabOptions.TabPages.Contains(TabFolders))
				SaveKnownFolders();
			if (TabOptions.TabPages.Contains(TabFavorites))
				SaveFaves();

			DialogResult = System.Windows.Forms.DialogResult.OK;
			Close();
		}

		#region "Menu"

		private void InitMenu()
		{
			return; // TODO: Fix this
			MenuItems.Items.Clear();
			foreach (var mnu in Main.Menu.AllItems)
			{
				var name = mnu.Name.Substring(3);

				foreach (var mnuItm in mnu.DropDownItems.OfType<ToolStripMenuItem>())
				{
					if (mnuItm.Name.StartsWith(name))
					{
						var itm = MenuItems.Items.Add(new ListViewItem(mnuItm.Text.Replace("&", string.Empty)));
						itm.SubItems.Add(name);
						itm.SubItems.Add(GetSCString(mnuItm.ShortcutKeys));
					}
				}
			}
		}

		private string GetSCString(Keys kys)
		{
			var result = kys.ToString();
			if (result.IndexOf(", ") != -1)
			{
				var rev = result.Split(',');
				result = string.Empty;
				for (int i = rev.Length; i >= 0; i += -1)
				{
					result += rev[i].Trim();
					if (i != 0)
					{
						result += " + ";
					}
				}
			}

			return result;
		}

		private void SCKey_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return & e.KeyCode != Keys.ControlKey & e.KeyCode != Keys.Alt & e.KeyCode != Keys.ShiftKey)
			{
				Keys key = default(Keys);

				if (e.Control)
				{
					key = key | Keys.ControlKey;
				}

				if (e.Alt)
				{
					key = key | Keys.Alt;
				}

				if (e.Shift)
				{
					key = key | Keys.ShiftKey;
				}

				key = key | e.KeyCode;

				SCKey.Text = GetSCString(e.KeyCode);
			}

			e.SuppressKeyPress = true;
		}

		private void MenuItems_DoubleClick(object sender, System.EventArgs e)
		{
			SCKey.Visible = true;
			SCKey.Top = MenuItems.Top + MenuItems.SelectedItems[0].Position.Y;
			SCKey.Text = MenuItems.SelectedItems[0].SubItems[2].Text;
			SCKey.Focus();
			SCKey.SelectAll();
		}

		#endregion

		#region KnownFolders

		private void InitKnownFolders()
		{
			KnownFolders.Items.Clear();
			foreach (var path in VidEngine.Settings.KnownFolders)
			{
				var itm = KnownFolders.Items.Add(path);
				itm.SubItems.Add(Directory.Exists(path).ToString());
			}
		}

		private void KnownFolders_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				KnownFolders.SelectedItems[0].BeginEdit();
			}
			else if (e.KeyCode == Keys.Insert)
			{
				var itm = new ListViewItem("New Known Folder");
				itm.SubItems.Add(string.Empty);
				KnownFolders.Items.Add(itm);
				itm.Selected = true;
				itm.BeginEdit();
			}
			else if (e.KeyCode == Keys.Delete)
			{
				KnownFolders.Items.Remove(KnownFolders.SelectedItems[0]);
			}
		}

		private void KnownFolders_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			KnownFolders.Items[e.Item].SubItems[1].Text = Directory.Exists(e.Label).ToString();
		}

		private void SaveKnownFolders()
		{
			SavedKnownFolders = true;
			var fols = new List<string>();
			foreach (ListViewItem itm in KnownFolders.Items)
			{
				fols.Add(itm.Text);
			}

			VidEngine.Settings.KnownFolders = fols.ToArray();
			VidEngine.SaveSettings();
			VidEngine.MainInst.ReloadKnownFols();
		}

		#endregion

		#region History / Favorite List Views

		private void History_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			AddChild((ListContext)History.SelectedItem);
		}

		private void History_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (History.SelectedItem != null)
				{
					var itm = (ListContext)History.SelectedItem;
					var list = (List<ListContext>)History.DataSource;
					var ix = History.SelectedIndex;
					list.Remove(itm);
					History.SelectedItem = list.IndexOrDefault(ix);
				}
			}
		}

		private void Faves_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Insert)
			{
				AddChild(new ListContext(ListContext.Types.Group));
			}
			else if (e.KeyCode == Keys.Delete)
			{
				var node = Faves.SelectedNode;
				if (node.Parent == null) return;
				var parent = (ListContext)node.Parent.Tag;
				var child = (ListContext)node.Tag;
				parent.Children.Remove(child);
				node.Parent.Nodes.Remove(node);
			}
		}

		private void AddChild(ListContext ctx)
		{
			var node = Faves.SelectedNode;
			var parent = (ListContext)node.Tag;

			parent.Children.Add(ctx);
			var sub = node.Nodes.Add(ctx.ToString());
			node.ExpandAll();
			sub.Tag = ctx;
		}

		private void LoadFaves()
		{
			var faves = IOHelper.Load<ListContext>("Faves.xml");
			if (faves == null)
				Faves.Nodes[0].Tag = new ListContext(ListContext.Types.Group);
			else
				AddFaveNodes(Faves.Nodes[0], faves);

			Faves.Nodes[0].ExpandAll();
		}

		public static void AddFaveNodes(TreeNode parent, ListContext match)
		{
			parent.Tag = match;
			foreach (var item in match.Children)
			{
				var node = parent.Nodes.Add(item.ToString());
				AddFaveNodes(node, item);
			}
		}

		private void SaveFaves()
		{
			SavedFavorites = true; 
			var node = (ListContext)Faves.Nodes[0].Tag;
			IOHelper.Save(node, "Faves.xml");
		}

		#endregion
	}
}
