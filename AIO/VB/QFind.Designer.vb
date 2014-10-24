<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QFind
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
		Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("default.asp")
		Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root", New System.Windows.Forms.TreeNode() {TreeNode1})
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QFind))
		Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Common", System.Windows.Forms.HorizontalAlignment.Left)
		Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Text", System.Windows.Forms.HorizontalAlignment.Left)
		Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ASP", System.Windows.Forms.HorizontalAlignment.Left)
		Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ASPX", System.Windows.Forms.HorizontalAlignment.Left)
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"GetTrans", "aspx,ascx,master", "TextList"}, -1)
		Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Images", "*", "FileList"}, -1)
		Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Include", "asp", "File"}, -1)
		Me.Entries = New System.Windows.Forms.TreeView
		Me.Icons = New System.Windows.Forms.ImageList(Me.components)
		Me.Tabs = New System.Windows.Forms.TabControl
		Me.TabsOptions = New System.Windows.Forms.TabPage
		Me.OptionsTabs = New System.Windows.Forms.TabControl
		Me.OptionsTabRules = New System.Windows.Forms.TabPage
		Me.Rules = New System.Windows.Forms.ListView
		Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
		Me.RuleMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RuleMenuName = New System.Windows.Forms.ToolStripTextBox
		Me.RuleMenuAppliesTo = New System.Windows.Forms.ToolStripTextBox
		Me.RuleMenuResultTypes = New System.Windows.Forms.ToolStripComboBox
		Me.RuleMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.RuleMenuMatchTypes = New System.Windows.Forms.ToolStripComboBox
		Me.RuleMenuStringMatchStart = New System.Windows.Forms.ToolStripTextBox
		Me.RuleMenuStringMatchEnd = New System.Windows.Forms.ToolStripTextBox
		Me.RuleMenuRegExMatchString = New System.Windows.Forms.ToolStripTextBox
		Me.RuleMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.RuleMenuUpdate = New System.Windows.Forms.ToolStripMenuItem
		Me.RuleMenuSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me.RuleMenuAdd = New System.Windows.Forms.ToolStripMenuItem
		Me.RuleMenuSave = New System.Windows.Forms.ToolStripMenuItem
		Me.RuleMenuRefresh = New System.Windows.Forms.ToolStripMenuItem
		Me.OptionsTabBases = New System.Windows.Forms.TabPage
		Me.Bases = New System.Windows.Forms.TextBox
		Me.FileMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.FileMenuApplyRule = New System.Windows.Forms.ToolStripMenuItem
		Me.FileMenuApplyRuleRecursively = New System.Windows.Forms.ToolStripMenuItem
		Me.FileMenuClearNodes = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.FileMenuSaveFileNames = New System.Windows.Forms.ToolStripMenuItem
		Me.FileMenuAddFiles = New System.Windows.Forms.ToolStripMenuItem
		Me.FileMenuAddFilesFrom = New System.Windows.Forms.ToolStripSeparator
		Me.stbr = New System.Windows.Forms.StatusStrip
		Me.stbrPath = New System.Windows.Forms.ToolStripStatusLabel
		Me.stbrLA = New System.Windows.Forms.ToolStripStatusLabel
		Me.ofd = New System.Windows.Forms.OpenFileDialog
		Me.Tabs.SuspendLayout()
		Me.TabsOptions.SuspendLayout()
		Me.OptionsTabs.SuspendLayout()
		Me.OptionsTabRules.SuspendLayout()
		Me.RuleMenu.SuspendLayout()
		Me.OptionsTabBases.SuspendLayout()
		Me.FileMenu.SuspendLayout()
		Me.stbr.SuspendLayout()
		Me.SuspendLayout()
		'
		'Entries
		'
		Me.Entries.AllowDrop = True
		Me.Entries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Entries.HideSelection = False
		Me.Entries.ImageIndex = 0
		Me.Entries.ImageList = Me.Icons
		Me.Entries.Location = New System.Drawing.Point(0, 0)
		Me.Entries.Name = "Entries"
		TreeNode1.ImageIndex = 0
		TreeNode1.Name = "File"
		TreeNode1.Tag = "C:\inetpub\wwwroot\default.asp"
		TreeNode1.Text = "default.asp"
		TreeNode2.ImageIndex = 0
		TreeNode2.Name = "Root"
		TreeNode2.Text = "Root"
		Me.Entries.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
		Me.Entries.SelectedImageIndex = 0
		Me.Entries.Size = New System.Drawing.Size(275, 313)
		Me.Entries.TabIndex = 0
		'
		'Icons
		'
		Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.Icons.TransparentColor = System.Drawing.Color.Transparent
		Me.Icons.Images.SetKeyName(0, "a")
		Me.Icons.Images.SetKeyName(1, "b")
		Me.Icons.Images.SetKeyName(2, "c")
		Me.Icons.Images.SetKeyName(3, "d")
		'
		'Tabs
		'
		Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Tabs.Controls.Add(Me.TabsOptions)
		Me.Tabs.Location = New System.Drawing.Point(277, 0)
		Me.Tabs.Name = "Tabs"
		Me.Tabs.SelectedIndex = 0
		Me.Tabs.Size = New System.Drawing.Size(594, 313)
		Me.Tabs.TabIndex = 2
		'
		'TabsOptions
		'
		Me.TabsOptions.Controls.Add(Me.OptionsTabs)
		Me.TabsOptions.Location = New System.Drawing.Point(4, 22)
		Me.TabsOptions.Name = "TabsOptions"
		Me.TabsOptions.Padding = New System.Windows.Forms.Padding(3)
		Me.TabsOptions.Size = New System.Drawing.Size(586, 287)
		Me.TabsOptions.TabIndex = 0
		Me.TabsOptions.Text = "Options"
		Me.TabsOptions.UseVisualStyleBackColor = True
		'
		'OptionsTabs
		'
		Me.OptionsTabs.Controls.Add(Me.OptionsTabRules)
		Me.OptionsTabs.Controls.Add(Me.OptionsTabBases)
		Me.OptionsTabs.Dock = System.Windows.Forms.DockStyle.Fill
		Me.OptionsTabs.Location = New System.Drawing.Point(3, 3)
		Me.OptionsTabs.Name = "OptionsTabs"
		Me.OptionsTabs.SelectedIndex = 0
		Me.OptionsTabs.Size = New System.Drawing.Size(580, 281)
		Me.OptionsTabs.TabIndex = 4
		'
		'OptionsTabRules
		'
		Me.OptionsTabRules.Controls.Add(Me.Rules)
		Me.OptionsTabRules.Location = New System.Drawing.Point(4, 22)
		Me.OptionsTabRules.Name = "OptionsTabRules"
		Me.OptionsTabRules.Padding = New System.Windows.Forms.Padding(3)
		Me.OptionsTabRules.Size = New System.Drawing.Size(572, 255)
		Me.OptionsTabRules.TabIndex = 0
		Me.OptionsTabRules.Text = "Rules"
		Me.OptionsTabRules.UseVisualStyleBackColor = True
		'
		'Rules
		'
		Me.Rules.CheckBoxes = True
		Me.Rules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
		Me.Rules.ContextMenuStrip = Me.RuleMenu
		Me.Rules.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Rules.FullRowSelect = True
		ListViewGroup1.Header = "Common"
		ListViewGroup1.Name = "Rules_Common"
		ListViewGroup2.Header = "Text"
		ListViewGroup2.Name = "Rules_Text"
		ListViewGroup3.Header = "ASP"
		ListViewGroup3.Name = "Rules_ASP"
		ListViewGroup4.Header = "ASPX"
		ListViewGroup4.Name = "Rules_ASPX"
		Me.Rules.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
		Me.Rules.HideSelection = False
		ListViewItem1.Group = ListViewGroup4
		ListViewItem1.StateImageIndex = 0
		ListViewItem2.Group = ListViewGroup1
		ListViewItem2.StateImageIndex = 0
		ListViewItem3.Group = ListViewGroup3
		ListViewItem3.StateImageIndex = 0
		Me.Rules.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
		Me.Rules.Location = New System.Drawing.Point(3, 3)
		Me.Rules.MultiSelect = False
		Me.Rules.Name = "Rules"
		Me.Rules.Size = New System.Drawing.Size(566, 249)
		Me.Rules.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.Rules.TabIndex = 0
		Me.Rules.UseCompatibleStateImageBehavior = False
		Me.Rules.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "RuleName"
		Me.ColumnHeader1.Width = 80
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "AppliesTo"
		Me.ColumnHeader2.Width = 93
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "ResultType"
		Me.ColumnHeader3.Width = 88
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "MatchType"
		Me.ColumnHeader4.Width = 83
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "SampleMatch"
		Me.ColumnHeader5.Width = 85
		'
		'RuleMenu
		'
		Me.RuleMenu.BackColor = System.Drawing.SystemColors.Menu
		Me.RuleMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RuleMenuName, Me.RuleMenuAppliesTo, Me.RuleMenuResultTypes, Me.RuleMenuSeparator1, Me.RuleMenuMatchTypes, Me.RuleMenuStringMatchStart, Me.RuleMenuStringMatchEnd, Me.RuleMenuRegExMatchString, Me.RuleMenuSeparator2, Me.RuleMenuUpdate, Me.RuleMenuSeparator3, Me.RuleMenuAdd, Me.RuleMenuSave, Me.RuleMenuRefresh})
		Me.RuleMenu.Name = "ItemMenu"
		Me.RuleMenu.Size = New System.Drawing.Size(182, 275)
		'
		'RuleMenuName
		'
		Me.RuleMenuName.Name = "RuleMenuName"
		Me.RuleMenuName.Size = New System.Drawing.Size(100, 21)
		Me.RuleMenuName.Text = "Rule Name"
		Me.RuleMenuName.ToolTipText = "Name of the Rule"
		'
		'RuleMenuAppliesTo
		'
		Me.RuleMenuAppliesTo.Name = "RuleMenuAppliesTo"
		Me.RuleMenuAppliesTo.Size = New System.Drawing.Size(100, 21)
		Me.RuleMenuAppliesTo.ToolTipText = "Extensions for which rule applies"
		'
		'RuleMenuResultTypes
		'
		Me.RuleMenuResultTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.RuleMenuResultTypes.Items.AddRange(New Object() {"FileList", "File", "TextList"})
		Me.RuleMenuResultTypes.Name = "RuleMenuResultTypes"
		Me.RuleMenuResultTypes.Size = New System.Drawing.Size(121, 21)
		'
		'RuleMenuSeparator1
		'
		Me.RuleMenuSeparator1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.RuleMenuSeparator1.Name = "RuleMenuSeparator1"
		Me.RuleMenuSeparator1.Size = New System.Drawing.Size(178, 6)
		'
		'RuleMenuMatchTypes
		'
		Me.RuleMenuMatchTypes.Items.AddRange(New Object() {"String", "RegEx"})
		Me.RuleMenuMatchTypes.Name = "RuleMenuMatchTypes"
		Me.RuleMenuMatchTypes.Size = New System.Drawing.Size(121, 21)
		'
		'RuleMenuStringMatchStart
		'
		Me.RuleMenuStringMatchStart.Name = "RuleMenuStringMatchStart"
		Me.RuleMenuStringMatchStart.Size = New System.Drawing.Size(100, 21)
		'
		'RuleMenuStringMatchEnd
		'
		Me.RuleMenuStringMatchEnd.Name = "RuleMenuStringMatchEnd"
		Me.RuleMenuStringMatchEnd.Size = New System.Drawing.Size(100, 21)
		'
		'RuleMenuRegExMatchString
		'
		Me.RuleMenuRegExMatchString.Name = "RuleMenuRegExMatchString"
		Me.RuleMenuRegExMatchString.Size = New System.Drawing.Size(100, 21)
		Me.RuleMenuRegExMatchString.Visible = False
		'
		'RuleMenuSeparator2
		'
		Me.RuleMenuSeparator2.Name = "RuleMenuSeparator2"
		Me.RuleMenuSeparator2.Size = New System.Drawing.Size(178, 6)
		'
		'RuleMenuUpdate
		'
		Me.RuleMenuUpdate.Name = "RuleMenuUpdate"
		Me.RuleMenuUpdate.Size = New System.Drawing.Size(181, 22)
		Me.RuleMenuUpdate.Text = "Update"
		Me.RuleMenuUpdate.ToolTipText = "Click to Save Changes"
		'
		'RuleMenuSeparator3
		'
		Me.RuleMenuSeparator3.Name = "RuleMenuSeparator3"
		Me.RuleMenuSeparator3.Size = New System.Drawing.Size(178, 6)
		'
		'RuleMenuAdd
		'
		Me.RuleMenuAdd.Name = "RuleMenuAdd"
		Me.RuleMenuAdd.Size = New System.Drawing.Size(181, 22)
		Me.RuleMenuAdd.Text = "Add"
		'
		'RuleMenuSave
		'
		Me.RuleMenuSave.Name = "RuleMenuSave"
		Me.RuleMenuSave.Size = New System.Drawing.Size(181, 22)
		Me.RuleMenuSave.Text = "Save"
		'
		'RuleMenuRefresh
		'
		Me.RuleMenuRefresh.Name = "RuleMenuRefresh"
		Me.RuleMenuRefresh.Size = New System.Drawing.Size(181, 22)
		Me.RuleMenuRefresh.Text = "Refresh"
		'
		'OptionsTabBases
		'
		Me.OptionsTabBases.Controls.Add(Me.Bases)
		Me.OptionsTabBases.Location = New System.Drawing.Point(4, 22)
		Me.OptionsTabBases.Name = "OptionsTabBases"
		Me.OptionsTabBases.Padding = New System.Windows.Forms.Padding(3)
		Me.OptionsTabBases.Size = New System.Drawing.Size(572, 255)
		Me.OptionsTabBases.TabIndex = 1
		Me.OptionsTabBases.Text = "Bases"
		Me.OptionsTabBases.UseVisualStyleBackColor = True
		'
		'Bases
		'
		Me.Bases.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Bases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Bases.Location = New System.Drawing.Point(3, 3)
		Me.Bases.Multiline = True
		Me.Bases.Name = "Bases"
		Me.Bases.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.Bases.Size = New System.Drawing.Size(566, 249)
		Me.Bases.TabIndex = 0
		Me.Bases.WordWrap = False
		'
		'FileMenu
		'
		Me.FileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuApplyRule, Me.FileMenuApplyRuleRecursively, Me.FileMenuClearNodes, Me.ToolStripSeparator1, Me.FileMenuSaveFileNames, Me.FileMenuAddFiles, Me.FileMenuAddFilesFrom})
		Me.FileMenu.Name = "ItemMenu"
		Me.FileMenu.Size = New System.Drawing.Size(208, 126)
		'
		'FileMenuApplyRule
		'
		Me.FileMenuApplyRule.Name = "FileMenuApplyRule"
		Me.FileMenuApplyRule.Size = New System.Drawing.Size(207, 22)
		Me.FileMenuApplyRule.Text = "Apply Rule(s) "
		'
		'FileMenuApplyRuleRecursively
		'
		Me.FileMenuApplyRuleRecursively.Name = "FileMenuApplyRuleRecursively"
		Me.FileMenuApplyRuleRecursively.Size = New System.Drawing.Size(207, 22)
		Me.FileMenuApplyRuleRecursively.Text = "Apply Rule(s) Recursively"
		'
		'FileMenuClearNodes
		'
		Me.FileMenuClearNodes.Name = "FileMenuClearNodes"
		Me.FileMenuClearNodes.Size = New System.Drawing.Size(207, 22)
		Me.FileMenuClearNodes.Text = "Clear Nodes"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
		'
		'FileMenuSaveFileNames
		'
		Me.FileMenuSaveFileNames.Name = "FileMenuSaveFileNames"
		Me.FileMenuSaveFileNames.Size = New System.Drawing.Size(207, 22)
		Me.FileMenuSaveFileNames.Text = "Save File Names..."
		'
		'FileMenuAddFiles
		'
		Me.FileMenuAddFiles.Name = "FileMenuAddFiles"
		Me.FileMenuAddFiles.Size = New System.Drawing.Size(207, 22)
		Me.FileMenuAddFiles.Text = "Add File(s)..."
		'
		'FileMenuAddFilesFrom
		'
		Me.FileMenuAddFilesFrom.Name = "FileMenuAddFilesFrom"
		Me.FileMenuAddFilesFrom.Size = New System.Drawing.Size(204, 6)
		'
		'stbr
		'
		Me.stbr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stbrPath, Me.stbrLA})
		Me.stbr.Location = New System.Drawing.Point(0, 316)
		Me.stbr.Name = "stbr"
		Me.stbr.Size = New System.Drawing.Size(873, 22)
		Me.stbr.TabIndex = 3
		Me.stbr.Text = "StatusStrip1"
		'
		'stbrPath
		'
		Me.stbrPath.Name = "stbrPath"
		Me.stbrPath.Size = New System.Drawing.Size(429, 17)
		Me.stbrPath.Spring = True
		Me.stbrPath.Text = "file"
		Me.stbrPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'stbrLA
		'
		Me.stbrLA.Name = "stbrLA"
		Me.stbrLA.Size = New System.Drawing.Size(429, 17)
		Me.stbrLA.Spring = True
		Me.stbrLA.Text = "[last action]"
		'
		'ofd
		'
		Me.ofd.FileName = "OpenFileDialog1"
		'
		'QFind
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(873, 338)
		Me.Controls.Add(Me.stbr)
		Me.Controls.Add(Me.Tabs)
		Me.Controls.Add(Me.Entries)
		Me.Name = "QFind"
		Me.Text = "Cselian MultiFinder"
		Me.Tabs.ResumeLayout(False)
		Me.TabsOptions.ResumeLayout(False)
		Me.OptionsTabs.ResumeLayout(False)
		Me.OptionsTabRules.ResumeLayout(False)
		Me.RuleMenu.ResumeLayout(False)
		Me.RuleMenu.PerformLayout()
		Me.OptionsTabBases.ResumeLayout(False)
		Me.OptionsTabBases.PerformLayout()
		Me.FileMenu.ResumeLayout(False)
		Me.stbr.ResumeLayout(False)
		Me.stbr.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Tabs As System.Windows.Forms.TabControl
	Friend WithEvents Icons As System.Windows.Forms.ImageList
	Friend WithEvents FileMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents FileMenuApplyRule As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileMenuApplyRuleRecursively As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Entries As System.Windows.Forms.TreeView
	Friend WithEvents TabsOptions As System.Windows.Forms.TabPage
	Friend WithEvents OptionsTabs As System.Windows.Forms.TabControl
	Friend WithEvents OptionsTabRules As System.Windows.Forms.TabPage
	Friend WithEvents Rules As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Friend WithEvents OptionsTabBases As System.Windows.Forms.TabPage
	Friend WithEvents Bases As System.Windows.Forms.TextBox
	Friend WithEvents RuleMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents RuleMenuResultTypes As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents RuleMenuAppliesTo As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents RuleMenuUpdate As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RuleMenuName As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents RuleMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
	Friend WithEvents RuleMenuAdd As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RuleMenuMatchTypes As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents RuleMenuStringMatchStart As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents RuleMenuStringMatchEnd As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents RuleMenuRegExMatchString As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents RuleMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents RuleMenuSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents stbr As System.Windows.Forms.StatusStrip
	Friend WithEvents stbrLA As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents RuleMenuRefresh As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RuleMenuSave As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileMenuClearNodes As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents FileMenuAddFiles As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents FileMenuSaveFileNames As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
	Friend WithEvents FileMenuAddFilesFrom As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents stbrPath As System.Windows.Forms.ToolStripStatusLabel
End Class
