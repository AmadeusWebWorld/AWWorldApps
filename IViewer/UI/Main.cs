using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class Main : Form
	{
		#region Vars, ctor, Load and Error

		private VidPlaylist PlsEngine;
		private bool MovingHorz = true;
		private bool OpeningPlaylist;

		private LyricInfo LyrItem;
		private LyricInfo.Line LyrLine;
		private Lyrics LyricsUI;

		public Main()
			: this(true)
		{
			InitializeComponent();
			Load += new EventHandler(Main_Load);
			VidEngine.MainInst = this;
			LyricsUI = MetaLyrics;
			SplitMeta.Panel2Collapsed = true;
		}

		private void Main_Load(object sender, System.EventArgs e)
		{
			RegisterHandlers();

			Icon = Properties.Resources.iviewer;
			ViewHorzBtn.Image = Properties.Resources.h;
			PlsVertBtn.Image = Properties.Resources.plsv;
			PlsStickBtn.Image = Properties.Resources.stick;

			// Set up the UI
			VidEngine.SetLoadStatus("Loading Application State", 200, true);
			SetView(View.Details);

			VidEngine.SetLoadStatus("Loading Tree", 600);
			LoadTree();

			VidEngine.SetLoadStatus("Loading Folder View", 350);

			// TODOC: if (AppSettings.Instance.(AppConstants.FolOrientation) <> Orientation.Horizontal Then ViewHorzToggle(sender, e) 'it will toggle to false

			// TODOC: ViewPlaylistVertically = Settings(AppConstants.PlsOrientation) = Orientation.Horizontal	' set the not since toggling will happen in handler
			// TODOC: ViewPlaylistVerticalMnu_Clicked(null, null);
			SetSelector(VidEngine.Settings.SelectorType);
			ToolsLyricsDisplayMnu.DropDown = LyrMenu;

			VidListView.InitLvw(fils, false);
			VidListView.InitLvw(playlist, true);

			VidEngine.SetLoadStatus("Loading Files", 800);
			//// fols.SelectedNode = fols.Nodes(0)	' This will invoke fols_AfterSelect

			if (VidEngine.Settings.FolOrientation == Orientation.Vertical)
			{
				ViewHorzToggle(sender, e);
			}

			if (VidEngine.Settings.FolVisibility == false)
			{
				ViewFolsToggle(sender, e);
			}

			VidEngine.SetLoadStatus(null);
			Application.ThreadException += OnError;
		}

		private void OnError(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			var nl = Environment.NewLine;
			System.IO.File.AppendAllText("IViewer Errors.log", string.Concat(DateTime.Now.ToString(), nl, e.Exception.ToString(), nl, nl));
		}

		#endregion

		#region All Menus

		#region "Menu: File"

		private void FileExitMnu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#endregion

		#region "Menu: View Toggle, Return etc"

		// Change whether or not the folders pane is visible
		private void ViewFolsToggle(object sender, EventArgs e)
		{
			ViewFolsMnu.Checked = !ViewFolsMnu.Checked;
			ViewFolsBtn.Checked = ViewFolsMnu.Checked;

			// Collapse the Panel containing the TreeView.
			SplitFol.Panel1Collapsed = !ViewFolsMnu.Checked;
			VidEngine.Settings.FolVisibility = ViewFolsMnu.Checked;
			VidEngine.SaveSettings();
		}

		private void ViewToolBarMnu_Click(object sender, EventArgs e)
		{
			ViewToolBarMnu.Checked = !ViewToolBarMnu.Checked;
			ToolBar.Visible = ViewToolBarMnu.Checked;
		}

		private void ViewStatusBarMnu_Click(object sender, EventArgs e)
		{
			ViewStatusBarMnu.Checked = !ViewStatusBarMnu.Checked;
			StatusBar.Visible = ViewStatusBarMnu.Checked;
		}

		private void ViewReturnMnu_Click(object sender, EventArgs e)
		{
			// TODO: Why isnt this working? make it work like goto folder
			if (SelectedFile != null)
			{
				SelectedFile.Selected = true;
				SelectedFile.EnsureVisible();
				foreach (ListViewItem itm in playlist.Items)
				{
					if (itm.LibItem().FullPath == SelectedFile.LibItem().FullPath)
					{
						itm.Selected = true;
						itm.EnsureVisible();
						return;
					}
				}

				if (playlist.SelectedItems.Count == 1)
					playlist.SelectedItems[0].Selected = false;
			}
		}

		#endregion

		#region "Horizontal"

		private void ViewHorzToggle(object sender, EventArgs e)
		{
			MovingHorz = true;

			ViewHorzMnu.Checked = !ViewHorzMnu.Checked;
			ViewHorzBtn.Checked = ViewHorzMnu.Checked;
			ViewHorzBtn.Image = ViewHorzMnu.Checked ? Properties.Resources.h : Properties.Resources.v;

			SplitViewer.Orientation = 1 - SplitViewer.Orientation;

			SplitViewer.Panel1.Controls.Add(SplitViewer.Panel2.Controls[0]);
			SplitViewer.Panel2.Controls.Add(SplitViewer.Panel1.Controls[0]);
			SplitFol.Orientation = 1 - SplitViewer.Orientation;

			// restore saved distance
			VidEngine.Settings.FolOrientation = SplitViewer.Orientation;
			VidEngine.SaveSettings();
			SplitFol.SplitterDistance = SplitFol.Orientation == Orientation.Horizontal ? VidEngine.Settings.FolHorzDistance : VidEngine.Settings.FolVertDistance;

			MovingHorz = false;
		}

		private void SplitFol_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			if (MovingHorz) return;

			if (SplitFol.Orientation == Orientation.Horizontal)
				VidEngine.Settings.FolHorzDistance = e.SplitY;
			else
				VidEngine.Settings.FolVertDistance = e.SplitX;

			VidEngine.SaveSettings();
		}

		#endregion

		#region "Menu: LView"

		private void LViewMnu_Click(object sender, EventArgs e)
		{
			var mnu = (ToolStripMenuItem)sender;
			foreach (ToolStripMenuItem item in LViewButtons.DropDownItems)
			{
				item.Checked = item == mnu;
			}

			SetView((View)Convert.ToInt32(mnu.Tag));
		}

		private void SetView(View vw)
		{
			// Finally, set the view requested
			fils.CheckBoxes = false;
			fils.View = vw;
			fils.CheckBoxes = playlist.Visible & fils.View != View.Tile;
			playlist.View = vw;
		}

		#endregion

		#region Menu: Media / Panning Handles Form.Keydown

		private void MediaVolumeMnu_Click(object sender, EventArgs e)
		{
			Player.settings.volume += Convert.ToInt32(((ToolStripMenuItem)sender).Tag) * 5;
		}

		private void MediaVolumeMuteMnu_Click(object sender, EventArgs e)
		{
			Player.settings.mute = !Player.settings.mute;
			MediaVolumeMuteMnu.Checked = Player.settings.mute;
		}

		private void MediaRestartMnu_Click(object sender, EventArgs e)
		{
			if (SelectedFile != null)
				Player.URL = SelectedFile.LibItem().FullPath;
		}

		private void MediaPanMnu_Click(object sender, EventArgs e)
		{
			int dirn = sender.Equals(MediaPanLeftMnu) ? -1 : 1;
			var pos = Player.Ctlcontrols.currentPosition + (dirn * 30);
			Player.Ctlcontrols.currentPosition = pos;
		}

		private void MediaSearchLyricsMnu_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Player.URL)) return;
			SearchLyrics(Player.URL);
		}

		private void SearchLyrics(string path)
		{
			var ip = Path.GetFileNameWithoutExtension(path) + " lyrics";
			ip = ip.Replace("_", " ");
			ip = Interaction.InputBox("Search for lyrics" + Environment.NewLine + Path.GetDirectoryName(path), "IViewer Lyrics Search", ip);
			if (string.IsNullOrEmpty(ip)) return;
			SysHelper.OpenSearch(ip);
		}

		private void MediaPlayedHistoryMnu_Click(object sender, EventArgs e)
		{

		}

		private void Main_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
			{
				int dirn = e.KeyCode == Keys.Left ? -1 : 1;
				int stp = 0;
				if (e.Shift && e.Alt)
					stp = 5;
				else if (e.Shift)
					stp = 1;
				else if (e.Alt)
					stp = 30;
				else
					return;

				var pos = Player.Ctlcontrols.currentPosition + (dirn * stp);
				Player.Ctlcontrols.currentPosition = pos;
				e.Handled = true;
			}
		}

		private void MediaOpenMetaMnu_Click(object sender, EventArgs e)
		{
			var itm = SelectedFile.LibItem();
			if (itm.Meta == ExtensionFilter.MetaNone)
			{
				itm.CreateTxtMeta();
				itm.SetTxt(MetaText);
				SelectedFile.SubItems[VidListView.MetaIndex].Text = itm.Meta;

				SplitMeta.Panel2Collapsed = itm.Meta == ExtensionFilter.MetaNone;
			}
			else if (itm.Meta == ExtensionFilter.TextExtensions[2])
			{
				itm.SetTxt(MetaText);
				SelectedFile.SubItems[VidListView.MetaIndex].Text = itm.Meta;

				SplitMeta.Panel2Collapsed = itm.Meta == ExtensionFilter.MetaNone;
			}
		}

		private void MediaSaveMetaMnu_Click(object sender, EventArgs e)
		{
			var itm = SelectedFile.LibItem();
			itm.SaveTxtMeta(MetaText);
		}

		#endregion

		#region "Menu: Tools / Help"

		private void ToolsOptionsMnu_Click(object sender, EventArgs e)
		{
			var o = new Options();
			if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK && o.SavedKnownFolders)
				ReloadKnownFolders();
		}

		private void ToolsInvalidFileLinksMnu_Click(object sender, EventArgs e)
		{
			VidLibrary.Refresh();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			foreach (var fil in VidLibrary.AllFiles)
			{
				fil.CheckInfo();
				if (fil.Info.Exists == false)
				{
					sb.AppendLine(fil.FullPath);
				}
			}

			var op = new FileInfo(VidEngine.LogInvalidFiles);
			if (op.Exists)
			{
				if (op.IsReadOnly)
					op.IsReadOnly = false;
				op.Delete();
			}

			File.WriteAllText(op.FullName, sb.ToString());
			IOHelper.Run("notepad.exe", op.FullName);
		}

		private void ToolsReloadMediaLibraryMnu_Click(object sender, EventArgs e)
		{
			VidLibrary.Refresh();
		}

		private void ToolsSaveMediaLibraryMnu_Click(object sender, EventArgs e)
		{
			if (!VidLibrary.Save())
				return;
		}

		private void ToolsDataManagerMnu_Click(object sender, EventArgs e)
		{
			new DataManager().Show();
		}

		private void HelpReadmeMnu_Click(object sender, EventArgs e)
		{
			IOHelper.RunText("Readme");
		}

		private void HelpUpdatesCheckMnu_Click(object sender, EventArgs e)
		{
			IvyUpdater.UpdateManager.CheckForUpdates();
		}

		private void HelpUpdatesSettingsMnu_Click(object sender, EventArgs e)
		{
			IvyUpdater.UpdateManager.ShowSettings();
		}

		private void HelpAboutMnu_Click(object sender, EventArgs e)
		{
			Splash f = new Splash();
			f.ShowDialog();
		}

		#endregion

		#endregion

		#region "Lyrics"

		private void LoadLyrics(string media)
		{
			LyrItem = LyricInfo.Load(media);
			//if (!LyrItem.HasTimeMarkers)
			
			PanLyrics.Enabled = true;
			lblLyrics.Visible = true;
			ToolsLyricsDisplayMnu.Visible = true;
		}

		private void DontLyrics()
		{
			PanLyrics.Enabled = false;

			// timer first
			LyrItem = null;
			ToolsLyricsDisplayMnu.Visible = false;
			lblLyrics.SetAndAlign();
		}

		private void tmr_Tick(object sender, EventArgs e)
		{
			if (LyrItem.Within(LyrLine, Player.Ctlcontrols.currentPosition))
				return;

			// speeds up the checking
			var itm = LyrItem.Find(Player.Ctlcontrols.currentPosition);
			if (itm != null && itm.Equals(LyrLine) == false)
			{
				LyrLine = itm;
				lblLyrics.SetAndAlign(LyrLine.Text);
				if (LyricsUI != null && LyricsUI.Visible)
					LyricsUI.ShowItem(LyrLine);
			}
			else if (itm == null)
			{
				lblLyrics.SetAndAlign(string.Empty);
			}
		}

		private void plrCont_Resised(object sender, EventArgs e)
		{
			if (lblLyrics == null | lblLyrics.Parent == null)
				return;
			if (lblLyrics.Visible)
				lblLyrics.SetAndAlign(lblLyrics.Text);
		}

		private void LyrFontSizeMnu_Click(object sender, EventArgs e)
		{
			var siz = lblLyrics.Font.Size + (2 * (sender == LyrIncreaseSizeMnu ? 1 : -1));
			lblLyrics.Font = new System.Drawing.Font(lblLyrics.Font.FontFamily, siz);
			lblLyrics.AlignToRight();
		}

		private void LyrColorMnu_Click(object sender, EventArgs e)
		{
			var cp = new ColorDialog();
			cp.Color = lblLyrics.ForeColor;
			if (cp.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				return;
			lblLyrics.ForeColor = cp.Color;
		}

		#endregion

		#region Filelist / Playlist Context Menu

		// add a playlist_click for this setting the flag to false
		private void FileMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			FileItemUncheckAll.Visible = !OpeningPlaylist && Selector == SelectorType.Both;
			FileItemCheckAll.Visible = FileItemUncheckAll.Visible;
		}

		private void FileItemOpenContainingFolder_Click(object sender, EventArgs e)
		{
			var itm = SelectedItm(OpeningPlaylist ? playlist : fils);
			IOHelper.Run("explorer.exe", itm.Folder);
			//// TODO: make it go to selection
		}

		private void FileItemGoToFolder_Click(object sender, EventArgs e)
		{
			var itm = SelectedItm(OpeningPlaylist ? playlist : fils);

			if (itm == null) return;

			TreeNodeCollection searchIn = fols.Nodes;
			TreeNode root = null;
		search:
			foreach (TreeNode node in searchIn)
			{
				if (!(node.Tag is string)) continue;
				if (string.IsNullOrEmpty((string)node.Tag) == false && itm.Folder.StartsWith(Convert.ToString(node.Tag), StringComparison.OrdinalIgnoreCase))
				{
					root = node;
					break; // TODO: might not be correct. Was : Exit For
				}
			}

			if (root == null)
			{
				searchIn = fols.Nodes[0].Nodes;
				goto search;
			}

		check:

			navigatingToFol = true;
			fols.SelectedNode = root;
			string cur = Convert.ToString(root.Tag);
			if (itm.Folder.Equals(cur, StringComparison.OrdinalIgnoreCase))
			{
				navigatingToFol = false;
				fols_AfterSelect(null, null);
				fils.SelectedItems.Clear();
				foreach (ListViewItem file in fils.Items)
				{
					if (file.LibItem().FullPath == itm.FullPath)
					{
						file.Selected = true;
						return;
					}
				}

				return;
			}

			if (root.Nodes.Count == 1 && string.IsNullOrEmpty(root.Nodes[0].Text))
			{
				fols_BeforeExpand(null, new TreeViewCancelEventArgs(root, false, TreeViewAction.Expand));
			}

			foreach (TreeNode fol in root.Nodes)
			{
				cur = Convert.ToString(fol.Tag);

				// need to use \ else substring problem
				if (itm.Folder.StartsWith(cur + "\\", StringComparison.OrdinalIgnoreCase) | itm.Folder.Equals(cur, StringComparison.OrdinalIgnoreCase))
				{
					root = fol;
					break; // TODO: might not be correct. Was : Exit For
				}
			}

			goto check;
		}

		private void FileMenuCheck_Click(object sender, EventArgs e)
		{
			var check = object.ReferenceEquals(sender, FileItemCheckAll);
			foreach (ListViewItem item in fils.Items)
			{
				item.Checked = check;
			}
		}

		private void FileItemSearchLyrics_Click(object sender, EventArgs e)
		{
			var itm = SelectedItm(OpeningPlaylist ? playlist : fils);
			SearchLyrics(itm.FullPath);
		}

		#endregion

		private void MetaFullscreen_CheckedChanged(object sender, EventArgs e)
		{
			SplitMeta.Panel1Collapsed = SplitViewer.Panel2Collapsed = MetaFullscreen.Checked;
		}

		private void MetaText_TextChanged(object sender, EventArgs e)
		{
			MetaText.BackColor = System.Drawing.Color.LightPink;
		}
	}
}
