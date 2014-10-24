<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIOMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub


	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIOMain))
		Me.MenuStrip = New System.Windows.Forms.MenuStrip
		Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
		Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
		Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.Toolbar = New System.Windows.Forms.ToolStrip
		Me.StatusStrip = New System.Windows.Forms.StatusStrip
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip.SuspendLayout()
		Me.StatusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMenu, Me.WindowsMenu, Me.HelpMenu})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
		Me.MenuStrip.TabIndex = 5
		Me.MenuStrip.Text = "MenuStrip"
		'
		'ViewMenu
		'
		Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
		Me.ViewMenu.Name = "ViewMenu"
		Me.ViewMenu.Size = New System.Drawing.Size(41, 20)
		Me.ViewMenu.Text = "&View"
		'
		'ToolBarToolStripMenuItem
		'
		Me.ToolBarToolStripMenuItem.Checked = True
		Me.ToolBarToolStripMenuItem.CheckOnClick = True
		Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
		Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
		'
		'StatusBarToolStripMenuItem
		'
		Me.StatusBarToolStripMenuItem.Checked = True
		Me.StatusBarToolStripMenuItem.CheckOnClick = True
		Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
		Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
		'
		'WindowsMenu
		'
		Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
		Me.WindowsMenu.Name = "WindowsMenu"
		Me.WindowsMenu.Size = New System.Drawing.Size(62, 20)
		Me.WindowsMenu.Text = "&Windows"
		'
		'NewWindowToolStripMenuItem
		'
		Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
		Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.NewWindowToolStripMenuItem.Text = "&New Window"
		'
		'CascadeToolStripMenuItem
		'
		Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
		Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.CascadeToolStripMenuItem.Text = "&Cascade"
		'
		'TileVerticalToolStripMenuItem
		'
		Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
		Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
		'
		'TileHorizontalToolStripMenuItem
		'
		Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
		Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
		'
		'CloseAllToolStripMenuItem
		'
		Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
		Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.CloseAllToolStripMenuItem.Text = "C&lose All"
		'
		'ArrangeIconsToolStripMenuItem
		'
		Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
		Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
		'
		'HelpMenu
		'
		Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
		Me.HelpMenu.Name = "HelpMenu"
		Me.HelpMenu.Size = New System.Drawing.Size(40, 20)
		Me.HelpMenu.Text = "&Help"
		'
		'ContentsToolStripMenuItem
		'
		Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
		Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
		Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.ContentsToolStripMenuItem.Text = "&Contents"
		'
		'IndexToolStripMenuItem
		'
		Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
		Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
		Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.IndexToolStripMenuItem.Text = "&Index"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.SearchToolStripMenuItem.Text = "&Search"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(170, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.AboutToolStripMenuItem.Text = "&About ..."
		'
		'Toolbar
		'
		Me.Toolbar.Location = New System.Drawing.Point(0, 24)
		Me.Toolbar.Name = "Toolbar"
		Me.Toolbar.Size = New System.Drawing.Size(632, 25)
		Me.Toolbar.TabIndex = 6
		Me.Toolbar.Text = "ToolStrip"
		'
		'StatusStrip
		'
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
		Me.ToolStripStatusLabel.Text = "Status"
		'
		'AIOMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(632, 453)
		Me.Controls.Add(Me.Toolbar)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.StatusStrip)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip
		Me.Name = "AIOMain"
		Me.Text = "Cselian Tools"
		Me.MenuStrip.ResumeLayout(False)
		Me.MenuStrip.PerformLayout()
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
	Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
	Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
	Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
