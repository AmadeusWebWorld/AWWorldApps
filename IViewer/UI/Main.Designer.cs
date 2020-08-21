namespace Cselian.IViewer.UI
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
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.StatusSearch = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.SearchModes = new System.Windows.Forms.ComboBox();
			this.FolderFilter = new System.Windows.Forms.TextBox();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SearchFilter = new System.Windows.Forms.TextBox();
			this.HistoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.HistoryItemClear = new System.Windows.Forms.ToolStripMenuItem();
			this.HistoryItemManage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.ExtensionsFilter = new System.Windows.Forms.ComboBox();
			this.MetaFullscreen = new System.Windows.Forms.CheckBox();
			this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.SplitViewer = new System.Windows.Forms.SplitContainer();
			this.SplitMeta = new System.Windows.Forms.SplitContainer();
			this.lblDuration = new System.Windows.Forms.Label();
			this.lblLyrics = new System.Windows.Forms.Label();
			this.LyrMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.LyrIncreaseSizeMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.LyrDecreaseSizeMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.LyrColorMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.Player = new AxWMPLib.AxWindowsMediaPlayer();
			this.MetaText = new System.Windows.Forms.TextBox();
			this.MetaLyrics = new Cselian.IViewer.UI.Lyrics();
			this.SplitFol = new System.Windows.Forms.SplitContainer();
			this.fols = new System.Windows.Forms.TreeView();
			this.FolIcons = new System.Windows.Forms.ImageList(this.components);
			this.SplitPls = new System.Windows.Forms.SplitContainer();
			this.lblMode = new System.Windows.Forms.Label();
			this.fils = new System.Windows.Forms.ListView();
			this.LargeFileIcons = new System.Windows.Forms.ImageList(this.components);
			this.SmallFileIcons = new System.Windows.Forms.ImageList(this.components);
			this.playlist = new System.Windows.Forms.ListView();
			this.VidMenu = new System.Windows.Forms.MenuStrip();
			this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsNewMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsOpenMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepFile1 = new System.Windows.Forms.ToolStripSeparator();
			this.PlsSaveMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsSaveAsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsOpenFolderMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsRefreshMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.PlsFixMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepFile2 = new System.Windows.Forms.ToolStripSeparator();
			this.FileExitMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewToolBarMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewStatusBarMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewFolsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewHorzMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepView1 = new System.Windows.Forms.ToolStripSeparator();
			this.ViewReturnMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewPlaylistVerticalMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuMedia = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaRestartMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaStopMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepMedia1 = new System.Windows.Forms.ToolStripSeparator();
			this.MediaVolumeUpMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaVolumeDownMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaVolumeMuteMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepMedia2 = new System.Windows.Forms.ToolStripSeparator();
			this.MediaPanLeftMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaPanRightMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaPlayedHistoryMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MediaSearchLyricsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaOpenMetaMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MediaSaveMetaMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsReloadMediaLibraryMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsSaveMediaLibraryMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsInvalidFileLinksMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsLyricsDisplayMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsViewOrganizerMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsCheckPlaylistMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsDataManagerMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepTools1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolsOptionsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpReadmeMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepHelp1 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpUpdatesCheckMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpUpdatesSettingsMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.SepHelp2 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpAboutMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolBar = new System.Windows.Forms.ToolStrip();
			this.ViewFolsBtn = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.ViewHorzBtn = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.SelFileBtn = new System.Windows.Forms.ToolStripButton();
			this.SelPlsBtn = new System.Windows.Forms.ToolStripButton();
			this.SelBothBtn = new System.Windows.Forms.ToolStripButton();
			this.PlsVertBtn = new System.Windows.Forms.ToolStripButton();
			this.PlsStickBtn = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.LViewButtons = new System.Windows.Forms.ToolStripDropDownButton();
			this.LViewList = new System.Windows.Forms.ToolStripMenuItem();
			this.LViewDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.LViewLarge = new System.Windows.Forms.ToolStripMenuItem();
			this.LViewSmall = new System.Windows.Forms.ToolStripMenuItem();
			this.LViewTile = new System.Windows.Forms.ToolStripMenuItem();
			this.TreeItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.TreeItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.FileItemOpenContainingFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.FileItemGoToFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.FileItemCheckAll = new System.Windows.Forms.ToolStripMenuItem();
			this.FileItemUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
			this.FileItemWindows = new System.Windows.Forms.ToolStripMenuItem();
			this.FileItemSearchLyrics = new System.Windows.Forms.ToolStripMenuItem();
			this.TreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TreeItemFlatten = new System.Windows.Forms.ToolStripMenuItem();
			this.PlayNext = new System.Windows.Forms.Timer(this.components);
			this.PanLyrics = new System.Windows.Forms.Timer(this.components);
			this.StatusBar.SuspendLayout();
			this.HistoryMenu.SuspendLayout();
			this.ToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.ToolStripContainer.ContentPanel.SuspendLayout();
			this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.ToolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitViewer)).BeginInit();
			this.SplitViewer.Panel1.SuspendLayout();
			this.SplitViewer.Panel2.SuspendLayout();
			this.SplitViewer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitMeta)).BeginInit();
			this.SplitMeta.Panel1.SuspendLayout();
			this.SplitMeta.Panel2.SuspendLayout();
			this.SplitMeta.SuspendLayout();
			this.LyrMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitFol)).BeginInit();
			this.SplitFol.Panel1.SuspendLayout();
			this.SplitFol.Panel2.SuspendLayout();
			this.SplitFol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitPls)).BeginInit();
			this.SplitPls.Panel1.SuspendLayout();
			this.SplitPls.Panel2.SuspendLayout();
			this.SplitPls.SuspendLayout();
			this.VidMenu.SuspendLayout();
			this.ToolBar.SuspendLayout();
			this.FileMenu.SuspendLayout();
			this.TreeMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusBar
			// 
			this.StatusBar.Dock = System.Windows.Forms.DockStyle.None;
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusSearch,
            this.StatusFile});
			this.StatusBar.Location = new System.Drawing.Point(0, 0);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(1087, 24);
			this.StatusBar.TabIndex = 6;
			this.StatusBar.Text = "StatusStrip";
			// 
			// StatusSearch
			// 
			this.StatusSearch.Name = "StatusSearch";
			this.StatusSearch.Size = new System.Drawing.Size(1005, 19);
			this.StatusSearch.Spring = true;
			this.StatusSearch.Text = "InfoBar";
			// 
			// StatusFile
			// 
			this.StatusFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.StatusFile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.StatusFile.Name = "StatusFile";
			this.StatusFile.Size = new System.Drawing.Size(67, 19);
			this.StatusFile.Text = "some.mp3";
			// 
			// SearchModes
			// 
			this.SearchModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchModes.DropDownWidth = 100;
			this.SearchModes.Items.AddRange(new object[] {
            "File Name",
            "Full Path",
            "Folder"});
			this.SearchModes.Location = new System.Drawing.Point(0, 3);
			this.SearchModes.MaxDropDownItems = 4;
			this.SearchModes.Name = "SearchModes";
			this.SearchModes.Size = new System.Drawing.Size(20, 21);
			this.SearchModes.TabIndex = 8;
			this.ToolTip.SetToolTip(this.SearchModes, "Search In");
			// 
			// FolderFilter
			// 
			this.FolderFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FolderFilter.Location = new System.Drawing.Point(304, 4);
			this.FolderFilter.Multiline = true;
			this.FolderFilter.Name = "FolderFilter";
			this.FolderFilter.Size = new System.Drawing.Size(54, 20);
			this.FolderFilter.TabIndex = 6;
			this.ToolTip.SetToolTip(this.FolderFilter, "Search Current Folder");
			// 
			// SearchFilter
			// 
			this.SearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchFilter.ContextMenuStrip = this.HistoryMenu;
			this.SearchFilter.Location = new System.Drawing.Point(40, 4);
			this.SearchFilter.Multiline = true;
			this.SearchFilter.Name = "SearchFilter";
			this.SearchFilter.Size = new System.Drawing.Size(174, 19);
			this.SearchFilter.TabIndex = 5;
			this.ToolTip.SetToolTip(this.SearchFilter, "Search Library");
			// 
			// HistoryMenu
			// 
			this.HistoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryItemClear,
            this.HistoryItemManage,
            this.toolStripSeparator7});
			this.HistoryMenu.Name = "HistoryMenu";
			this.HistoryMenu.Size = new System.Drawing.Size(168, 54);
			this.HistoryMenu.Opening += new System.ComponentModel.CancelEventHandler(this.HistoryMenu_Opening);
			// 
			// HistoryItemClear
			// 
			this.HistoryItemClear.Name = "HistoryItemClear";
			this.HistoryItemClear.Size = new System.Drawing.Size(167, 22);
			this.HistoryItemClear.Text = "Clear History";
			// 
			// HistoryItemManage
			// 
			this.HistoryItemManage.Name = "HistoryItemManage";
			this.HistoryItemManage.Size = new System.Drawing.Size(167, 22);
			this.HistoryItemManage.Text = "Manage History...";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(164, 6);
			// 
			// ExtensionsFilter
			// 
			this.ExtensionsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ExtensionsFilter.DropDownWidth = 100;
			this.ExtensionsFilter.Items.AddRange(new object[] {
            "|All",
            "^txt,src|Media"});
			this.ExtensionsFilter.Location = new System.Drawing.Point(220, 3);
			this.ExtensionsFilter.MaxDropDownItems = 4;
			this.ExtensionsFilter.Name = "ExtensionsFilter";
			this.ExtensionsFilter.Size = new System.Drawing.Size(78, 21);
			this.ExtensionsFilter.TabIndex = 10;
			this.ToolTip.SetToolTip(this.ExtensionsFilter, "Search In");
			// 
			// MetaFullscreen
			// 
			this.MetaFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MetaFullscreen.AutoSize = true;
			this.MetaFullscreen.Location = new System.Drawing.Point(367, 3);
			this.MetaFullscreen.Name = "MetaFullscreen";
			this.MetaFullscreen.Size = new System.Drawing.Size(39, 17);
			this.MetaFullscreen.TabIndex = 10;
			this.MetaFullscreen.Text = "FS";
			this.ToolTip.SetToolTip(this.MetaFullscreen, "Fullscreen");
			this.MetaFullscreen.UseVisualStyleBackColor = true;
			this.MetaFullscreen.CheckedChanged += new System.EventHandler(this.MetaFullscreen_CheckedChanged);
			// 
			// ToolStripContainer
			// 
			// 
			// ToolStripContainer.BottomToolStripPanel
			// 
			this.ToolStripContainer.BottomToolStripPanel.Controls.Add(this.StatusBar);
			// 
			// ToolStripContainer.ContentPanel
			// 
			this.ToolStripContainer.ContentPanel.Controls.Add(this.SplitViewer);
			this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1087, 388);
			this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer.Name = "ToolStripContainer";
			this.ToolStripContainer.Size = new System.Drawing.Size(1087, 467);
			this.ToolStripContainer.TabIndex = 8;
			this.ToolStripContainer.Text = "ToolStripContainer1";
			// 
			// ToolStripContainer.TopToolStripPanel
			// 
			this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.VidMenu);
			this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.ToolBar);
			// 
			// SplitViewer
			// 
			this.SplitViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitViewer.Location = new System.Drawing.Point(0, 0);
			this.SplitViewer.Name = "SplitViewer";
			this.SplitViewer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitViewer.Panel1
			// 
			this.SplitViewer.Panel1.Controls.Add(this.SplitMeta);
			this.SplitViewer.Panel1.Padding = new System.Windows.Forms.Padding(2);
			this.SplitViewer.Panel1.Resize += new System.EventHandler(this.plrCont_Resised);
			// 
			// SplitViewer.Panel2
			// 
			this.SplitViewer.Panel2.Controls.Add(this.SplitFol);
			this.SplitViewer.Size = new System.Drawing.Size(1087, 388);
			this.SplitViewer.SplitterDistance = 124;
			this.SplitViewer.TabIndex = 3;
			this.SplitViewer.TabStop = false;
			// 
			// SplitMeta
			// 
			this.SplitMeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitMeta.Location = new System.Drawing.Point(2, 2);
			this.SplitMeta.Name = "SplitMeta";
			// 
			// SplitMeta.Panel1
			// 
			this.SplitMeta.Panel1.Controls.Add(this.lblDuration);
			this.SplitMeta.Panel1.Controls.Add(this.lblLyrics);
			this.SplitMeta.Panel1.Controls.Add(this.Player);
			// 
			// SplitMeta.Panel2
			// 
			this.SplitMeta.Panel2.Controls.Add(this.MetaFullscreen);
			this.SplitMeta.Panel2.Controls.Add(this.MetaText);
			this.SplitMeta.Panel2.Controls.Add(this.MetaLyrics);
			this.SplitMeta.Size = new System.Drawing.Size(1083, 120);
			this.SplitMeta.SplitterDistance = 648;
			this.SplitMeta.TabIndex = 6;
			// 
			// lblDuration
			// 
			this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDuration.AutoSize = true;
			this.lblDuration.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDuration.Location = new System.Drawing.Point(611, 93);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Size = new System.Drawing.Size(24, 15);
			this.lblDuration.TabIndex = 5;
			this.lblDuration.Text = "0:0";
			this.lblDuration.Visible = false;
			// 
			// lblLyrics
			// 
			this.lblLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLyrics.AutoSize = true;
			this.lblLyrics.BackColor = System.Drawing.Color.Black;
			this.lblLyrics.ContextMenuStrip = this.LyrMenu;
			this.lblLyrics.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblLyrics.Location = new System.Drawing.Point(621, 9);
			this.lblLyrics.Name = "lblLyrics";
			this.lblLyrics.Size = new System.Drawing.Size(23, 18);
			this.lblLyrics.TabIndex = 5;
			this.lblLyrics.Text = "...";
			this.lblLyrics.Visible = false;
			// 
			// LyrMenu
			// 
			this.LyrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LyrIncreaseSizeMnu,
            this.LyrDecreaseSizeMnu,
            this.LyrColorMnu});
			this.LyrMenu.Name = "LyrMenu";
			this.LyrMenu.Size = new System.Drawing.Size(183, 70);
			// 
			// LyrIncreaseSizeMnu
			// 
			this.LyrIncreaseSizeMnu.Name = "LyrIncreaseSizeMnu";
			this.LyrIncreaseSizeMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
			this.LyrIncreaseSizeMnu.Size = new System.Drawing.Size(182, 22);
			this.LyrIncreaseSizeMnu.Text = "Increase Size";
			this.LyrIncreaseSizeMnu.ToolTipText = "Increase the Font Size of the Lyrics Display";
			this.LyrIncreaseSizeMnu.Click += new System.EventHandler(this.LyrFontSizeMnu_Click);
			// 
			// LyrDecreaseSizeMnu
			// 
			this.LyrDecreaseSizeMnu.Name = "LyrDecreaseSizeMnu";
			this.LyrDecreaseSizeMnu.ShortcutKeyDisplayString = "";
			this.LyrDecreaseSizeMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
			this.LyrDecreaseSizeMnu.Size = new System.Drawing.Size(182, 22);
			this.LyrDecreaseSizeMnu.Text = "Decrease Size";
			this.LyrDecreaseSizeMnu.ToolTipText = "Decrease the Font Size of the Lyrics Display";
			this.LyrDecreaseSizeMnu.Click += new System.EventHandler(this.LyrFontSizeMnu_Click);
			// 
			// LyrColorMnu
			// 
			this.LyrColorMnu.Name = "LyrColorMnu";
			this.LyrColorMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.LyrColorMnu.Size = new System.Drawing.Size(182, 22);
			this.LyrColorMnu.Text = "Color";
			this.LyrColorMnu.ToolTipText = "Set the color of the Lyrics Display";
			this.LyrColorMnu.Click += new System.EventHandler(this.LyrColorMnu_Click);
			// 
			// Player
			// 
			this.Player.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player.Enabled = true;
			this.Player.Location = new System.Drawing.Point(0, 0);
			this.Player.Name = "Player";
			this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
			this.Player.Size = new System.Drawing.Size(648, 120);
			this.Player.TabIndex = 4;
			this.Player.TabStop = false;
			// 
			// MetaText
			// 
			this.MetaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MetaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MetaText.Location = new System.Drawing.Point(0, 0);
			this.MetaText.Multiline = true;
			this.MetaText.Name = "MetaText";
			this.MetaText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.MetaText.Size = new System.Drawing.Size(428, 117);
			this.MetaText.TabIndex = 0;
			this.MetaText.TextChanged += new System.EventHandler(this.MetaText_TextChanged);
			// 
			// MetaLyrics
			// 
			this.MetaLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MetaLyrics.Location = new System.Drawing.Point(2, 0);
			this.MetaLyrics.Name = "MetaLyrics";
			this.MetaLyrics.Size = new System.Drawing.Size(428, 120);
			this.MetaLyrics.TabIndex = 9;
			// 
			// SplitFol
			// 
			this.SplitFol.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitFol.Location = new System.Drawing.Point(0, 0);
			this.SplitFol.Name = "SplitFol";
			// 
			// SplitFol.Panel1
			// 
			this.SplitFol.Panel1.Controls.Add(this.fols);
			this.SplitFol.Panel1MinSize = 100;
			// 
			// SplitFol.Panel2
			// 
			this.SplitFol.Panel2.Controls.Add(this.SplitPls);
			this.SplitFol.Size = new System.Drawing.Size(1087, 260);
			this.SplitFol.SplitterDistance = 344;
			this.SplitFol.TabIndex = 0;
			this.SplitFol.TabStop = false;
			this.SplitFol.Text = "SplitContainer1";
			// 
			// fols
			// 
			this.fols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fols.HideSelection = false;
			this.fols.ImageIndex = 0;
			this.fols.ImageList = this.FolIcons;
			this.fols.Location = new System.Drawing.Point(0, 0);
			this.fols.Name = "fols";
			this.fols.SelectedImageIndex = 1;
			this.fols.ShowLines = false;
			this.fols.Size = new System.Drawing.Size(344, 260);
			this.fols.TabIndex = 0;
			// 
			// FolIcons
			// 
			this.FolIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FolIcons.ImageStream")));
			this.FolIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.FolIcons.Images.SetKeyName(0, "fol");
			this.FolIcons.Images.SetKeyName(1, "cur");
			this.FolIcons.Images.SetKeyName(2, "Root");
			this.FolIcons.Images.SetKeyName(3, "Drive");
			this.FolIcons.Images.SetKeyName(4, "CD");
			this.FolIcons.Images.SetKeyName(5, "fave");
			this.FolIcons.Images.SetKeyName(6, "ClosedFolder");
			this.FolIcons.Images.SetKeyName(7, "OpenFolder");
			// 
			// SplitPls
			// 
			this.SplitPls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitPls.Location = new System.Drawing.Point(0, 0);
			this.SplitPls.Name = "SplitPls";
			// 
			// SplitPls.Panel1
			// 
			this.SplitPls.Panel1.Controls.Add(this.lblMode);
			this.SplitPls.Panel1.Controls.Add(this.SearchModes);
			this.SplitPls.Panel1.Controls.Add(this.FolderFilter);
			this.SplitPls.Panel1.Controls.Add(this.ExtensionsFilter);
			this.SplitPls.Panel1.Controls.Add(this.SearchFilter);
			this.SplitPls.Panel1.Controls.Add(this.fils);
			// 
			// SplitPls.Panel2
			// 
			this.SplitPls.Panel2.Controls.Add(this.playlist);
			this.SplitPls.Size = new System.Drawing.Size(739, 260);
			this.SplitPls.SplitterDistance = 360;
			this.SplitPls.TabIndex = 5;
			// 
			// lblMode
			// 
			this.lblMode.AutoSize = true;
			this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMode.Location = new System.Drawing.Point(23, 7);
			this.lblMode.Margin = new System.Windows.Forms.Padding(0);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(16, 13);
			this.lblMode.TabIndex = 9;
			this.lblMode.Text = "N";
			// 
			// fils
			// 
			this.fils.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fils.CheckBoxes = true;
			this.fils.FullRowSelect = true;
			this.fils.HideSelection = false;
			this.fils.LargeImageList = this.LargeFileIcons;
			this.fils.Location = new System.Drawing.Point(2, 27);
			this.fils.Name = "fils";
			this.fils.Size = new System.Drawing.Size(356, 231);
			this.fils.SmallImageList = this.SmallFileIcons;
			this.fils.TabIndex = 7;
			this.fils.UseCompatibleStateImageBehavior = false;
			this.fils.View = System.Windows.Forms.View.Details;
			// 
			// LargeFileIcons
			// 
			this.LargeFileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeFileIcons.ImageStream")));
			this.LargeFileIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.LargeFileIcons.Images.SetKeyName(0, "file");
			this.LargeFileIcons.Images.SetKeyName(1, "nofile");
			// 
			// SmallFileIcons
			// 
			this.SmallFileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallFileIcons.ImageStream")));
			this.SmallFileIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.SmallFileIcons.Images.SetKeyName(0, "file");
			this.SmallFileIcons.Images.SetKeyName(1, "nofile");
			// 
			// playlist
			// 
			this.playlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.playlist.FullRowSelect = true;
			this.playlist.HideSelection = false;
			this.playlist.LargeImageList = this.LargeFileIcons;
			this.playlist.Location = new System.Drawing.Point(0, 0);
			this.playlist.Name = "playlist";
			this.playlist.Size = new System.Drawing.Size(375, 260);
			this.playlist.SmallImageList = this.SmallFileIcons;
			this.playlist.TabIndex = 4;
			this.playlist.UseCompatibleStateImageBehavior = false;
			this.playlist.View = System.Windows.Forms.View.Details;
			// 
			// VidMenu
			// 
			this.VidMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.VidMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuView,
            this.MnuMedia,
            this.MnuTools,
            this.MnuHelp});
			this.VidMenu.Location = new System.Drawing.Point(0, 0);
			this.VidMenu.Name = "VidMenu";
			this.VidMenu.Size = new System.Drawing.Size(1087, 24);
			this.VidMenu.TabIndex = 0;
			this.VidMenu.Text = "MenuStrip1";
			// 
			// MnuFile
			// 
			this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlsNewMnu,
            this.PlsOpenMnu,
            this.SepFile1,
            this.PlsSaveMnu,
            this.PlsSaveAsMnu,
            this.PlsOpenFolderMnu,
            this.PlsRefreshMnu,
            this.PlsFixMnu,
            this.SepFile2,
            this.FileExitMnu});
			this.MnuFile.Name = "MnuFile";
			this.MnuFile.Size = new System.Drawing.Size(37, 20);
			this.MnuFile.Text = "&File";
			// 
			// PlsNewMnu
			// 
			this.PlsNewMnu.ImageTransparentColor = System.Drawing.Color.Black;
			this.PlsNewMnu.Name = "PlsNewMnu";
			this.PlsNewMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.PlsNewMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsNewMnu.Text = "&New";
			// 
			// PlsOpenMnu
			// 
			this.PlsOpenMnu.ImageTransparentColor = System.Drawing.Color.Black;
			this.PlsOpenMnu.Name = "PlsOpenMnu";
			this.PlsOpenMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.PlsOpenMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsOpenMnu.Text = "&Open";
			// 
			// SepFile1
			// 
			this.SepFile1.Name = "SepFile1";
			this.SepFile1.Size = new System.Drawing.Size(167, 6);
			// 
			// PlsSaveMnu
			// 
			this.PlsSaveMnu.ImageTransparentColor = System.Drawing.Color.Black;
			this.PlsSaveMnu.Name = "PlsSaveMnu";
			this.PlsSaveMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.PlsSaveMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsSaveMnu.Text = "&Save";
			// 
			// PlsSaveAsMnu
			// 
			this.PlsSaveAsMnu.Name = "PlsSaveAsMnu";
			this.PlsSaveAsMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsSaveAsMnu.Text = "Save &As";
			// 
			// PlsOpenFolderMnu
			// 
			this.PlsOpenFolderMnu.Name = "PlsOpenFolderMnu";
			this.PlsOpenFolderMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsOpenFolderMnu.Text = "Open Folder";
			// 
			// PlsRefreshMnu
			// 
			this.PlsRefreshMnu.Name = "PlsRefreshMnu";
			this.PlsRefreshMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsRefreshMnu.Text = "Refresh List";
			// 
			// PlsFixMnu
			// 
			this.PlsFixMnu.Name = "PlsFixMnu";
			this.PlsFixMnu.Size = new System.Drawing.Size(170, 22);
			this.PlsFixMnu.Text = "Fix Broken";
			this.PlsFixMnu.Visible = false;
			// 
			// SepFile2
			// 
			this.SepFile2.Name = "SepFile2";
			this.SepFile2.Size = new System.Drawing.Size(167, 6);
			// 
			// FileExitMnu
			// 
			this.FileExitMnu.Name = "FileExitMnu";
			this.FileExitMnu.Size = new System.Drawing.Size(170, 22);
			this.FileExitMnu.Text = "E&xit";
			this.FileExitMnu.Click += new System.EventHandler(this.FileExitMnu_Click);
			// 
			// MnuView
			// 
			this.MnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolBarMnu,
            this.ViewStatusBarMnu,
            this.ViewFolsMnu,
            this.ViewHorzMnu,
            this.SepView1,
            this.ViewReturnMnu,
            this.ViewPlaylistVerticalMnu});
			this.MnuView.Name = "MnuView";
			this.MnuView.Size = new System.Drawing.Size(44, 20);
			this.MnuView.Text = "&View";
			// 
			// ViewToolBarMnu
			// 
			this.ViewToolBarMnu.Checked = true;
			this.ViewToolBarMnu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewToolBarMnu.Name = "ViewToolBarMnu";
			this.ViewToolBarMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.ViewToolBarMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewToolBarMnu.Text = "&Toolbar";
			this.ViewToolBarMnu.Click += new System.EventHandler(this.ViewToolBarMnu_Click);
			// 
			// ViewStatusBarMnu
			// 
			this.ViewStatusBarMnu.Checked = true;
			this.ViewStatusBarMnu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewStatusBarMnu.Name = "ViewStatusBarMnu";
			this.ViewStatusBarMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.ViewStatusBarMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewStatusBarMnu.Text = "&Status Bar";
			this.ViewStatusBarMnu.Click += new System.EventHandler(this.ViewStatusBarMnu_Click);
			// 
			// ViewFolsMnu
			// 
			this.ViewFolsMnu.Checked = true;
			this.ViewFolsMnu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewFolsMnu.Name = "ViewFolsMnu";
			this.ViewFolsMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.ViewFolsMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewFolsMnu.Text = "&Folders";
			this.ViewFolsMnu.Click += new System.EventHandler(this.ViewFolsToggle);
			// 
			// ViewHorzMnu
			// 
			this.ViewHorzMnu.Checked = true;
			this.ViewHorzMnu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewHorzMnu.Name = "ViewHorzMnu";
			this.ViewHorzMnu.ShortcutKeyDisplayString = "";
			this.ViewHorzMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
			this.ViewHorzMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewHorzMnu.Text = "Horizontal";
			this.ViewHorzMnu.Click += new System.EventHandler(this.ViewHorzToggle);
			// 
			// SepView1
			// 
			this.SepView1.Name = "SepView1";
			this.SepView1.Size = new System.Drawing.Size(230, 6);
			// 
			// ViewReturnMnu
			// 
			this.ViewReturnMnu.Name = "ViewReturnMnu";
			this.ViewReturnMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
			this.ViewReturnMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewReturnMnu.Text = "&Return Selection";
			this.ViewReturnMnu.Click += new System.EventHandler(this.ViewReturnMnu_Click);
			// 
			// ViewPlaylistVerticalMnu
			// 
			this.ViewPlaylistVerticalMnu.Name = "ViewPlaylistVerticalMnu";
			this.ViewPlaylistVerticalMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.ViewPlaylistVerticalMnu.Size = new System.Drawing.Size(233, 22);
			this.ViewPlaylistVerticalMnu.Text = "Playlist &Vertical";
			this.ViewPlaylistVerticalMnu.ToolTipText = "Show Playlist and Filelist side by side";
			// 
			// MnuMedia
			// 
			this.MnuMedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MediaRestartMnu,
            this.MediaStopMnu,
            this.SepMedia1,
            this.MediaVolumeUpMnu,
            this.MediaVolumeDownMnu,
            this.MediaVolumeMuteMnu,
            this.SepMedia2,
            this.MediaPanLeftMnu,
            this.MediaPanRightMnu,
            this.MediaPlayedHistoryMnu,
            this.toolStripSeparator1,
            this.MediaSearchLyricsMnu,
            this.MediaOpenMetaMnu,
            this.MediaSaveMetaMnu});
			this.MnuMedia.Name = "MnuMedia";
			this.MnuMedia.Size = new System.Drawing.Size(52, 20);
			this.MnuMedia.Text = "&Media";
			// 
			// MediaRestartMnu
			// 
			this.MediaRestartMnu.Name = "MediaRestartMnu";
			this.MediaRestartMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.MediaRestartMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaRestartMnu.Text = "Restart &Play";
			this.MediaRestartMnu.Click += new System.EventHandler(this.MediaRestartMnu_Click);
			// 
			// MediaStopMnu
			// 
			this.MediaStopMnu.CheckOnClick = true;
			this.MediaStopMnu.Name = "MediaStopMnu";
			this.MediaStopMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.MediaStopMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaStopMnu.Text = "Stop Play";
			// 
			// SepMedia1
			// 
			this.SepMedia1.Name = "SepMedia1";
			this.SepMedia1.Size = new System.Drawing.Size(210, 6);
			// 
			// MediaVolumeUpMnu
			// 
			this.MediaVolumeUpMnu.Name = "MediaVolumeUpMnu";
			this.MediaVolumeUpMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.MediaVolumeUpMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaVolumeUpMnu.Tag = "1";
			this.MediaVolumeUpMnu.Text = "Volume &Up";
			this.MediaVolumeUpMnu.Click += new System.EventHandler(this.MediaVolumeMnu_Click);
			// 
			// MediaVolumeDownMnu
			// 
			this.MediaVolumeDownMnu.Name = "MediaVolumeDownMnu";
			this.MediaVolumeDownMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this.MediaVolumeDownMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaVolumeDownMnu.Tag = "-1";
			this.MediaVolumeDownMnu.Text = "Volume &Down";
			this.MediaVolumeDownMnu.Click += new System.EventHandler(this.MediaVolumeMnu_Click);
			// 
			// MediaVolumeMuteMnu
			// 
			this.MediaVolumeMuteMnu.Name = "MediaVolumeMuteMnu";
			this.MediaVolumeMuteMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
			this.MediaVolumeMuteMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaVolumeMuteMnu.Text = "Volume &Mute";
			this.MediaVolumeMuteMnu.CheckStateChanged += new System.EventHandler(this.MediaVolumeMuteMnu_Click);
			// 
			// SepMedia2
			// 
			this.SepMedia2.Name = "SepMedia2";
			this.SepMedia2.Size = new System.Drawing.Size(210, 6);
			// 
			// MediaPanLeftMnu
			// 
			this.MediaPanLeftMnu.Name = "MediaPanLeftMnu";
			this.MediaPanLeftMnu.ShortcutKeyDisplayString = "Alt + Left";
			this.MediaPanLeftMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaPanLeftMnu.Tag = "NB: Shift and Alt will also be handled in the form\'s KeyPreview";
			this.MediaPanLeftMnu.Text = "Pan Left";
			this.MediaPanLeftMnu.Click += new System.EventHandler(this.MediaPanMnu_Click);
			// 
			// MediaPanRightMnu
			// 
			this.MediaPanRightMnu.Name = "MediaPanRightMnu";
			this.MediaPanRightMnu.ShortcutKeyDisplayString = "Alt + Right";
			this.MediaPanRightMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaPanRightMnu.Tag = "NB: Shift and Alt will also be handled in the form\'s KeyPreview";
			this.MediaPanRightMnu.Text = "Pan Right";
			this.MediaPanRightMnu.Click += new System.EventHandler(this.MediaPanMnu_Click);
			// 
			// MediaPlayedHistoryMnu
			// 
			this.MediaPlayedHistoryMnu.Name = "MediaPlayedHistoryMnu";
			this.MediaPlayedHistoryMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.MediaPlayedHistoryMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaPlayedHistoryMnu.Text = "Played History";
			this.MediaPlayedHistoryMnu.Click += new System.EventHandler(this.MediaPlayedHistoryMnu_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
			// 
			// MediaSearchLyricsMnu
			// 
			this.MediaSearchLyricsMnu.Name = "MediaSearchLyricsMnu";
			this.MediaSearchLyricsMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.MediaSearchLyricsMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaSearchLyricsMnu.Text = "Search Lyrics";
			this.MediaSearchLyricsMnu.Click += new System.EventHandler(this.MediaSearchLyricsMnu_Click);
			// 
			// MediaOpenMetaMnu
			// 
			this.MediaOpenMetaMnu.Name = "MediaOpenMetaMnu";
			this.MediaOpenMetaMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.MediaOpenMetaMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaOpenMetaMnu.Text = "Open Meta (.txt)";
			this.MediaOpenMetaMnu.Click += new System.EventHandler(this.MediaOpenMetaMnu_Click);
			// 
			// MediaSaveMetaMnu
			// 
			this.MediaSaveMetaMnu.Name = "MediaSaveMetaMnu";
			this.MediaSaveMetaMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.MediaSaveMetaMnu.Size = new System.Drawing.Size(213, 22);
			this.MediaSaveMetaMnu.Text = "Save Meta";
			this.MediaSaveMetaMnu.Click += new System.EventHandler(this.MediaSaveMetaMnu_Click);
			// 
			// MnuTools
			// 
			this.MnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsReloadMediaLibraryMnu,
            this.ToolsSaveMediaLibraryMnu,
            this.ToolsInvalidFileLinksMnu,
            this.ToolsLyricsDisplayMnu,
            this.ToolsViewOrganizerMnu,
            this.ToolsCheckPlaylistMnu,
            this.ToolsDataManagerMnu,
            this.SepTools1,
            this.ToolsOptionsMnu});
			this.MnuTools.Name = "MnuTools";
			this.MnuTools.Size = new System.Drawing.Size(46, 20);
			this.MnuTools.Text = "&Tools";
			// 
			// ToolsReloadMediaLibraryMnu
			// 
			this.ToolsReloadMediaLibraryMnu.Name = "ToolsReloadMediaLibraryMnu";
			this.ToolsReloadMediaLibraryMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsReloadMediaLibraryMnu.Text = "Reload Media Library";
			this.ToolsReloadMediaLibraryMnu.Click += new System.EventHandler(this.ToolsReloadMediaLibraryMnu_Click);
			// 
			// ToolsSaveMediaLibraryMnu
			// 
			this.ToolsSaveMediaLibraryMnu.Name = "ToolsSaveMediaLibraryMnu";
			this.ToolsSaveMediaLibraryMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsSaveMediaLibraryMnu.Text = "Save Media Library";
			this.ToolsSaveMediaLibraryMnu.Click += new System.EventHandler(this.ToolsSaveMediaLibraryMnu_Click);
			// 
			// ToolsInvalidFileLinksMnu
			// 
			this.ToolsInvalidFileLinksMnu.Name = "ToolsInvalidFileLinksMnu";
			this.ToolsInvalidFileLinksMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsInvalidFileLinksMnu.Text = "Show Invalid File Links";
			this.ToolsInvalidFileLinksMnu.Click += new System.EventHandler(this.ToolsInvalidFileLinksMnu_Click);
			// 
			// ToolsLyricsDisplayMnu
			// 
			this.ToolsLyricsDisplayMnu.Name = "ToolsLyricsDisplayMnu";
			this.ToolsLyricsDisplayMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsLyricsDisplayMnu.Text = "Lyrics Display";
			this.ToolsLyricsDisplayMnu.Visible = false;
			// 
			// ToolsViewOrganizerMnu
			// 
			this.ToolsViewOrganizerMnu.Name = "ToolsViewOrganizerMnu";
			this.ToolsViewOrganizerMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsViewOrganizerMnu.Text = "View Organizer";
			// 
			// ToolsCheckPlaylistMnu
			// 
			this.ToolsCheckPlaylistMnu.Name = "ToolsCheckPlaylistMnu";
			this.ToolsCheckPlaylistMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsCheckPlaylistMnu.Text = "Check Playlist";
			this.ToolsCheckPlaylistMnu.ToolTipText = "Checks files that exist in the playlist";
			// 
			// ToolsDataManagerMnu
			// 
			this.ToolsDataManagerMnu.Name = "ToolsDataManagerMnu";
			this.ToolsDataManagerMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsDataManagerMnu.Text = "&Data Manager";
			this.ToolsDataManagerMnu.Click += new System.EventHandler(this.ToolsDataManagerMnu_Click);
			// 
			// SepTools1
			// 
			this.SepTools1.Name = "SepTools1";
			this.SepTools1.Size = new System.Drawing.Size(189, 6);
			// 
			// ToolsOptionsMnu
			// 
			this.ToolsOptionsMnu.Name = "ToolsOptionsMnu";
			this.ToolsOptionsMnu.Size = new System.Drawing.Size(192, 22);
			this.ToolsOptionsMnu.Text = "&Options";
			this.ToolsOptionsMnu.Click += new System.EventHandler(this.ToolsOptionsMnu_Click);
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
			// ToolBar
			// 
			this.ToolBar.AllowItemReorder = true;
			this.ToolBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ToolBar.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewFolsBtn,
            this.ToolStripSeparator8,
            this.ViewHorzBtn,
            this.ToolStripSeparator5,
            this.SelFileBtn,
            this.SelPlsBtn,
            this.SelBothBtn,
            this.PlsVertBtn,
            this.PlsStickBtn,
            this.ToolStripSeparator3,
            this.LViewButtons});
			this.ToolBar.Location = new System.Drawing.Point(3, 24);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(414, 31);
			this.ToolBar.TabIndex = 0;
			this.ToolBar.Text = "ToolStrip1";
			// 
			// ViewFolsBtn
			// 
			this.ViewFolsBtn.Checked = true;
			this.ViewFolsBtn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewFolsBtn.Image = global::Cselian.IViewer.Properties.Resources.fol;
			this.ViewFolsBtn.ImageTransparentColor = System.Drawing.Color.Black;
			this.ViewFolsBtn.Name = "ViewFolsBtn";
			this.ViewFolsBtn.Size = new System.Drawing.Size(73, 28);
			this.ViewFolsBtn.Text = "Folders";
			this.ViewFolsBtn.ToolTipText = "Toggle Folders View";
			this.ViewFolsBtn.Click += new System.EventHandler(this.ViewFolsToggle);
			// 
			// ToolStripSeparator8
			// 
			this.ToolStripSeparator8.Name = "ToolStripSeparator8";
			this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 31);
			// 
			// ViewHorzBtn
			// 
			this.ViewHorzBtn.Checked = true;
			this.ViewHorzBtn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewHorzBtn.Image = global::Cselian.IViewer.Properties.Resources.h;
			this.ViewHorzBtn.ImageTransparentColor = System.Drawing.Color.Black;
			this.ViewHorzBtn.Name = "ViewHorzBtn";
			this.ViewHorzBtn.Size = new System.Drawing.Size(90, 28);
			this.ViewHorzBtn.Text = "Horizontal";
			this.ViewHorzBtn.ToolTipText = "Show Player above song selector";
			this.ViewHorzBtn.Click += new System.EventHandler(this.ViewHorzToggle);
			// 
			// ToolStripSeparator5
			// 
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 31);
			// 
			// SelFileBtn
			// 
			this.SelFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.SelFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelFileBtn.Name = "SelFileBtn";
			this.SelFileBtn.Size = new System.Drawing.Size(44, 28);
			this.SelFileBtn.Text = "Filelist";
			this.SelFileBtn.ToolTipText = "Show Filelist";
			// 
			// SelPlsBtn
			// 
			this.SelPlsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.SelPlsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelPlsBtn.Name = "SelPlsBtn";
			this.SelPlsBtn.Size = new System.Drawing.Size(48, 28);
			this.SelPlsBtn.Text = "Playlist";
			this.SelPlsBtn.ToolTipText = "Show Playlist";
			// 
			// SelBothBtn
			// 
			this.SelBothBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.SelBothBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelBothBtn.Name = "SelBothBtn";
			this.SelBothBtn.Size = new System.Drawing.Size(36, 28);
			this.SelBothBtn.Text = "Both";
			this.SelBothBtn.ToolTipText = "Show both Filelist and Playlist";
			// 
			// PlsVertBtn
			// 
			this.PlsVertBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PlsVertBtn.Image = global::Cselian.IViewer.Properties.Resources.plsv;
			this.PlsVertBtn.ImageTransparentColor = System.Drawing.Color.Black;
			this.PlsVertBtn.Name = "PlsVertBtn";
			this.PlsVertBtn.Size = new System.Drawing.Size(28, 28);
			this.PlsVertBtn.Text = "Playlist &Vertical";
			this.PlsVertBtn.ToolTipText = "Show Playlist beside Filelist not below";
			// 
			// PlsStickBtn
			// 
			this.PlsStickBtn.Checked = true;
			this.PlsStickBtn.CheckOnClick = true;
			this.PlsStickBtn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.PlsStickBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PlsStickBtn.Image = global::Cselian.IViewer.Properties.Resources.stick;
			this.PlsStickBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PlsStickBtn.Name = "PlsStickBtn";
			this.PlsStickBtn.Size = new System.Drawing.Size(28, 28);
			this.PlsStickBtn.Text = "Stic&k to Playlist";
			this.PlsStickBtn.ToolTipText = "Continue playing songs from Playlist when both are open";
			// 
			// ToolStripSeparator3
			// 
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
			// 
			// LViewButtons
			// 
			this.LViewButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LViewButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LViewList,
            this.LViewDetails,
            this.LViewLarge,
            this.LViewSmall,
            this.LViewTile});
			this.LViewButtons.Image = global::Cselian.IViewer.Properties.Resources.view;
			this.LViewButtons.ImageTransparentColor = System.Drawing.Color.Black;
			this.LViewButtons.Name = "LViewButtons";
			this.LViewButtons.Size = new System.Drawing.Size(37, 28);
			this.LViewButtons.Text = "Views";
			this.LViewButtons.ToolTipText = "View for Filelist and Playlist";
			// 
			// LViewList
			// 
			this.LViewList.Name = "LViewList";
			this.LViewList.Size = new System.Drawing.Size(134, 22);
			this.LViewList.Tag = "3";
			this.LViewList.Text = "List";
			this.LViewList.Click += new System.EventHandler(this.LViewMnu_Click);
			// 
			// LViewDetails
			// 
			this.LViewDetails.Checked = true;
			this.LViewDetails.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LViewDetails.Name = "LViewDetails";
			this.LViewDetails.Size = new System.Drawing.Size(134, 22);
			this.LViewDetails.Tag = "1";
			this.LViewDetails.Text = "Details";
			this.LViewDetails.Click += new System.EventHandler(this.LViewMnu_Click);
			// 
			// LViewLarge
			// 
			this.LViewLarge.Name = "LViewLarge";
			this.LViewLarge.Size = new System.Drawing.Size(134, 22);
			this.LViewLarge.Tag = "0";
			this.LViewLarge.Text = "Large Icons";
			this.LViewLarge.Click += new System.EventHandler(this.LViewMnu_Click);
			// 
			// LViewSmall
			// 
			this.LViewSmall.Name = "LViewSmall";
			this.LViewSmall.Size = new System.Drawing.Size(134, 22);
			this.LViewSmall.Tag = "2";
			this.LViewSmall.Text = "Small Icons";
			this.LViewSmall.Click += new System.EventHandler(this.LViewMnu_Click);
			// 
			// LViewTile
			// 
			this.LViewTile.Name = "LViewTile";
			this.LViewTile.Size = new System.Drawing.Size(134, 22);
			this.LViewTile.Tag = "4";
			this.LViewTile.Text = "Tile";
			this.LViewTile.Click += new System.EventHandler(this.LViewMnu_Click);
			// 
			// TreeItemRefresh
			// 
			this.TreeItemRefresh.Name = "TreeItemRefresh";
			this.TreeItemRefresh.Size = new System.Drawing.Size(147, 22);
			this.TreeItemRefresh.Text = "&Refresh Subfolders";
			// 
			// TreeItemOpen
			// 
			this.TreeItemOpen.Name = "TreeItemOpen";
			this.TreeItemOpen.Size = new System.Drawing.Size(147, 22);
			this.TreeItemOpen.Text = "&Open";
			// 
			// FileMenu
			// 
			this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItemOpenContainingFolder,
            this.FileItemGoToFolder,
            this.FileItemCheckAll,
            this.FileItemUncheckAll,
            this.FileItemWindows,
            this.FileItemSearchLyrics});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(202, 136);
			this.FileMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FileMenu_Opening);
			// 
			// FileItemOpenContainingFolder
			// 
			this.FileItemOpenContainingFolder.Name = "FileItemOpenContainingFolder";
			this.FileItemOpenContainingFolder.Size = new System.Drawing.Size(201, 22);
			this.FileItemOpenContainingFolder.Text = "Open &Containing Folder";
			this.FileItemOpenContainingFolder.ToolTipText = "Opens Containing Folder in windows explorer";
			this.FileItemOpenContainingFolder.Click += new System.EventHandler(this.FileItemOpenContainingFolder_Click);
			// 
			// FileItemGoToFolder
			// 
			this.FileItemGoToFolder.Name = "FileItemGoToFolder";
			this.FileItemGoToFolder.Size = new System.Drawing.Size(201, 22);
			this.FileItemGoToFolder.Text = "&Go To Folder";
			this.FileItemGoToFolder.Click += new System.EventHandler(this.FileItemGoToFolder_Click);
			// 
			// FileItemCheckAll
			// 
			this.FileItemCheckAll.Name = "FileItemCheckAll";
			this.FileItemCheckAll.Size = new System.Drawing.Size(201, 22);
			this.FileItemCheckAll.Text = "&Check All";
			this.FileItemCheckAll.Click += new System.EventHandler(this.FileMenuCheck_Click);
			// 
			// FileItemUncheckAll
			// 
			this.FileItemUncheckAll.Name = "FileItemUncheckAll";
			this.FileItemUncheckAll.Size = new System.Drawing.Size(201, 22);
			this.FileItemUncheckAll.Text = "&Uncheck All";
			this.FileItemUncheckAll.Click += new System.EventHandler(this.FileMenuCheck_Click);
			// 
			// FileItemWindows
			// 
			this.FileItemWindows.Name = "FileItemWindows";
			this.FileItemWindows.Size = new System.Drawing.Size(201, 22);
			this.FileItemWindows.Text = "&Windows Menu";
			// 
			// FileItemSearchLyrics
			// 
			this.FileItemSearchLyrics.Name = "FileItemSearchLyrics";
			this.FileItemSearchLyrics.Size = new System.Drawing.Size(201, 22);
			this.FileItemSearchLyrics.Text = "Search Lyrics";
			this.FileItemSearchLyrics.Click += new System.EventHandler(this.FileItemSearchLyrics_Click);
			// 
			// TreeMenu
			// 
			this.TreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TreeItemOpen,
            this.TreeItemFlatten,
            this.TreeItemRefresh});
			this.TreeMenu.Name = "TreeMenu";
			this.TreeMenu.ShowImageMargin = false;
			this.TreeMenu.Size = new System.Drawing.Size(148, 70);
			// 
			// TreeItemFlatten
			// 
			this.TreeItemFlatten.Name = "TreeItemFlatten";
			this.TreeItemFlatten.Size = new System.Drawing.Size(147, 22);
			this.TreeItemFlatten.Text = "Flatten Folder";
			// 
			// PlayNext
			// 
			this.PlayNext.Enabled = true;
			this.PlayNext.Interval = 1000;
			// 
			// PanLyrics
			// 
			this.PanLyrics.Interval = 50;
			this.PanLyrics.Tick += new System.EventHandler(this.tmr_Tick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 467);
			this.Controls.Add(this.ToolStripContainer);
			this.KeyPreview = true;
			this.Name = "Main";
			this.Text = "IViewer 6.0";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.HistoryMenu.ResumeLayout(false);
			this.ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.BottomToolStripPanel.PerformLayout();
			this.ToolStripContainer.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.PerformLayout();
			this.ToolStripContainer.ResumeLayout(false);
			this.ToolStripContainer.PerformLayout();
			this.SplitViewer.Panel1.ResumeLayout(false);
			this.SplitViewer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitViewer)).EndInit();
			this.SplitViewer.ResumeLayout(false);
			this.SplitMeta.Panel1.ResumeLayout(false);
			this.SplitMeta.Panel1.PerformLayout();
			this.SplitMeta.Panel2.ResumeLayout(false);
			this.SplitMeta.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitMeta)).EndInit();
			this.SplitMeta.ResumeLayout(false);
			this.LyrMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
			this.SplitFol.Panel1.ResumeLayout(false);
			this.SplitFol.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitFol)).EndInit();
			this.SplitFol.ResumeLayout(false);
			this.SplitPls.Panel1.ResumeLayout(false);
			this.SplitPls.Panel1.PerformLayout();
			this.SplitPls.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitPls)).EndInit();
			this.SplitPls.ResumeLayout(false);
			this.VidMenu.ResumeLayout(false);
			this.VidMenu.PerformLayout();
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			this.FileMenu.ResumeLayout(false);
			this.TreeMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel StatusSearch;
		private System.Windows.Forms.ToolStripStatusLabel StatusFile;
		private System.Windows.Forms.ComboBox SearchModes;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.TextBox FolderFilter;
		private System.Windows.Forms.TextBox SearchFilter;
		private System.Windows.Forms.ToolStripContainer ToolStripContainer;
		private System.Windows.Forms.SplitContainer SplitViewer;
		private System.Windows.Forms.Label lblDuration;
		private System.Windows.Forms.Label lblLyrics;
		private System.Windows.Forms.ContextMenuStrip LyrMenu;
		private System.Windows.Forms.ToolStripMenuItem LyrIncreaseSizeMnu;
		private System.Windows.Forms.ToolStripMenuItem LyrDecreaseSizeMnu;
		private System.Windows.Forms.ToolStripMenuItem LyrColorMnu;
		private AxWMPLib.AxWindowsMediaPlayer Player;
		private System.Windows.Forms.SplitContainer SplitFol;
		private System.Windows.Forms.TreeView fols;
		private System.Windows.Forms.ImageList FolIcons;
		private System.Windows.Forms.SplitContainer SplitPls;
		private System.Windows.Forms.ListView fils;
		private System.Windows.Forms.ImageList LargeFileIcons;
		private System.Windows.Forms.ImageList SmallFileIcons;
		private System.Windows.Forms.ListView playlist;
		private System.Windows.Forms.MenuStrip VidMenu;
		private System.Windows.Forms.ToolStripMenuItem MnuFile;
		private System.Windows.Forms.ToolStripMenuItem PlsNewMnu;
		private System.Windows.Forms.ToolStripMenuItem PlsOpenMnu;
		private System.Windows.Forms.ToolStripSeparator SepFile1;
		private System.Windows.Forms.ToolStripMenuItem PlsSaveMnu;
		private System.Windows.Forms.ToolStripMenuItem PlsSaveAsMnu;
		private System.Windows.Forms.ToolStripMenuItem FileExitMnu;
		private System.Windows.Forms.ToolStripMenuItem MnuView;
		private System.Windows.Forms.ToolStripMenuItem ViewToolBarMnu;
		private System.Windows.Forms.ToolStripMenuItem ViewStatusBarMnu;
		private System.Windows.Forms.ToolStripMenuItem ViewFolsMnu;
		private System.Windows.Forms.ToolStripMenuItem ViewHorzMnu;
		private System.Windows.Forms.ToolStripSeparator SepView1;
		private System.Windows.Forms.ToolStripMenuItem ViewReturnMnu;
		private System.Windows.Forms.ToolStripMenuItem ViewPlaylistVerticalMnu;
		private System.Windows.Forms.ToolStripMenuItem MnuMedia;
		private System.Windows.Forms.ToolStripMenuItem MediaRestartMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaStopMnu;
		private System.Windows.Forms.ToolStripSeparator SepMedia1;
		private System.Windows.Forms.ToolStripMenuItem MediaVolumeUpMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaVolumeDownMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaVolumeMuteMnu;
		private System.Windows.Forms.ToolStripSeparator SepMedia2;
		private System.Windows.Forms.ToolStripMenuItem MediaPanLeftMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaPanRightMnu;
		private System.Windows.Forms.ToolStripMenuItem MnuTools;
		private System.Windows.Forms.ToolStripMenuItem ToolsReloadMediaLibraryMnu;
		private System.Windows.Forms.ToolStripMenuItem ToolsSaveMediaLibraryMnu;
		private System.Windows.Forms.ToolStripMenuItem ToolsInvalidFileLinksMnu;
		private System.Windows.Forms.ToolStripMenuItem ToolsLyricsDisplayMnu;
		private System.Windows.Forms.ToolStripMenuItem ToolsViewOrganizerMnu;
		private System.Windows.Forms.ToolStripSeparator SepTools1;
		private System.Windows.Forms.ToolStripMenuItem ToolsOptionsMnu;
		private System.Windows.Forms.ToolStripMenuItem MnuHelp;
		private System.Windows.Forms.ToolStripMenuItem HelpReadmeMnu;
		private System.Windows.Forms.ToolStripMenuItem HelpAboutMnu;
		private System.Windows.Forms.ToolStrip ToolBar;
		private System.Windows.Forms.ToolStripButton ViewFolsBtn;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		private System.Windows.Forms.ToolStripButton ViewHorzBtn;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		private System.Windows.Forms.ToolStripButton SelFileBtn;
		private System.Windows.Forms.ToolStripButton SelPlsBtn;
		private System.Windows.Forms.ToolStripButton SelBothBtn;
		private System.Windows.Forms.ToolStripButton PlsVertBtn;
		private System.Windows.Forms.ToolStripButton PlsStickBtn;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		private System.Windows.Forms.ToolStripDropDownButton LViewButtons;
		private System.Windows.Forms.ToolStripMenuItem LViewList;
		private System.Windows.Forms.ToolStripMenuItem LViewDetails;
		private System.Windows.Forms.ToolStripMenuItem LViewLarge;
		private System.Windows.Forms.ToolStripMenuItem LViewSmall;
		private System.Windows.Forms.ToolStripMenuItem LViewTile;
		private System.Windows.Forms.ToolStripMenuItem TreeItemRefresh;
		private System.Windows.Forms.ToolStripMenuItem TreeItemOpen;
		private System.Windows.Forms.ContextMenuStrip FileMenu;
		private System.Windows.Forms.ToolStripMenuItem FileItemOpenContainingFolder;
		private System.Windows.Forms.ToolStripMenuItem FileItemGoToFolder;
		private System.Windows.Forms.ToolStripMenuItem FileItemCheckAll;
		private System.Windows.Forms.ToolStripMenuItem FileItemUncheckAll;
		private System.Windows.Forms.ToolStripMenuItem FileItemWindows;
		private System.Windows.Forms.ContextMenuStrip TreeMenu;
		private System.Windows.Forms.Timer PlayNext;
		private System.Windows.Forms.Timer PanLyrics;
		private System.Windows.Forms.ToolStripMenuItem TreeItemFlatten;
		private System.Windows.Forms.ContextMenuStrip HistoryMenu;
		private System.Windows.Forms.ToolStripMenuItem HistoryItemClear;
		private System.Windows.Forms.ToolStripMenuItem HistoryItemManage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.Label lblMode;
		private System.Windows.Forms.ToolStripMenuItem PlsFixMnu;
		private System.Windows.Forms.ToolStripMenuItem PlsOpenFolderMnu;
		private System.Windows.Forms.ToolStripMenuItem PlsRefreshMnu;
		private System.Windows.Forms.ToolStripSeparator SepFile2;
		private System.Windows.Forms.ToolStripMenuItem MediaSearchLyricsMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaPlayedHistoryMnu;
		private System.Windows.Forms.ToolStripMenuItem FileItemSearchLyrics;
		private System.Windows.Forms.ToolStripMenuItem HelpUpdatesCheckMnu;
		private System.Windows.Forms.ToolStripMenuItem HelpUpdatesSettingsMnu;
		private System.Windows.Forms.ToolStripSeparator SepHelp1;
		private System.Windows.Forms.ToolStripSeparator SepHelp2;
		private System.Windows.Forms.ToolStripMenuItem ToolsCheckPlaylistMnu;
		private System.Windows.Forms.ToolStripMenuItem ToolsDataManagerMnu;
		private System.Windows.Forms.SplitContainer SplitMeta;
		private System.Windows.Forms.ComboBox ExtensionsFilter;
		private System.Windows.Forms.TextBox MetaText;
		private Lyrics MetaLyrics;
		private System.Windows.Forms.CheckBox MetaFullscreen;
		private System.Windows.Forms.ToolStripMenuItem MediaOpenMetaMnu;
		private System.Windows.Forms.ToolStripMenuItem MediaSaveMetaMnu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}