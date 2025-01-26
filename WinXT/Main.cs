using System;
using System.Windows.Forms;
using Cselian.Core;

namespace AmadeusWeb.WinXT
{
	public partial class Main : Form
	{
		private MenuBuilder Builder;
		private bool ViewLoaded;
		private Clocky Clock;
		private TweakUI Tweak;

		public Main()
		{
			InitializeComponent();
			Builder = new MenuBuilder(ExploreFromMenu, ComputerMnu, RecentMnu);
			TabsCtl.SelectedTab = tabView;
			TabsCtl.SetDrawMode();

			this.RegisterNic(ExploreFromMenu, nicApp);

			if (Clocky.ShouldRun())
			{
				ClockyMnu_Click(null, null);
			}
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			txtSearch.Focus();
		}

		#region Menu

		private void ViewMenu_Click(object sender, EventArgs e)
		{
			var ix = ViewMenu.DropDownItems.IndexOf((ToolStripItem)sender);
			TabsCtl.SelectedIndex = ix;
		}

		private void ResetMnu_Click(object sender, EventArgs e)
		{
			Builder.ResetDrives();
		}

		#endregion

		#region Search

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			SearchFolders();
		}

		private void chkOnlyText_CheckedChanged(object sender, EventArgs e)
		{
			SearchFolders();
		}

		private void SearchFolders()
		{
			var searcher = new Searcher(Builder.RootFolder);
			searcher.Find(txtSearch.Text, chkOnlyText.Checked);
			if (searcher.HasResults)
			{
				searcher.SetIn(dgvResults);
			}
			else
			{
				dgvResults.DataSource = null;
			}
		}

