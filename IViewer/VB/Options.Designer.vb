<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
		Me.MenuItems = New System.Windows.Forms.ListView()
		Me.MenuName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.MenuSection = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.MenuShortcut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SCKey = New System.Windows.Forms.TextBox()
		Me.TabOptions = New System.Windows.Forms.TabControl()
		Me.TabMenuShortcuts = New System.Windows.Forms.TabPage()
		Me.TabFolders = New System.Windows.Forms.TabPage()
		Me.Favorites = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Save = New System.Windows.Forms.Button()
		Me.lblHint = New System.Windows.Forms.Label()
		Me.TabOptions.SuspendLayout()
		Me.TabMenuShortcuts.SuspendLayout()
		Me.TabFolders.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuItems
		'
		Me.MenuItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MenuName, Me.MenuSection, Me.MenuShortcut})
		Me.MenuItems.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MenuItems.FullRowSelect = True
		Me.MenuItems.Location = New System.Drawing.Point(10, 10)
		Me.MenuItems.Name = "MenuItems"
		Me.MenuItems.Size = New System.Drawing.Size(428, 350)
		Me.MenuItems.TabIndex = 0
		Me.MenuItems.UseCompatibleStateImageBehavior = False
		Me.MenuItems.View = System.Windows.Forms.View.Details
		'
		'MenuName
		'
		Me.MenuName.Text = "Menu"
		Me.MenuName.Width = 158
		'
		'MenuSection
		'
		Me.MenuSection.Text = "Section"
		Me.MenuSection.Width = 103
		'
		'MenuShortcut
		'
		Me.MenuShortcut.Text = "Shortcut"
		Me.MenuShortcut.Width = 144
		'
		'SCKey
		'
		Me.SCKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.SCKey.Location = New System.Drawing.Point(273, 37)
		Me.SCKey.Name = "SCKey"
		Me.SCKey.Size = New System.Drawing.Size(100, 20)
		Me.SCKey.TabIndex = 1
		Me.SCKey.Visible = False
		'
		'TabOptions
		'
		Me.TabOptions.Controls.Add(Me.TabMenuShortcuts)
		Me.TabOptions.Controls.Add(Me.TabFolders)
		Me.TabOptions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabOptions.Location = New System.Drawing.Point(10, 10)
		Me.TabOptions.Name = "TabOptions"
		Me.TabOptions.SelectedIndex = 0
		Me.TabOptions.Size = New System.Drawing.Size(456, 396)
		Me.TabOptions.TabIndex = 2
		'
		'TabMenuShortcuts
		'
		Me.TabMenuShortcuts.Controls.Add(Me.SCKey)
		Me.TabMenuShortcuts.Controls.Add(Me.MenuItems)
		Me.TabMenuShortcuts.Location = New System.Drawing.Point(4, 22)
		Me.TabMenuShortcuts.Name = "TabMenuShortcuts"
		Me.TabMenuShortcuts.Padding = New System.Windows.Forms.Padding(10)
		Me.TabMenuShortcuts.Size = New System.Drawing.Size(448, 370)
		Me.TabMenuShortcuts.TabIndex = 0
		Me.TabMenuShortcuts.Text = "Menu Shortcuts"
		Me.TabMenuShortcuts.UseVisualStyleBackColor = True
		'
		'TabFolders
		'
		Me.TabFolders.Controls.Add(Me.lblHint)
		Me.TabFolders.Controls.Add(Me.Favorites)
		Me.TabFolders.Location = New System.Drawing.Point(4, 22)
		Me.TabFolders.Name = "TabFolders"
		Me.TabFolders.Padding = New System.Windows.Forms.Padding(10)
		Me.TabFolders.Size = New System.Drawing.Size(448, 370)
		Me.TabFolders.TabIndex = 1
		Me.TabFolders.Text = "Folders"
		Me.TabFolders.UseVisualStyleBackColor = True
		'
		'Favorites
		'
		Me.Favorites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Favorites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.Favorites.FullRowSelect = True
		Me.Favorites.HideSelection = False
		Me.Favorites.LabelEdit = True
		Me.Favorites.Location = New System.Drawing.Point(10, 33)
		Me.Favorites.Name = "Favorites"
		Me.Favorites.Size = New System.Drawing.Size(428, 327)
		Me.Favorites.TabIndex = 1
		Me.Favorites.UseCompatibleStateImageBehavior = False
		Me.Favorites.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Folder"
		Me.ColumnHeader1.Width = 296
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Exists"
		Me.ColumnHeader2.Width = 103
		'
		'Save
		'
		Me.Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Save.Location = New System.Drawing.Point(372, 10)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(91, 20)
		Me.Save.TabIndex = 3
		Me.Save.Text = "&Save Options"
		Me.Save.UseVisualStyleBackColor = True
		'
		'lblHint
		'
		Me.lblHint.AutoSize = True
		Me.lblHint.Location = New System.Drawing.Point(13, 10)
		Me.lblHint.Name = "lblHint"
		Me.lblHint.Size = New System.Drawing.Size(323, 13)
		Me.lblHint.TabIndex = 2
		Me.lblHint.Text = "Click Insert to Add, F2 to edit and Delete to remove favorite folders."
		'
		'Options
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 416)
		Me.Controls.Add(Me.Save)
		Me.Controls.Add(Me.TabOptions)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Options"
		Me.Padding = New System.Windows.Forms.Padding(10)
		Me.Text = "Options"
		Me.TabOptions.ResumeLayout(False)
		Me.TabMenuShortcuts.ResumeLayout(False)
		Me.TabMenuShortcuts.PerformLayout()
		Me.TabFolders.ResumeLayout(False)
		Me.TabFolders.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents MenuItems As System.Windows.Forms.ListView
	Friend WithEvents MenuName As System.Windows.Forms.ColumnHeader
	Friend WithEvents MenuSection As System.Windows.Forms.ColumnHeader
	Friend WithEvents MenuShortcut As System.Windows.Forms.ColumnHeader
	Friend WithEvents SCKey As System.Windows.Forms.TextBox
	Friend WithEvents TabOptions As System.Windows.Forms.TabControl
	Friend WithEvents TabMenuShortcuts As System.Windows.Forms.TabPage
	Friend WithEvents TabFolders As System.Windows.Forms.TabPage
	Friend WithEvents Favorites As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents Save As System.Windows.Forms.Button
	Friend WithEvents lblHint As System.Windows.Forms.Label
End Class
