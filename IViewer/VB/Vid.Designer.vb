<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
	Friend WithEvents FolIcons As System.Windows.Forms.ImageList
	Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ViewFolsBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents LViewButtons As System.Windows.Forms.ToolStripDropDownButton
	Friend WithEvents LViewList As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LViewDetails As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LViewLarge As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LViewSmall As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LViewTile As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents VidMenu As System.Windows.Forms.MenuStrip
	Friend WithEvents MnuFile As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PlsNewMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PlsOpenMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PlsSaveMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PlsSaveAsMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents FileExitMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuView As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ViewToolBarMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ViewStatusBarMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ViewFolsMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuTools As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsOptionsMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuHelp As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpAboutMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SplitFol As System.Windows.Forms.SplitContainer
	Friend WithEvents fols As System.Windows.Forms.TreeView
	Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vid))
		Me.StatusBar = New System.Windows.Forms.StatusStrip()
		Me.StatusSearch = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusFile = New System.Windows.Forms.ToolStripStatusLabel()
		Me.FolIcons = New System.Windows.Forms.ImageList(Me.components)
		Me.ToolBar = New System.Windows.Forms.ToolStrip()
		Me.ViewFolsBtn = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.ViewHorzBtn = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelFileBtn = New System.Windows.Forms.ToolStripButton()
		Me.SelPlsBtn = New System.Windows.Forms.ToolStripButton()
		Me.SelBothBtn = New System.Windows.Forms.ToolStripButton()
		Me.PlsVertBtn = New System.Windows.Forms.ToolStripButton()
		Me.PlsStickBtn = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.LViewButtons = New System.Windows.Forms.ToolStripDropDownButton()
		Me.LViewList = New System.Windows.Forms.ToolStripMenuItem()
		Me.LViewDetails = New System.Windows.Forms.ToolStripMenuItem()
		Me.LViewLarge = New System.Windows.Forms.ToolStripMenuItem()
		Me.LViewSmall = New System.Windows.Forms.ToolStripMenuItem()
		Me.LViewTile = New System.Windows.Forms.ToolStripMenuItem()
		Me.VidMenu = New System.Windows.Forms.MenuStrip()
		Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlsNewMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlsOpenMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.PlsSaveMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlsSaveAsMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.FileExitMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MnuView = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolBarMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewStatusBarMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewFolsMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewHorzMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.ViewReturnMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewPlaylistVerticalMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MnuMedia = New System.Windows.Forms.ToolStripMenuItem()
		Me.MediaRestartMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MediaStopMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.MediaVolumeUpMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MediaVolumeDownMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MediaVolumeMuteMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.MediaPanLeftMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MediaPanRightMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MnuTools = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsReloadMediaLibraryMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsSaveMediaLibraryMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsInvalidFileLinksMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsLyricsDisplayMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolsOptionsMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpReadmeMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpAboutMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.FolderFilter = New System.Windows.Forms.TextBox()
		Me.SearchFilter = New System.Windows.Forms.TextBox()
		Me.SearchModes = New System.Windows.Forms.ComboBox()
		Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
		Me.SplitViewer = New System.Windows.Forms.SplitContainer()
		Me.lblDuration = New System.Windows.Forms.Label()
		Me.lblLyrics = New System.Windows.Forms.Label()
		Me.LyrMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.LyrIncreaseSizeMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.LyrDecreaseSizeMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.LyrColorMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.LyrEditorMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
		Me.SplitFol = New System.Windows.Forms.SplitContainer()
		Me.fols = New System.Windows.Forms.TreeView()
		Me.SplitPls = New System.Windows.Forms.SplitContainer()
		Me.fils = New System.Windows.Forms.ListView()
		Me.LargeFileIcons = New System.Windows.Forms.ImageList(Me.components)
		Me.SmallFileIcons = New System.Windows.Forms.ImageList(Me.components)
		Me.playlist = New System.Windows.Forms.ListView()
		Me.PlayNext = New System.Windows.Forms.Timer(Me.components)
		Me.BarIcons = New System.Windows.Forms.ImageList(Me.components)
		Me.TreeMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.TreeItemOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.TreeItemRefresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.FileItemOpenContainingFolder = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileItemGoToFolder = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileItemCheckAll = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileItemUncheckAll = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileItemWindows = New System.Windows.Forms.ToolStripMenuItem()
		Me.PanLyrics = New System.Windows.Forms.Timer(Me.components)
		Me.ToolsViewOrganizerMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusBar.SuspendLayout()
		Me.ToolBar.SuspendLayout()
		Me.VidMenu.SuspendLayout()
		Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
		Me.ToolStripContainer.ContentPanel.SuspendLayout()
		Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer.SuspendLayout()
		Me.SplitViewer.Panel1.SuspendLayout()
		Me.SplitViewer.Panel2.SuspendLayout()
		Me.SplitViewer.SuspendLayout()
		Me.LyrMenu.SuspendLayout()
		CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitFol.Panel1.SuspendLayout()
		Me.SplitFol.Panel2.SuspendLayout()
		Me.SplitFol.SuspendLayout()
		Me.SplitPls.Panel1.SuspendLayout()
		Me.SplitPls.Panel2.SuspendLayout()
		Me.SplitPls.SuspendLayout()
		Me.TreeMenu.SuspendLayout()
		Me.FileMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'StatusBar
		'
		Me.StatusBar.Dock = System.Windows.Forms.DockStyle.None
		Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusSearch, Me.StatusFile})
		Me.StatusBar.Location = New System.Drawing.Point(0, 0)
		Me.StatusBar.Name = "StatusBar"
		Me.StatusBar.Size = New System.Drawing.Size(635, 24)
		Me.StatusBar.TabIndex = 6
		Me.StatusBar.Text = "StatusStrip"
		'
		'StatusSearch
		'
		Me.StatusSearch.Name = "StatusSearch"
		Me.StatusSearch.Size = New System.Drawing.Size(553, 19)
		Me.StatusSearch.Spring = True
		Me.StatusSearch.Text = "InfoBar"
		'
		'StatusFile
		'
		Me.StatusFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.StatusFile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
		Me.StatusFile.Name = "StatusFile"
		Me.StatusFile.Size = New System.Drawing.Size(67, 19)
		Me.StatusFile.Text = "some.mp3"
		'
		'FolIcons
		'
		Me.FolIcons.ImageStream = CType(resources.GetObject("FolIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.FolIcons.TransparentColor = System.Drawing.Color.Transparent
		Me.FolIcons.Images.SetKeyName(0, "fol")
		Me.FolIcons.Images.SetKeyName(1, "cur")
		Me.FolIcons.Images.SetKeyName(2, "Root")
		Me.FolIcons.Images.SetKeyName(3, "Drive")
		Me.FolIcons.Images.SetKeyName(4, "CD")
		Me.FolIcons.Images.SetKeyName(5, "fave")
		Me.FolIcons.Images.SetKeyName(6, "ClosedFolder")
		Me.FolIcons.Images.SetKeyName(7, "OpenFolder")
		'
		'ToolBar
		'
		Me.ToolBar.AllowItemReorder = True
		Me.ToolBar.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.ToolBar.Dock = System.Windows.Forms.DockStyle.None
		Me.ToolBar.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewFolsBtn, Me.ToolStripSeparator8, Me.ViewHorzBtn, Me.ToolStripSeparator5, Me.SelFileBtn, Me.SelPlsBtn, Me.SelBothBtn, Me.PlsVertBtn, Me.PlsStickBtn, Me.ToolStripSeparator3, Me.LViewButtons})
		Me.ToolBar.Location = New System.Drawing.Point(3, 24)
		Me.ToolBar.Name = "ToolBar"
		Me.ToolBar.Size = New System.Drawing.Size(414, 31)
		Me.ToolBar.TabIndex = 0
		Me.ToolBar.Text = "ToolStrip1"
		'
		'ViewFolsBtn
		'
		Me.ViewFolsBtn.Checked = True
		Me.ViewFolsBtn.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewFolsBtn.Image = CType(resources.GetObject("ViewFolsBtn.Image"), System.Drawing.Image)
		Me.ViewFolsBtn.ImageTransparentColor = System.Drawing.Color.Black
		Me.ViewFolsBtn.Name = "ViewFolsBtn"
		Me.ViewFolsBtn.Size = New System.Drawing.Size(73, 28)
		Me.ViewFolsBtn.Text = "Folders"
		Me.ViewFolsBtn.ToolTipText = "Toggle Folders View"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
		'
		'ViewHorzBtn
		'
		Me.ViewHorzBtn.Checked = True
		Me.ViewHorzBtn.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewHorzBtn.Image = Global.Cselian.IViewer.My.Resources.Resources.v
		Me.ViewHorzBtn.ImageTransparentColor = System.Drawing.Color.Black
		Me.ViewHorzBtn.Name = "ViewHorzBtn"
		Me.ViewHorzBtn.Size = New System.Drawing.Size(90, 28)
		Me.ViewHorzBtn.Text = "Horizontal"
		Me.ViewHorzBtn.ToolTipText = "Show Player above song selector"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
		'
		'SelFileBtn
		'
		Me.SelFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SelFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SelFileBtn.Name = "SelFileBtn"
		Me.SelFileBtn.Size = New System.Drawing.Size(44, 28)
		Me.SelFileBtn.Text = "Filelist"
		Me.SelFileBtn.ToolTipText = "Show Filelist"
		'
		'SelPlsBtn
		'
		Me.SelPlsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SelPlsBtn.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SelPlsBtn.Name = "SelPlsBtn"
		Me.SelPlsBtn.Size = New System.Drawing.Size(48, 28)
		Me.SelPlsBtn.Text = "Playlist"
		Me.SelPlsBtn.ToolTipText = "Show Playlist"
		'
		'SelBothBtn
		'
		Me.SelBothBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SelBothBtn.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SelBothBtn.Name = "SelBothBtn"
		Me.SelBothBtn.Size = New System.Drawing.Size(36, 28)
		Me.SelBothBtn.Text = "Both"
		Me.SelBothBtn.ToolTipText = "Show both Filelist and Playlist"
		'
		'PlsVertBtn
		'
		Me.PlsVertBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.PlsVertBtn.Image = Global.Cselian.IViewer.My.Resources.Resources.plsv
		Me.PlsVertBtn.ImageTransparentColor = System.Drawing.Color.Black
		Me.PlsVertBtn.Name = "PlsVertBtn"
		Me.PlsVertBtn.Size = New System.Drawing.Size(28, 28)
		Me.PlsVertBtn.Text = "Playlist &Vertical"
		Me.PlsVertBtn.ToolTipText = "Show Playlist beside Filelist not below"
		'
		'PlsStickBtn
		'
		Me.PlsStickBtn.Checked = True
		Me.PlsStickBtn.CheckOnClick = True
		Me.PlsStickBtn.CheckState = System.Windows.Forms.CheckState.Checked
		Me.PlsStickBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.PlsStickBtn.Image = Global.Cselian.IViewer.My.Resources.Resources.stick
		Me.PlsStickBtn.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PlsStickBtn.Name = "PlsStickBtn"
		Me.PlsStickBtn.Size = New System.Drawing.Size(28, 28)
		Me.PlsStickBtn.Text = "Stic&k to Playlist"
		Me.PlsStickBtn.ToolTipText = "Continue playing songs from Playlist when both are open"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
		'
		'LViewButtons
		'
		Me.LViewButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.LViewButtons.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LViewList, Me.LViewDetails, Me.LViewLarge, Me.LViewSmall, Me.LViewTile})
		Me.LViewButtons.Image = CType(resources.GetObject("LViewButtons.Image"), System.Drawing.Image)
		Me.LViewButtons.ImageTransparentColor = System.Drawing.Color.Black
		Me.LViewButtons.Name = "LViewButtons"
		Me.LViewButtons.Size = New System.Drawing.Size(37, 28)
		Me.LViewButtons.Text = "Views"
		Me.LViewButtons.ToolTipText = "View for Filelist and Playlist"
		'
		'LViewList
		'
		Me.LViewList.Name = "LViewList"
		Me.LViewList.Size = New System.Drawing.Size(134, 22)
		Me.LViewList.Tag = "3"
		Me.LViewList.Text = "List"
		'
		'LViewDetails
		'
		Me.LViewDetails.Checked = True
		Me.LViewDetails.CheckState = System.Windows.Forms.CheckState.Checked
		Me.LViewDetails.Name = "LViewDetails"
		Me.LViewDetails.Size = New System.Drawing.Size(134, 22)
		Me.LViewDetails.Tag = "1"
		Me.LViewDetails.Text = "Details"
		'
		'LViewLarge
		'
		Me.LViewLarge.Name = "LViewLarge"
		Me.LViewLarge.Size = New System.Drawing.Size(134, 22)
		Me.LViewLarge.Tag = "0"
		Me.LViewLarge.Text = "Large Icons"
		'
		'LViewSmall
		'
		Me.LViewSmall.Name = "LViewSmall"
		Me.LViewSmall.Size = New System.Drawing.Size(134, 22)
		Me.LViewSmall.Tag = "2"
		Me.LViewSmall.Text = "Small Icons"
		'
		'LViewTile
		'
		Me.LViewTile.Name = "LViewTile"
		Me.LViewTile.Size = New System.Drawing.Size(134, 22)
		Me.LViewTile.Tag = "4"
		Me.LViewTile.Text = "Tile"
		'
		'VidMenu
		'
		Me.VidMenu.Dock = System.Windows.Forms.DockStyle.None
		Me.VidMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile, Me.MnuView, Me.MnuMedia, Me.MnuTools, Me.MnuHelp})
		Me.VidMenu.Location = New System.Drawing.Point(0, 0)
		Me.VidMenu.Name = "VidMenu"
		Me.VidMenu.Size = New System.Drawing.Size(635, 24)
		Me.VidMenu.TabIndex = 0
		Me.VidMenu.Text = "MenuStrip1"
		'
		'MnuFile
		'
		Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlsNewMnu, Me.PlsOpenMnu, Me.ToolStripSeparator1, Me.PlsSaveMnu, Me.PlsSaveAsMnu, Me.ToolStripSeparator2, Me.FileExitMnu})
		Me.MnuFile.Name = "MnuFile"
		Me.MnuFile.Size = New System.Drawing.Size(37, 20)
		Me.MnuFile.Text = "&File"
		'
		'PlsNewMnu
		'
		Me.PlsNewMnu.ImageTransparentColor = System.Drawing.Color.Black
		Me.PlsNewMnu.Name = "PlsNewMnu"
		Me.PlsNewMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.PlsNewMnu.Size = New System.Drawing.Size(146, 22)
		Me.PlsNewMnu.Text = "&New"
		'
		'PlsOpenMnu
		'
		Me.PlsOpenMnu.ImageTransparentColor = System.Drawing.Color.Black
		Me.PlsOpenMnu.Name = "PlsOpenMnu"
		Me.PlsOpenMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.PlsOpenMnu.Size = New System.Drawing.Size(146, 22)
		Me.PlsOpenMnu.Text = "&Open"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
		'
		'PlsSaveMnu
		'
		Me.PlsSaveMnu.ImageTransparentColor = System.Drawing.Color.Black
		Me.PlsSaveMnu.Name = "PlsSaveMnu"
		Me.PlsSaveMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.PlsSaveMnu.Size = New System.Drawing.Size(146, 22)
		Me.PlsSaveMnu.Text = "&Save"
		'
		'PlsSaveAsMnu
		'
		Me.PlsSaveAsMnu.Name = "PlsSaveAsMnu"
		Me.PlsSaveAsMnu.Size = New System.Drawing.Size(146, 22)
		Me.PlsSaveAsMnu.Text = "Save &As"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
		'
		'FileExitMnu
		'
		Me.FileExitMnu.Name = "FileExitMnu"
		Me.FileExitMnu.Size = New System.Drawing.Size(146, 22)
		Me.FileExitMnu.Text = "E&xit"
		'
		'MnuView
		'
		Me.MnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolBarMnu, Me.ViewStatusBarMnu, Me.ViewFolsMnu, Me.ViewHorzMnu, Me.ToolStripSeparator9, Me.ViewReturnMnu, Me.ViewPlaylistVerticalMnu})
		Me.MnuView.Name = "MnuView"
		Me.MnuView.Size = New System.Drawing.Size(44, 20)
		Me.MnuView.Text = "&View"
		'
		'ViewToolBarMnu
		'
		Me.ViewToolBarMnu.Checked = True
		Me.ViewToolBarMnu.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewToolBarMnu.Name = "ViewToolBarMnu"
		Me.ViewToolBarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
		Me.ViewToolBarMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewToolBarMnu.Text = "&Toolbar"
		'
		'ViewStatusBarMnu
		'
		Me.ViewStatusBarMnu.Checked = True
		Me.ViewStatusBarMnu.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewStatusBarMnu.Name = "ViewStatusBarMnu"
		Me.ViewStatusBarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
		Me.ViewStatusBarMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewStatusBarMnu.Text = "&Status Bar"
		'
		'ViewFolsMnu
		'
		Me.ViewFolsMnu.Checked = True
		Me.ViewFolsMnu.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewFolsMnu.Name = "ViewFolsMnu"
		Me.ViewFolsMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.ViewFolsMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewFolsMnu.Text = "&Folders"
		'
		'ViewHorzMnu
		'
		Me.ViewHorzMnu.Checked = True
		Me.ViewHorzMnu.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ViewHorzMnu.Name = "ViewHorzMnu"
		Me.ViewHorzMnu.ShortcutKeyDisplayString = ""
		Me.ViewHorzMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
		Me.ViewHorzMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewHorzMnu.Text = "Horizontal"
		'
		'ToolStripSeparator9
		'
		Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
		Me.ToolStripSeparator9.Size = New System.Drawing.Size(230, 6)
		'
		'ViewReturnMnu
		'
		Me.ViewReturnMnu.Name = "ViewReturnMnu"
		Me.ViewReturnMnu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
					Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.ViewReturnMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewReturnMnu.Text = "&Return Selection"
		'
		'ViewPlaylistVerticalMnu
		'
		Me.ViewPlaylistVerticalMnu.Name = "ViewPlaylistVerticalMnu"
		Me.ViewPlaylistVerticalMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.ViewPlaylistVerticalMnu.Size = New System.Drawing.Size(233, 22)
		Me.ViewPlaylistVerticalMnu.Text = "Playlist &Vertical"
		Me.ViewPlaylistVerticalMnu.ToolTipText = "Show Playlist and Filelist side by side"
		'
		'MnuMedia
		'
		Me.MnuMedia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaRestartMnu, Me.MediaStopMnu, Me.ToolStripSeparator10, Me.MediaVolumeUpMnu, Me.MediaVolumeDownMnu, Me.MediaVolumeMuteMnu, Me.ToolStripSeparator6, Me.MediaPanLeftMnu, Me.MediaPanRightMnu})
		Me.MnuMedia.Name = "MnuMedia"
		Me.MnuMedia.Size = New System.Drawing.Size(52, 20)
		Me.MnuMedia.Text = "&Media"
		'
		'MediaRestartMnu
		'
		Me.MediaRestartMnu.Name = "MediaRestartMnu"
		Me.MediaRestartMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.MediaRestartMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaRestartMnu.Text = "Restart &Play"
		'
		'MediaStopMnu
		'
		Me.MediaStopMnu.CheckOnClick = True
		Me.MediaStopMnu.Name = "MediaStopMnu"
		Me.MediaStopMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.MediaStopMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaStopMnu.Text = "Stop Play"
		'
		'ToolStripSeparator10
		'
		Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
		Me.ToolStripSeparator10.Size = New System.Drawing.Size(211, 6)
		'
		'MediaVolumeUpMnu
		'
		Me.MediaVolumeUpMnu.Name = "MediaVolumeUpMnu"
		Me.MediaVolumeUpMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
		Me.MediaVolumeUpMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaVolumeUpMnu.Tag = "1"
		Me.MediaVolumeUpMnu.Text = "Volume &Up"
		'
		'MediaVolumeDownMnu
		'
		Me.MediaVolumeDownMnu.Name = "MediaVolumeDownMnu"
		Me.MediaVolumeDownMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
		Me.MediaVolumeDownMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaVolumeDownMnu.Tag = "-1"
		Me.MediaVolumeDownMnu.Text = "Volume &Down"
		'
		'MediaVolumeMuteMnu
		'
		Me.MediaVolumeMuteMnu.Name = "MediaVolumeMuteMnu"
		Me.MediaVolumeMuteMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
		Me.MediaVolumeMuteMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaVolumeMuteMnu.Text = "Volume &Mute"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(211, 6)
		'
		'MediaPanLeftMnu
		'
		Me.MediaPanLeftMnu.Name = "MediaPanLeftMnu"
		Me.MediaPanLeftMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
		Me.MediaPanLeftMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaPanLeftMnu.Tag = "NB: Shift and Alt will also be handled in the ProcessCmdKey"
		Me.MediaPanLeftMnu.Text = "Pan Left"
		'
		'MediaPanRightMnu
		'
		Me.MediaPanRightMnu.Name = "MediaPanRightMnu"
		Me.MediaPanRightMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
		Me.MediaPanRightMnu.Size = New System.Drawing.Size(214, 22)
		Me.MediaPanRightMnu.Tag = "NB: Shift and Alt will also be handled in the ProcessCmdKey"
		Me.MediaPanRightMnu.Text = "Pan Right"
		'
		'MnuTools
		'
		Me.MnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsReloadMediaLibraryMnu, Me.ToolsSaveMediaLibraryMnu, Me.ToolsInvalidFileLinksMnu, Me.ToolsLyricsDisplayMnu, Me.ToolsViewOrganizerMnu, Me.ToolStripSeparator4, Me.ToolsOptionsMnu})
		Me.MnuTools.Name = "MnuTools"
		Me.MnuTools.Size = New System.Drawing.Size(48, 20)
		Me.MnuTools.Text = "&Tools"
		'
		'ToolsReloadMediaLibraryMnu
		'
		Me.ToolsReloadMediaLibraryMnu.Name = "ToolsReloadMediaLibraryMnu"
		Me.ToolsReloadMediaLibraryMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsReloadMediaLibraryMnu.Text = "Reload Media Library"
		'
		'ToolsSaveMediaLibraryMnu
		'
		Me.ToolsSaveMediaLibraryMnu.Name = "ToolsSaveMediaLibraryMnu"
		Me.ToolsSaveMediaLibraryMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsSaveMediaLibraryMnu.Text = "Save Media Library"
		'
		'ToolsInvalidFileLinksMnu
		'
		Me.ToolsInvalidFileLinksMnu.Name = "ToolsInvalidFileLinksMnu"
		Me.ToolsInvalidFileLinksMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsInvalidFileLinksMnu.Text = "Show Invalid File Links"
		'
		'ToolsLyricsDisplayMnu
		'
		Me.ToolsLyricsDisplayMnu.Name = "ToolsLyricsDisplayMnu"
		Me.ToolsLyricsDisplayMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsLyricsDisplayMnu.Text = "Lyrics Display"
		Me.ToolsLyricsDisplayMnu.Visible = False
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
		'
		'ToolsOptionsMnu
		'
		Me.ToolsOptionsMnu.Name = "ToolsOptionsMnu"
		Me.ToolsOptionsMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsOptionsMnu.Text = "&Options"
		'
		'MnuHelp
		'
		Me.MnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpReadmeMnu, Me.HelpAboutMnu})
		Me.MnuHelp.Name = "MnuHelp"
		Me.MnuHelp.Size = New System.Drawing.Size(44, 20)
		Me.MnuHelp.Text = "&Help"
		'
		'HelpReadmeMnu
		'
		Me.HelpReadmeMnu.Name = "HelpReadmeMnu"
		Me.HelpReadmeMnu.ShortcutKeys = System.Windows.Forms.Keys.F1
		Me.HelpReadmeMnu.Size = New System.Drawing.Size(145, 22)
		Me.HelpReadmeMnu.Text = "&Readme..."
		'
		'HelpAboutMnu
		'
		Me.HelpAboutMnu.Name = "HelpAboutMnu"
		Me.HelpAboutMnu.Size = New System.Drawing.Size(145, 22)
		Me.HelpAboutMnu.Text = "&About..."
		'
		'FolderFilter
		'
		Me.FolderFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FolderFilter.Location = New System.Drawing.Point(154, 4)
		Me.FolderFilter.Multiline = True
		Me.FolderFilter.Name = "FolderFilter"
		Me.FolderFilter.Size = New System.Drawing.Size(54, 20)
		Me.FolderFilter.TabIndex = 6
		Me.ToolTip.SetToolTip(Me.FolderFilter, "Search Current Folder")
		'
		'SearchFilter
		'
		Me.SearchFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SearchFilter.Location = New System.Drawing.Point(26, 4)
		Me.SearchFilter.Multiline = True
		Me.SearchFilter.Name = "SearchFilter"
		Me.SearchFilter.Size = New System.Drawing.Size(122, 19)
		Me.SearchFilter.TabIndex = 5
		Me.ToolTip.SetToolTip(Me.SearchFilter, "Search Library")
		'
		'SearchModes
		'
		Me.SearchModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SearchModes.DropDownWidth = 100
		Me.SearchModes.Items.AddRange(New Object() {"File Name", "Full Path", "Folder"})
		Me.SearchModes.Location = New System.Drawing.Point(0, 3)
		Me.SearchModes.MaxDropDownItems = 4
		Me.SearchModes.Name = "SearchModes"
		Me.SearchModes.Size = New System.Drawing.Size(20, 21)
		Me.SearchModes.TabIndex = 8
		Me.ToolTip.SetToolTip(Me.SearchModes, "Search In")
		'
		'ToolStripContainer
		'
		'
		'ToolStripContainer.BottomToolStripPanel
		'
		Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusBar)
		'
		'ToolStripContainer.ContentPanel
		'
		Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitViewer)
		Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(635, 388)
		Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer.Name = "ToolStripContainer"
		Me.ToolStripContainer.Size = New System.Drawing.Size(635, 467)
		Me.ToolStripContainer.TabIndex = 7
		Me.ToolStripContainer.Text = "ToolStripContainer1"
		'
		'ToolStripContainer.TopToolStripPanel
		'
		Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.VidMenu)
		Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolBar)
		'
		'SplitViewer
		'
		Me.SplitViewer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitViewer.Location = New System.Drawing.Point(0, 0)
		Me.SplitViewer.Name = "SplitViewer"
		Me.SplitViewer.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitViewer.Panel1
		'
		Me.SplitViewer.Panel1.Controls.Add(Me.lblDuration)
		Me.SplitViewer.Panel1.Controls.Add(Me.lblLyrics)
		Me.SplitViewer.Panel1.Controls.Add(Me.Player)
		Me.SplitViewer.Panel1.Padding = New System.Windows.Forms.Padding(2)
		'
		'SplitViewer.Panel2
		'
		Me.SplitViewer.Panel2.Controls.Add(Me.SplitFol)
		Me.SplitViewer.Size = New System.Drawing.Size(635, 388)
		Me.SplitViewer.SplitterDistance = 125
		Me.SplitViewer.TabIndex = 3
		Me.SplitViewer.TabStop = False
		'
		'lblDuration
		'
		Me.lblDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblDuration.AutoSize = True
		Me.lblDuration.BackColor = System.Drawing.Color.WhiteSmoke
		Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDuration.Location = New System.Drawing.Point(606, 98)
		Me.lblDuration.Name = "lblDuration"
		Me.lblDuration.Size = New System.Drawing.Size(24, 15)
		Me.lblDuration.TabIndex = 5
		Me.lblDuration.Text = "0:0"
		Me.lblDuration.Visible = False
		'
		'lblLyrics
		'
		Me.lblLyrics.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLyrics.AutoSize = True
		Me.lblLyrics.BackColor = System.Drawing.Color.Black
		Me.lblLyrics.ContextMenuStrip = Me.LyrMenu
		Me.lblLyrics.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLyrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lblLyrics.Location = New System.Drawing.Point(605, 11)
		Me.lblLyrics.Name = "lblLyrics"
		Me.lblLyrics.Size = New System.Drawing.Size(23, 18)
		Me.lblLyrics.TabIndex = 5
		Me.lblLyrics.Text = "..."
		Me.lblLyrics.Visible = False
		'
		'LyrMenu
		'
		Me.LyrMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LyrIncreaseSizeMnu, Me.LyrDecreaseSizeMnu, Me.LyrColorMnu, Me.LyrEditorMnu})
		Me.LyrMenu.Name = "LyrMenu"
		Me.LyrMenu.Size = New System.Drawing.Size(183, 114)
		'
		'LyrIncreaseSizeMnu
		'
		Me.LyrIncreaseSizeMnu.Name = "LyrIncreaseSizeMnu"
		Me.LyrIncreaseSizeMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
		Me.LyrIncreaseSizeMnu.Size = New System.Drawing.Size(182, 22)
		Me.LyrIncreaseSizeMnu.Text = "Increase Size"
		Me.LyrIncreaseSizeMnu.ToolTipText = "Increase the Font Size of the Lyrics Display"
		'
		'LyrDecreaseSizeMnu
		'
		Me.LyrDecreaseSizeMnu.Name = "LyrDecreaseSizeMnu"
		Me.LyrDecreaseSizeMnu.ShortcutKeyDisplayString = ""
		Me.LyrDecreaseSizeMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
		Me.LyrDecreaseSizeMnu.Size = New System.Drawing.Size(182, 22)
		Me.LyrDecreaseSizeMnu.Text = "Decrease Size"
		Me.LyrDecreaseSizeMnu.ToolTipText = "Decrease the Font Size of the Lyrics Display"
		'
		'LyrColorMnu
		'
		Me.LyrColorMnu.Name = "LyrColorMnu"
		Me.LyrColorMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
		Me.LyrColorMnu.Size = New System.Drawing.Size(182, 22)
		Me.LyrColorMnu.Text = "Color"
		Me.LyrColorMnu.ToolTipText = "Set the color of the Lyrics Display"
		'
		'LyrEditorMnu
		'
		Me.LyrEditorMnu.CheckOnClick = True
		Me.LyrEditorMnu.Name = "LyrEditorMnu"
		Me.LyrEditorMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
		Me.LyrEditorMnu.Size = New System.Drawing.Size(182, 22)
		Me.LyrEditorMnu.Text = "Editor"
		Me.LyrEditorMnu.ToolTipText = "Brings up the Lyrics Editor dialog"
		'
		'Player
		'
		Me.Player.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Player.Enabled = True
		Me.Player.Location = New System.Drawing.Point(2, 2)
		Me.Player.Name = "Player"
		Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Player.Size = New System.Drawing.Size(631, 121)
		Me.Player.TabIndex = 4
		Me.Player.TabStop = False
		'
		'SplitFol
		'
		Me.SplitFol.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitFol.Location = New System.Drawing.Point(0, 0)
		Me.SplitFol.Name = "SplitFol"
		'
		'SplitFol.Panel1
		'
		Me.SplitFol.Panel1.Controls.Add(Me.fols)
		Me.SplitFol.Panel1MinSize = 100
		'
		'SplitFol.Panel2
		'
		Me.SplitFol.Panel2.Controls.Add(Me.SplitPls)
		Me.SplitFol.Size = New System.Drawing.Size(635, 259)
		Me.SplitFol.SplitterDistance = 201
		Me.SplitFol.TabIndex = 0
		Me.SplitFol.TabStop = False
		Me.SplitFol.Text = "SplitContainer1"
		'
		'fols
		'
		Me.fols.Dock = System.Windows.Forms.DockStyle.Fill
		Me.fols.HideSelection = False
		Me.fols.ImageIndex = 0
		Me.fols.ImageList = Me.FolIcons
		Me.fols.Location = New System.Drawing.Point(0, 0)
		Me.fols.Name = "fols"
		Me.fols.SelectedImageIndex = 1
		Me.fols.ShowLines = False
		Me.fols.Size = New System.Drawing.Size(201, 259)
		Me.fols.TabIndex = 0
		'
		'SplitPls
		'
		Me.SplitPls.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitPls.Location = New System.Drawing.Point(0, 0)
		Me.SplitPls.Name = "SplitPls"
		'
		'SplitPls.Panel1
		'
		Me.SplitPls.Panel1.Controls.Add(Me.SearchModes)
		Me.SplitPls.Panel1.Controls.Add(Me.FolderFilter)
		Me.SplitPls.Panel1.Controls.Add(Me.SearchFilter)
		Me.SplitPls.Panel1.Controls.Add(Me.fils)
		'
		'SplitPls.Panel2
		'
		Me.SplitPls.Panel2.Controls.Add(Me.playlist)
		Me.SplitPls.Size = New System.Drawing.Size(430, 259)
		Me.SplitPls.SplitterDistance = 210
		Me.SplitPls.TabIndex = 5
		'
		'fils
		'
		Me.fils.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.fils.CheckBoxes = True
		Me.fils.FullRowSelect = True
		Me.fils.HideSelection = False
		Me.fils.LargeImageList = Me.LargeFileIcons
		Me.fils.Location = New System.Drawing.Point(2, 27)
		Me.fils.Name = "fils"
		Me.fils.Size = New System.Drawing.Size(206, 230)
		Me.fils.SmallImageList = Me.SmallFileIcons
		Me.fils.TabIndex = 7
		Me.fils.UseCompatibleStateImageBehavior = False
		Me.fils.View = System.Windows.Forms.View.Details
		'
		'LargeFileIcons
		'
		Me.LargeFileIcons.ImageStream = CType(resources.GetObject("LargeFileIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.LargeFileIcons.TransparentColor = System.Drawing.Color.Transparent
		Me.LargeFileIcons.Images.SetKeyName(0, "file")
		Me.LargeFileIcons.Images.SetKeyName(1, "nofile")
		'
		'SmallFileIcons
		'
		Me.SmallFileIcons.ImageStream = CType(resources.GetObject("SmallFileIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.SmallFileIcons.TransparentColor = System.Drawing.Color.Transparent
		Me.SmallFileIcons.Images.SetKeyName(0, "file")
		Me.SmallFileIcons.Images.SetKeyName(1, "nofile")
		'
		'playlist
		'
		Me.playlist.Dock = System.Windows.Forms.DockStyle.Fill
		Me.playlist.FullRowSelect = True
		Me.playlist.HideSelection = False
		Me.playlist.LargeImageList = Me.LargeFileIcons
		Me.playlist.Location = New System.Drawing.Point(0, 0)
		Me.playlist.Name = "playlist"
		Me.playlist.Size = New System.Drawing.Size(216, 259)
		Me.playlist.SmallImageList = Me.SmallFileIcons
		Me.playlist.TabIndex = 4
		Me.playlist.UseCompatibleStateImageBehavior = False
		Me.playlist.View = System.Windows.Forms.View.Details
		'
		'PlayNext
		'
		Me.PlayNext.Enabled = True
		Me.PlayNext.Interval = 1000
		'
		'BarIcons
		'
		Me.BarIcons.ImageStream = CType(resources.GetObject("BarIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.BarIcons.TransparentColor = System.Drawing.Color.Transparent
		Me.BarIcons.Images.SetKeyName(0, "v")
		Me.BarIcons.Images.SetKeyName(1, "h")
		'
		'TreeMenu
		'
		Me.TreeMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeItemOpen, Me.TreeItemRefresh})
		Me.TreeMenu.Name = "TreeMenu"
		Me.TreeMenu.ShowImageMargin = False
		Me.TreeMenu.Size = New System.Drawing.Size(148, 48)
		'
		'TreeItemOpen
		'
		Me.TreeItemOpen.Name = "TreeItemOpen"
		Me.TreeItemOpen.Size = New System.Drawing.Size(147, 22)
		Me.TreeItemOpen.Text = "&Open"
		'
		'TreeItemRefresh
		'
		Me.TreeItemRefresh.Name = "TreeItemRefresh"
		Me.TreeItemRefresh.Size = New System.Drawing.Size(147, 22)
		Me.TreeItemRefresh.Text = "&Refresh Subfolders"
		'
		'FileMenu
		'
		Me.FileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileItemOpenContainingFolder, Me.FileItemGoToFolder, Me.FileItemCheckAll, Me.FileItemUncheckAll, Me.FileItemWindows})
		Me.FileMenu.Name = "FileMenu"
		Me.FileMenu.Size = New System.Drawing.Size(202, 114)
		'
		'FileItemOpenContainingFolder
		'
		Me.FileItemOpenContainingFolder.Name = "FileItemOpenContainingFolder"
		Me.FileItemOpenContainingFolder.Size = New System.Drawing.Size(201, 22)
		Me.FileItemOpenContainingFolder.Text = "Open &Containing Folder"
		Me.FileItemOpenContainingFolder.ToolTipText = "Opens Containing Folder in windows explorer"
		'
		'FileItemGoToFolder
		'
		Me.FileItemGoToFolder.Name = "FileItemGoToFolder"
		Me.FileItemGoToFolder.Size = New System.Drawing.Size(201, 22)
		Me.FileItemGoToFolder.Text = "&Go To Folder"
		'
		'FileItemCheckAll
		'
		Me.FileItemCheckAll.Name = "FileItemCheckAll"
		Me.FileItemCheckAll.Size = New System.Drawing.Size(201, 22)
		Me.FileItemCheckAll.Text = "&Check All"
		'
		'FileItemUncheckAll
		'
		Me.FileItemUncheckAll.Name = "FileItemUncheckAll"
		Me.FileItemUncheckAll.Size = New System.Drawing.Size(201, 22)
		Me.FileItemUncheckAll.Text = "&Uncheck All"
		'
		'FileItemWindows
		'
		Me.FileItemWindows.Name = "FileItemWindows"
		Me.FileItemWindows.Size = New System.Drawing.Size(201, 22)
		Me.FileItemWindows.Text = "&Windows Menu"
		'
		'PanLyrics
		'
		Me.PanLyrics.Interval = 50
		'
		'ToolsViewOrganizerMnu
		'
		Me.ToolsViewOrganizerMnu.Name = "ToolsViewOrganizerMnu"
		Me.ToolsViewOrganizerMnu.Size = New System.Drawing.Size(192, 22)
		Me.ToolsViewOrganizerMnu.Text = "View Organizer"
		'
		'Vid
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(635, 467)
		Me.Controls.Add(Me.ToolStripContainer)
		Me.Name = "Vid"
		Me.Text = "IViewer"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusBar.ResumeLayout(False)
		Me.StatusBar.PerformLayout()
		Me.ToolBar.ResumeLayout(False)
		Me.ToolBar.PerformLayout()
		Me.VidMenu.ResumeLayout(False)
		Me.VidMenu.PerformLayout()
		Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
		Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer.ResumeLayout(False)
		Me.ToolStripContainer.PerformLayout()
		Me.SplitViewer.Panel1.ResumeLayout(False)
		Me.SplitViewer.Panel1.PerformLayout()
		Me.SplitViewer.Panel2.ResumeLayout(False)
		Me.SplitViewer.ResumeLayout(False)
		Me.LyrMenu.ResumeLayout(False)
		CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitFol.Panel1.ResumeLayout(False)
		Me.SplitFol.Panel2.ResumeLayout(False)
		Me.SplitFol.ResumeLayout(False)
		Me.SplitPls.Panel1.ResumeLayout(False)
		Me.SplitPls.Panel1.PerformLayout()
		Me.SplitPls.Panel2.ResumeLayout(False)
		Me.SplitPls.ResumeLayout(False)
		Me.TreeMenu.ResumeLayout(False)
		Me.FileMenu.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitViewer As System.Windows.Forms.SplitContainer
	Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
	Friend WithEvents ViewHorzMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SmallFileIcons As System.Windows.Forms.ImageList
	Friend WithEvents LargeFileIcons As System.Windows.Forms.ImageList
	Friend WithEvents ToolBar As System.Windows.Forms.ToolStrip
	Friend WithEvents PlayNext As System.Windows.Forms.Timer
	Friend WithEvents ViewHorzBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents BarIcons As System.Windows.Forms.ImageList
	Friend WithEvents StatusSearch As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents MnuMedia As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaRestartMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ViewReturnMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaVolumeUpMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaVolumeDownMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaVolumeMuteMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents StatusFile As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents ToolsInvalidFileLinksMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsReloadMediaLibraryMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsSaveMediaLibraryMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents playlist As System.Windows.Forms.ListView
	Friend WithEvents SplitPls As System.Windows.Forms.SplitContainer
	Friend WithEvents FolderFilter As System.Windows.Forms.TextBox
	Friend WithEvents SearchFilter As System.Windows.Forms.TextBox
	Friend WithEvents fils As System.Windows.Forms.ListView
	Friend WithEvents ViewPlaylistVerticalMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TreeMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents TreeItemOpen As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TreeItemRefresh As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents FileItemWindows As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileItemCheckAll As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileItemUncheckAll As System.Windows.Forms.ToolStripMenuItem

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents HelpReadmeMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaStopMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileItemGoToFolder As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelFileBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents SelPlsBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents SelBothBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PlsVertBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents SearchModes As System.Windows.Forms.ComboBox
	Friend WithEvents FileItemOpenContainingFolder As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PanLyrics As System.Windows.Forms.Timer
	Friend WithEvents lblLyrics As System.Windows.Forms.Label
	Friend WithEvents PlsStickBtn As System.Windows.Forms.ToolStripButton
	Friend WithEvents lblDuration As System.Windows.Forms.Label
	Friend WithEvents LyrMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents LyrIncreaseSizeMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LyrDecreaseSizeMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LyrColorMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LyrEditorMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents MediaPanLeftMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MediaPanRightMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsLyricsDisplayMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsViewOrganizerMnu As System.Windows.Forms.ToolStripMenuItem
End Class