		private void dgvResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var di = (DirItem)dgvResults.SelectedRows[0].DataBoundItem;
			Builder.OpenFolder(di);
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				dgvResults.Focus();
			}
		}

		private void dgvResults_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				dgvResults_CellContentDoubleClick(null, null);
			}
		}

		#endregion

		#region View

		private void tabView_Resize(object sender, EventArgs e)
		{
			tabView.AutoScrollMinSize = new System.Drawing.Size(tabView.Size.Width - 25, tabView.Size.Height);
		}

		private void tabView_Enter(object sender, EventArgs e)
		{
			if (ViewLoaded == false || Builder.NeedsChange(MenuBuilder.StoreType.Folders))
			{
				new BtnBuilder(tabView, ToolTip, Builder).Build();
				ViewLoaded = true;
				Builder.Loaded(MenuBuilder.StoreType.Folders);
			}
		}

		#endregion

		#region Organize

		private void tabOrganize_Enter(object sender, EventArgs e)
		{
			if (tvwFolders.Nodes.Count == 0)
			{
				tvwFolders.Nodes.Add(new TvwItem(Builder.RootFolder));
				tvwFolders.ExpandAll();
			}

			chkShowRecent_CheckedChanged(null, null);
		}

		private void ClearRecentMnu_Click(object sender, EventArgs e)
		{
			Builder.ClearRecent();
			lstRecent.DataSource = null;
		}

		private void ManageRecentMnu_Click(object sender, EventArgs e)
		{
			if (chkShowRecent.Checked == false)
			{
				chkShowRecent.Checked = true;
			}

			TabsCtl.SelectedTab = tabOrganize;
		}

		private void chkShowRecent_CheckedChanged(object sender, EventArgs e)
		{
			if (chkShowRecent.Checked && (lstRecent.DataSource == null || Builder.NeedsChange(MenuBuilder.StoreType.Recent)))
			{
				lstRecent.DataSource = Builder.GetRecent();
				Builder.Loaded(MenuBuilder.StoreType.Recent);
			}

			SplitOrganizer.Panel2Collapsed = !chkShowRecent.Checked;
		}

		private void tvwFolders_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Link;
			}
			else if (e.Data.GetDataPresent(typeof(TvwItem).FullName))
			{
				e.Effect = DragDropEffects.Move;
			}
		}

		private void tvwFolders_DragOver(object sender, DragEventArgs e)
		{
			var pt = tvwFolders.PointToClient(new System.Drawing.Point(e.X, e.Y));
			pt = new System.Drawing.Point(50, pt.Y); // TODO: Something better than 50 (for level 3 etc)
			var hit = tvwFolders.HitTest(pt);
			if (hit.Node != null)
			{
				if (e.Data.GetDataPresent(typeof(TvwItem).FullName)
					&& hit.Node.Equals(e.Data.GetData(typeof(TvwItem).FullName)))
				{
					return;
				}

				hit.Node.TreeView.SelectedNode = hit.Node;
			}
		}

		private void tvwFolders_DragDrop(object sender, DragEventArgs e)
		{
			var changed = false;
			var to = (TvwItem)(tvwFolders.SelectedNode ?? tvwFolders.Nodes[0]);
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				var files = (System.Collections.Generic.IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop);
				foreach (var item in files)
				{
					System.IO.FileInfo fi;
					if (Builder.AddIfFolder(to.Dir, item))
					{
						// do nothing
					}
					else if ((fi = new System.IO.FileInfo(item)).Exists && fi.Extension == ".lnk")
					{
						var txt = SystemExtensions.GetLinkTarget(fi.FullName);
						Builder.AddIfFolder(to.Dir, txt, System.IO.Path.GetFileNameWithoutExtension(fi.Name)); // TODO: Else?
					}
				}
			}
			else if (e.Data.GetDataPresent(DataFormats.Text))
			{
				var text = (string)e.Data.GetData(DataFormats.Text);
				AddFolders(to, text);
				lstRecent.DataSource = Builder.GetRecent();
			}
			else if (e.Data.GetDataPresent(typeof(TvwItem).FullName))
			{
				var node = (TvwItem)e.Data.GetData(typeof(TvwItem).FullName);
				var par = (TvwItem)node.Parent;
				par.Dir.Children.Remove(node.Dir);
				node.Remove();
				to.Dir.AddChild(node.Dir);
				changed = true;
			}

			if (changed || to.Nodes.Count != (to.Dir.HasChildren ? to.Dir.Children.Count : 0))
			{
				to.AddChildren(to.Dir);
				to.Expand();
				Builder.Loaded(MenuBuilder.StoreType.Folders);
			}
		}

		private void tvwFolders_ItemDrag(object sender, ItemDragEventArgs e)
		{
			tvwFolders.DoDragDrop(tvwFolders.SelectedNode, DragDropEffects.Move);
		}

		private void tvwFolders_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				if (tvwFolders.SelectedIsNotRootOrEmpty() == false)
				{
					return;
				}

				if (e.Control)
				{
					var node = (TvwItem)tvwFolders.SelectedNode;
					var ed = new Edit(node.Dir);
					if (ed.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						ed.UpdateItem(node.Dir);
						node.UpdateUI();
					}
				}
				else
				{
					tvwFolders.SelectedNode.BeginEdit();
				}
			}
			else if (e.KeyCode == Keys.Insert)
			{
				var node = (TvwItem)tvwFolders.SelectedNode;
				var item = new DirItem { Path = node.Dir.Path };
				var ed = new Edit(item);
				if (ed.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					ed.UpdateItem(item);
					node.Dir.AddChild(item);
					node.AddChildren(node.Dir); // resets all children
				}
			}
			else if (e.KeyCode == Keys.Delete)
			{
				tvwFolders.RemoveSelectedIfNotRoot();
			}
		}

		private void tvwFolders_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			var itm = ((TvwItem)e.Node).Dir;
			itm.Text = e.Label;
			btnSave.PerformClick();
		}

		private void btnClip_Click(object sender, EventArgs e)
		{
			var to = (TvwItem)tvwFolders.SelectedNode;
			var text = Clipboard.GetText();
			AddFolders(to, text);
		}

		private void AddFolders(TvwItem to, string text)
		{
			var lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var item in lines)
			{
				Builder.AddIfFolder(to.Dir, item);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Builder.SaveRoot(TvwItem.GetRoot(tvwFolders));
		}

		#endregion

		#region Tools

		private void ClockyMnu_Click(object sender, EventArgs e)
		{
			if (Clock != null && Clock.Visible)
			{
				Clock.Activate();
			}
			else
			{
				(Clock = ProcessHelper.Register(new Clocky())).Show();
			}
		}

		private void TweakUIMnu_Click(object sender, EventArgs e)
		{
			if (Tweak != null && Tweak.Visible)
			{
				Tweak.Activate();
			}
			else
			{
				(Tweak = ProcessHelper.Register(new TweakUI())).Show();
			}
		}
		
		#endregion

		#region Help + Updates

		private void HelpReadmeMnu_Click(object sender, EventArgs e)
		{
			var fil = System.IO.Path.Combine(Environment.CurrentDirectory.Replace("bin\\Debug", string.Empty), "Readme.txt");
			System.Diagnostics.Process.Start(fil);
		}

		private void HelpUpdatesCheckMnu_Click(object sender, EventArgs e)
		{
			Updater.UpdateManager.CheckForUpdates();
		}

		private void HelpUpdatesSettingsMnu_Click(object sender, EventArgs e)
		{
			Updater.UpdateManager.ShowSettings();
		}

		private void HelpAboutMnu_Click(object sender, EventArgs e)
		{
			new Splash().ShowDialog();
		}

		#endregion

		private void ShutdownMnu_Click(object sender, EventArgs e)
		{
			ProcessHelper.Shutdown();
		}
	}
}
