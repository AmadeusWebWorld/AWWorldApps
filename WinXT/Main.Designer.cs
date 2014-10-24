namespace Cselian.Utilities.WinXT
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.ExploreFromMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepExplore1 = new System.Windows.Forms.ToolStripSeparator();
			this.RecentMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepRecent1 = new System.Windows.Forms.ToolStripSeparator();
			this.ClearRecentMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageRecentMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ComputerMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepComp1 = new System.Windows.Forms.ToolStripSeparator();
			this.ResetMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.FavoritesMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepExplore2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SearchMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ButtonsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.OrganizeMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepMode1 = new System.Windows.Forms.ToolStripSeparator();
			this.FoldersMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ProgramsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.FilesMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ClockyMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.TweakUIMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpReadmeMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepHelp1 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpUpdatesCheckMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpUpdatesSettingsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepHelp2 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpAboutMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.TabsCtl = new System.Windows.Forms.TabControl();
			this.tabSearch = new System.Windows.Forms.TabPage();
			this.chkOnlyText = new System.Windows.Forms.CheckBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.tabView = new System.Windows.Forms.TabPage();
			this.tabOrganize = new System.Windows.Forms.TabPage();
			this.SplitOrganizer = new System.Windows.Forms.SplitContainer();
			this.tvwFolders = new System.Windows.Forms.TreeView();
			this.lstRecent = new System.Windows.Forms.ListBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClip = new System.Windows.Forms.Button();
			this.chkShowRecent = new System.Windows.Forms.CheckBox();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.nicApp = new System.Windows.Forms.NotifyIcon(this.components);
			this.paneMode = new System.Windows.Forms.Panel();
			this.rdoFolders = new System.Windows.Forms.RadioButton();
			this.rdoPrograms = new System.Windows.Forms.RadioButton();
			this.rdoFiles = new System.Windows.Forms.RadioButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ShutdownMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.TabsCtl.SuspendLayout();
			this.tabSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.tabOrganize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitOrganizer)).BeginInit();
			this.SplitOrganizer.Panel1.SuspendLayout();
			this.SplitOrganizer.Panel2.SuspendLayout();
			this.SplitOrganizer.SuspendLayout();
			this.paneMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExploreFromMenu,
            this.ViewMenu,
            this.ToolsMenu,
            this.MnuHelp});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(764, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// ExploreFromMenu
			// 
			this.ExploreFromMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SepExplore1,
            this.RecentMnu,
            this.ComputerMnu,
            this.FavoritesMnu,
            this.SepExplore2,
            this.ExitMenu});
			this.ExploreFromMenu.Name = "ExploreFromMenu";
			this.ExploreFromMenu.Size = new System.Drawing.Size(57, 20);
			this.ExploreFromMenu.Text = "Explore";
			// 
			// SepExplore1
			// 
			this.SepExplore1.Name = "SepExplore1";
			this.SepExplore1.Size = new System.Drawing.Size(125, 6);
			// 
			// RecentMnu
			// 
			this.RecentMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SepRecent1,
            this.ClearRecentMnu,
            this.ManageRecentMnu});
			this.RecentMnu.Name = "RecentMnu";
			this.RecentMnu.Size = new System.Drawing.Size(128, 22);
			this.RecentMnu.Text = "Recent";
			// 
			// SepRecent1
			// 
			this.SepRecent1.Name = "SepRecent1";
			this.SepRecent1.Size = new System.Drawing.Size(181, 6);
			// 
			// ClearRecentMnu
			// 
			this.ClearRecentMnu.Name = "ClearRecentMnu";
			this.ClearRecentMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.Delete)));
			this.ClearRecentMnu.Size = new System.Drawing.Size(184, 22);
			this.ClearRecentMnu.Text = "Clear";
			this.ClearRecentMnu.Click += new System.EventHandler(this.ClearRecentMnu_Click);
			// 
			// ManageRecentMnu
			// 
			this.ManageRecentMnu.Name = "ManageRecentMnu";
			this.ManageRecentMnu.Size = new System.Drawing.Size(184, 22);
			this.ManageRecentMnu.Text = "Manage";
			this.ManageRecentMnu.Click += new System.EventHandler(this.ManageRecentMnu_Click);
			// 
			// ComputerMnu
			// 
			this.ComputerMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SepComp1,
            this.ResetMnu});
			this.ComputerMnu.Name = "ComputerMnu";
			this.ComputerMnu.Size = new System.Drawing.Size(128, 22);
			this.ComputerMnu.Text = "Computer";
			// 
			// SepComp1
			// 
			this.SepComp1.Name = "SepComp1";
			this.SepComp1.Size = new System.Drawing.Size(99, 6);
			// 
			// ResetMnu
			// 
			this.ResetMnu.Name = "ResetMnu";
			this.ResetMnu.Size = new System.Drawing.Size(102, 22);
			this.ResetMnu.Text = "Reset";
			this.ResetMnu.Click += new System.EventHandler(this.ResetMnu_Click);
			// 
			// FavoritesMnu
			// 
			this.FavoritesMnu.Name = "FavoritesMnu";
			this.FavoritesMnu.Size = new System.Drawing.Size(128, 22);
			this.FavoritesMnu.Text = "Favorites";
			// 
			// SepExplore2
			// 
			this.SepExplore2.Name = "SepExplore2";
			this.SepExplore2.Size = new System.Drawing.Size(125, 6);
			// 
			// ExitMenu
			// 
			this.ExitMenu.Name = "ExitMenu";
			this.ExitMenu.Size = new System.Drawing.Size(128, 22);
			this.ExitMenu.Text = "Exit";
			// 
			// ViewMenu
			// 
			this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMnu,
            this.ButtonsMnu,
            this.OrganizeMnu,
            this.SepMode1,
            this.FoldersMnu,
            this.ProgramsMnu,
            this.FilesMnu});
			this.ViewMenu.Name = "ViewMenu";
			this.ViewMenu.Size = new System.Drawing.Size(50, 20);
			this.ViewMenu.Text = "Mode";
			// 
			// SearchMnu
			// 
			this.SearchMnu.Name = "SearchMnu";
			this.SearchMnu.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.SearchMnu.Size = new System.Drawing.Size(176, 22);
			this.SearchMnu.Text = "Search";
			this.SearchMnu.Click += new System.EventHandler(this.ViewMenu_Click);
			// 
			// ButtonsMnu
			// 
			this.ButtonsMnu.Name = "ButtonsMnu";
			this.ButtonsMnu.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.ButtonsMnu.Size = new System.Drawing.Size(176, 22);
			this.ButtonsMnu.Text = "Buttons";
			this.ButtonsMnu.Click += new System.EventHandler(this.ViewMenu_Click);
			// 
			// OrganizeMnu
			// 
			this.OrganizeMnu.Name = "OrganizeMnu";
			this.OrganizeMnu.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.OrganizeMnu.Size = new System.Drawing.Size(176, 22);
			this.OrganizeMnu.Text = "Organize";
			this.OrganizeMnu.Click += new System.EventHandler(this.ViewMenu_Click);
			// 
			// SepMode1
			// 
			this.SepMode1.Name = "SepMode1";
			this.SepMode1.Size = new System.Drawing.Size(173, 6);
			// 
			// FoldersMnu
			// 
			this.FoldersMnu.Name = "FoldersMnu";
			this.FoldersMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
			this.FoldersMnu.Size = new System.Drawing.Size(176, 22);
			this.FoldersMnu.Text = "Folders";
			// 
			// ProgramsMnu
			// 
			this.ProgramsMnu.Name = "ProgramsMnu";
			this.ProgramsMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F7)));
			this.ProgramsMnu.Size = new System.Drawing.Size(176, 22);
			this.ProgramsMnu.Text = "Programs";
			// 
			// FilesMnu
			// 
			this.FilesMnu.Name = "FilesMnu";
			this.FilesMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8)));
			this.FilesMnu.Size = new System.Drawing.Size(176, 22);
			this.FilesMnu.Text = "Files";
			// 
			// ToolsMenu
			// 
			this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClockyMnu,
            this.TweakUIMnu,
            this.toolStripSeparator1,
            this.ShutdownMnu});
			this.ToolsMenu.Name = "ToolsMenu";
			this.ToolsMenu.Size = new System.Drawing.Size(48, 20);
			this.ToolsMenu.Text = "Tools";
			// 
			// ClockyMnu
			// 
			this.ClockyMnu.Name = "ClockyMnu";
			this.ClockyMnu.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.ClockyMnu.Size = new System.Drawing.Size(176, 22);
			this.ClockyMnu.Text = "Clocky";
			this.ClockyMnu.Click += new System.EventHandler(this.ClockyMnu_Click);
			// 
			// TweakUIMnu
			// 
			this.TweakUIMnu.Name = "TweakUIMnu";
			this.TweakUIMnu.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.TweakUIMnu.Size = new System.Drawing.Size(176, 22);
			this.TweakUIMnu.Text = "Tweak UI";
			this.TweakUIMnu.Click += new System.EventHandler(this.TweakUIMnu_Click);
			// 
			// MnuHelp
			// 
			this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpReadmeMnu,
            this.SepHelp1,
            this.HelpUpdatesCheckMnu,
            this.HelpUpdatesSettingsMnu,
            this.SepHelp2,
            this.HelpAboutMnu});
			this.MnuHelp.Name = "MnuHelp";
			this.MnuHelp.Size = new System.Drawing.Size(44, 20);
			this.MnuHelp.Text = "&Help";
			// 
			// HelpReadmeMnu
			// 
			this.HelpReadmeMnu.Name = "HelpReadmeMnu";
			this.HelpReadmeMnu.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.HelpReadmeMnu.Size = new System.Drawing.Size(180, 22);
			this.HelpReadmeMnu.Text = "&Readme...";
			this.HelpReadmeMnu.Click += new System.EventHandler(this.HelpReadmeMnu_Click);
			// 
			// SepHelp1
			// 
			this.SepHelp1.Name = "SepHelp1";
			this.SepHelp1.Size = new System.Drawing.Size(177, 6);
			// 
			// HelpUpdatesCheckMnu
			// 
			this.HelpUpdatesCheckMnu.Name = "HelpUpdatesCheckMnu";
			this.HelpUpdatesCheckMnu.Size = new System.Drawing.Size(180, 22);
			this.HelpUpdatesCheckMnu.Text = "Check for Updates...";
			this.HelpUpdatesCheckMnu.Click += new System.EventHandler(this.HelpUpdatesCheckMnu_Click);
			// 
			// HelpUpdatesSettingsMnu
			// 
			this.HelpUpdatesSettingsMnu.Name = "HelpUpdatesSettingsMnu";
			this.HelpUpdatesSettingsMnu.Size = new System.Drawing.Size(180, 22);
			this.HelpUpdatesSettingsMnu.Text = "Update Settings...";
			this.HelpUpdatesSettingsMnu.Click += new System.EventHandler(this.HelpUpdatesSettingsMnu_Click);
			// 
			// SepHelp2
			// 
			this.SepHelp2.Name = "SepHelp2";
			this.SepHelp2.Size = new System.Drawing.Size(177, 6);
			// 
			// HelpAboutMnu
			// 
			this.HelpAboutMnu.Name = "HelpAboutMnu";
			this.HelpAboutMnu.Size = new System.Drawing.Size(180, 22);
			this.HelpAboutMnu.Text = "&About...";
			this.HelpAboutMnu.Click += new System.EventHandler(this.HelpAboutMnu_Click);
			// 
			// TabsCtl
			// 
			this.TabsCtl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TabsCtl.Controls.Add(this.tabSearch);
			this.TabsCtl.Controls.Add(this.tabView);
			this.TabsCtl.Controls.Add(this.tabOrganize);
			this.TabsCtl.ItemSize = new System.Drawing.Size(50, 21);
			this.TabsCtl.Location = new System.Drawing.Point(12, 27);
			this.TabsCtl.Multiline = true;
			this.TabsCtl.Name = "TabsCtl";
			this.TabsCtl.SelectedIndex = 0;
			this.TabsCtl.Size = new System.Drawing.Size(740, 313);
			this.TabsCtl.TabIndex = 1;
			// 
			// tabSearch
			// 
			this.tabSearch.BackColor = System.Drawing.SystemColors.Control;
			this.tabSearch.Controls.Add(this.chkOnlyText);
			this.tabSearch.Controls.Add(this.lblSearch);
			this.tabSearch.Controls.Add(this.txtSearch);
			this.tabSearch.Controls.Add(this.dgvResults);
			this.tabSearch.Location = new System.Drawing.Point(4, 25);
			this.tabSearch.Name = "tabSearch";
			this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
			this.tabSearch.Size = new System.Drawing.Size(732, 284);
			this.tabSearch.TabIndex = 0;
			this.tabSearch.Text = "Search";
			// 
			// chkOnlyText
			// 
			this.chkOnlyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOnlyText.AutoSize = true;
			this.chkOnlyText.Location = new System.Drawing.Point(650, 8);
			this.chkOnlyText.Name = "chkOnlyText";
			this.chkOnlyText.Size = new System.Drawing.Size(71, 17);
			this.chkOnlyText.TabIndex = 2;
			this.chkOnlyText.Text = "&Only Text";
			this.chkOnlyText.UseVisualStyleBackColor = true;
			this.chkOnlyText.CheckedChanged += new System.EventHandler(this.chkOnlyText_CheckedChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(6, 9);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(41, 13);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "&Search";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(53, 6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(591, 20);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// dgvResults
			// 
			this.dgvResults.AllowUserToAddRows = false;
			this.dgvResults.AllowUserToDeleteRows = false;
			this.dgvResults.AllowUserToOrderColumns = true;
			this.dgvResults.AllowUserToResizeRows = false;
			this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Location = new System.Drawing.Point(6, 32);
			this.dgvResults.MultiSelect = false;
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.ReadOnly = true;
			this.dgvResults.RowHeadersVisible = false;
			this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvResults.ShowRowErrors = false;
			this.dgvResults.Size = new System.Drawing.Size(715, 246);
			this.dgvResults.TabIndex = 3;
			this.dgvResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentDoubleClick);
			this.dgvResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResults_KeyDown);
			// 
			// tabView
			// 
			this.tabView.AutoScroll = true;
			this.tabView.BackColor = System.Drawing.SystemColors.Control;
			this.tabView.Location = new System.Drawing.Point(4, 25);
			this.tabView.Name = "tabView";
			this.tabView.Padding = new System.Windows.Forms.Padding(3);
			this.tabView.Size = new System.Drawing.Size(732, 284);
			this.tabView.TabIndex = 2;
			this.tabView.Text = "View";
			this.tabView.Enter += new System.EventHandler(this.tabView_Enter);
			this.tabView.Resize += new System.EventHandler(this.tabView_Resize);
			// 
			// tabOrganize
			// 
			this.tabOrganize.BackColor = System.Drawing.SystemColors.Control;
			this.tabOrganize.Controls.Add(this.SplitOrganizer);
			this.tabOrganize.Controls.Add(this.btnSave);
			this.tabOrganize.Controls.Add(this.btnClip);
			this.tabOrganize.Controls.Add(this.chkShowRecent);
			this.tabOrganize.Location = new System.Drawing.Point(4, 25);
			this.tabOrganize.Name = "tabOrganize";
			this.tabOrganize.Padding = new System.Windows.Forms.Padding(3);
			this.tabOrganize.Size = new System.Drawing.Size(732, 284);
			this.tabOrganize.TabIndex = 1;
			this.tabOrganize.Text = "Organize";
			this.tabOrganize.Enter += new System.EventHandler(this.tabOrganize_Enter);
			// 
			// SplitOrganizer
			// 
			this.SplitOrganizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SplitOrganizer.Location = new System.Drawing.Point(0, 6);
			this.SplitOrganizer.Name = "SplitOrganizer";
			// 
			// SplitOrganizer.Panel1
			// 
			this.SplitOrganizer.Panel1.Controls.Add(this.tvwFolders);
			// 
			// SplitOrganizer.Panel2
			// 
			this.SplitOrganizer.Panel2.Controls.Add(this.lstRecent);
			this.SplitOrganizer.Size = new System.Drawing.Size(726, 237);
			this.SplitOrganizer.SplitterDistance = 396;
			this.SplitOrganizer.TabIndex = 0;
			// 
			// tvwFolders
			// 
			this.tvwFolders.AllowDrop = true;
			this.tvwFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvwFolders.HideSelection = false;
			this.tvwFolders.LabelEdit = true;
			this.tvwFolders.Location = new System.Drawing.Point(0, 0);
			this.tvwFolders.Name = "tvwFolders";
			this.tvwFolders.Size = new System.Drawing.Size(393, 235);
			this.tvwFolders.TabIndex = 0;
			this.tvwFolders.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvwFolders_AfterLabelEdit);
			this.tvwFolders.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvwFolders_ItemDrag);
			this.tvwFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvwFolders_DragDrop);
			this.tvwFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvwFolders_DragEnter);
			this.tvwFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.tvwFolders_DragOver);
			this.tvwFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvwFolders_KeyDown);
			// 
			// lstRecent
			// 
			this.lstRecent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstRecent.FormattingEnabled = true;
			this.lstRecent.Location = new System.Drawing.Point(0, 0);
			this.lstRecent.Name = "lstRecent";
			this.lstRecent.Size = new System.Drawing.Size(326, 237);
			this.lstRecent.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.Location = new System.Drawing.Point(6, 255);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClip
			// 
			this.btnClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClip.Location = new System.Drawing.Point(87, 256);
			this.btnClip.Name = "btnClip";
			this.btnClip.Size = new System.Drawing.Size(111, 23);
			this.btnClip.TabIndex = 2;
			this.btnClip.Text = "Add from &Clipboard";
			this.btnClip.UseVisualStyleBackColor = true;
			this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
			// 
			// chkShowRecent
			// 
			this.chkShowRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkShowRecent.AutoSize = true;
			this.chkShowRecent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkShowRecent.Checked = true;
			this.chkShowRecent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowRecent.Location = new System.Drawing.Point(635, 259);
			this.chkShowRecent.Name = "chkShowRecent";
			this.chkShowRecent.Size = new System.Drawing.Size(91, 17);
			this.chkShowRecent.TabIndex = 3;
			this.chkShowRecent.Text = "Show &Recent";
			this.chkShowRecent.UseVisualStyleBackColor = true;
			this.chkShowRecent.CheckedChanged += new System.EventHandler(this.chkShowRecent_CheckedChanged);
			// 
			// nicApp
			// 
			this.nicApp.Text = "Cselian\'s Win XT";
			this.nicApp.Visible = true;
			// 
			// paneMode
			// 
			this.paneMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.paneMode.Controls.Add(this.rdoFolders);
			this.paneMode.Controls.Add(this.rdoPrograms);
			this.paneMode.Controls.Add(this.rdoFiles);
			this.paneMode.Location = new System.Drawing.Point(550, 32);
			this.paneMode.Name = "paneMode";
			this.paneMode.Size = new System.Drawing.Size(193, 18);
			this.paneMode.TabIndex = 2;
			// 
			// rdoFolders
			// 
			this.rdoFolders.AutoSize = true;
			this.rdoFolders.Checked = true;
			this.rdoFolders.Location = new System.Drawing.Point(127, 0);
			this.rdoFolders.Name = "rdoFolders";
			this.rdoFolders.Size = new System.Drawing.Size(59, 17);
			this.rdoFolders.TabIndex = 2;
			this.rdoFolders.TabStop = true;
			this.rdoFolders.Text = "&Folders";
			this.rdoFolders.UseVisualStyleBackColor = true;
			// 
			// rdoPrograms
			// 
			this.rdoPrograms.AutoSize = true;
			this.rdoPrograms.Location = new System.Drawing.Point(52, 0);
			this.rdoPrograms.Name = "rdoPrograms";
			this.rdoPrograms.Size = new System.Drawing.Size(69, 17);
			this.rdoPrograms.TabIndex = 1;
			this.rdoPrograms.Text = "&Programs";
			this.rdoPrograms.UseVisualStyleBackColor = true;
			// 
			// rdoFiles
			// 
			this.rdoFiles.AutoSize = true;
			this.rdoFiles.Location = new System.Drawing.Point(0, 0);
			this.rdoFiles.Name = "rdoFiles";
			this.rdoFiles.Size = new System.Drawing.Size(46, 17);
			this.rdoFiles.TabIndex = 0;
			this.rdoFiles.Text = "&Files";
			this.rdoFiles.UseVisualStyleBackColor = true;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
			// 
			// ShutdownMnu
			// 
			this.ShutdownMnu.Name = "ShutdownMnu";
			this.ShutdownMnu.ShortcutKeyDisplayString = "Win + S";
			this.ShutdownMnu.Size = new System.Drawing.Size(176, 22);
			this.ShutdownMnu.Text = "Shutdown";
			this.ShutdownMnu.Click += new System.EventHandler(this.ShutdownMnu_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 352);
			this.Controls.Add(this.paneMode);
			this.Controls.Add(this.TabsCtl);
			this.Controls.Add(this.MainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(430, 270);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cselian\'s Win XT";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.TabsCtl.ResumeLayout(false);
			this.tabSearch.ResumeLayout(false);
			this.tabSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.tabOrganize.ResumeLayout(false);
			this.tabOrganize.PerformLayout();
			this.SplitOrganizer.Panel1.ResumeLayout(false);
			this.SplitOrganizer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitOrganizer)).EndInit();
			this.SplitOrganizer.ResumeLayout(false);
			this.paneMode.ResumeLayout(false);
			this.paneMode.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem ViewMenu;
		private System.Windows.Forms.ToolStripMenuItem ExploreFromMenu;
		private System.Windows.Forms.ToolStripSeparator SepExplore1;
		private System.Windows.Forms.ToolStripMenuItem RecentMnu;
		private System.Windows.Forms.TabControl TabsCtl;
		private System.Windows.Forms.TabPage tabSearch;
		private System.Windows.Forms.TabPage tabOrganize;
		private System.Windows.Forms.ToolStripMenuItem ComputerMnu;
		private System.Windows.Forms.ToolStripMenuItem FavoritesMnu;
		private System.Windows.Forms.ToolStripSeparator SepComp1;
		private System.Windows.Forms.ToolStripMenuItem ResetMnu;
		private System.Windows.Forms.ToolStripSeparator SepRecent1;
		private System.Windows.Forms.ToolStripMenuItem ClearRecentMnu;
		private System.Windows.Forms.ToolStripMenuItem ManageRecentMnu;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TreeView tvwFolders;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.SplitContainer SplitOrganizer;
		private System.Windows.Forms.ListBox lstRecent;
		private System.Windows.Forms.CheckBox chkShowRecent;
		private System.Windows.Forms.TabPage tabView;
		private System.Windows.Forms.Button btnClip;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.CheckBox chkOnlyText;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.ToolStripMenuItem OrganizeMnu;
		private System.Windows.Forms.ToolStripMenuItem SearchMnu;
		private System.Windows.Forms.ToolStripMenuItem ButtonsMnu;
		private System.Windows.Forms.ToolStripMenuItem MnuHelp;
		private System.Windows.Forms.ToolStripMenuItem HelpReadmeMnu;
		private System.Windows.Forms.ToolStripSeparator SepHelp1;
		private System.Windows.Forms.ToolStripMenuItem HelpUpdatesCheckMnu;
		private System.Windows.Forms.ToolStripMenuItem HelpUpdatesSettingsMnu;
		private System.Windows.Forms.ToolStripSeparator SepHelp2;
		private System.Windows.Forms.ToolStripMenuItem HelpAboutMnu;
		private System.Windows.Forms.NotifyIcon nicApp;
		private System.Windows.Forms.ToolStripSeparator SepExplore2;
		private System.Windows.Forms.ToolStripMenuItem ExitMenu;
		private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
		private System.Windows.Forms.ToolStripMenuItem ClockyMnu;
		private System.Windows.Forms.ToolStripSeparator SepMode1;
		private System.Windows.Forms.ToolStripMenuItem FoldersMnu;
		private System.Windows.Forms.ToolStripMenuItem ProgramsMnu;
		private System.Windows.Forms.ToolStripMenuItem FilesMnu;
		private System.Windows.Forms.Panel paneMode;
		private System.Windows.Forms.RadioButton rdoFolders;
		private System.Windows.Forms.RadioButton rdoPrograms;
		private System.Windows.Forms.RadioButton rdoFiles;
		private System.Windows.Forms.ToolStripMenuItem TweakUIMnu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ShutdownMnu;
	}
}