<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SequenceDiagrams
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Me.SplitterUpDown = New System.Windows.Forms.SplitContainer
		Me.SplitterTree = New System.Windows.Forms.SplitContainer
		Me.SDExplorer = New System.Windows.Forms.TreeView
		Me.SDMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.MnuAddFolder = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuAddDiagram = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuSave = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuGenerate = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuDelete = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuToggleTemplates = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuShowDiagrams = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuReloadAll = New System.Windows.Forms.ToolStripMenuItem
		Me.SplitterTemplate = New System.Windows.Forms.SplitContainer
		Me.DiagramInput = New System.Windows.Forms.TextBox
		Me.SDTemplates = New System.Windows.Forms.WebBrowser
		Me.Diagram = New System.Windows.Forms.PictureBox
		Me.SplitterUpDown.Panel1.SuspendLayout()
		Me.SplitterUpDown.Panel2.SuspendLayout()
		Me.SplitterUpDown.SuspendLayout()
		Me.SplitterTree.Panel1.SuspendLayout()
		Me.SplitterTree.Panel2.SuspendLayout()
		Me.SplitterTree.SuspendLayout()
		Me.SDMenu.SuspendLayout()
		Me.SplitterTemplate.Panel1.SuspendLayout()
		Me.SplitterTemplate.Panel2.SuspendLayout()
		Me.SplitterTemplate.SuspendLayout()
		CType(Me.Diagram, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitterUpDown
		'
		Me.SplitterUpDown.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitterUpDown.Location = New System.Drawing.Point(0, 0)
		Me.SplitterUpDown.Name = "SplitterUpDown"
		Me.SplitterUpDown.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitterUpDown.Panel1
		'
		Me.SplitterUpDown.Panel1.Controls.Add(Me.SplitterTree)
		'
		'SplitterUpDown.Panel2
		'
		Me.SplitterUpDown.Panel2.AutoScroll = True
		Me.SplitterUpDown.Panel2.Controls.Add(Me.Diagram)
		Me.SplitterUpDown.Size = New System.Drawing.Size(494, 273)
		Me.SplitterUpDown.SplitterDistance = 133
		Me.SplitterUpDown.TabIndex = 0
		'
		'SplitterTree
		'
		Me.SplitterTree.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitterTree.Location = New System.Drawing.Point(0, 0)
		Me.SplitterTree.Name = "SplitterTree"
		'
		'SplitterTree.Panel1
		'
		Me.SplitterTree.Panel1.Controls.Add(Me.SDExplorer)
		'
		'SplitterTree.Panel2
		'
		Me.SplitterTree.Panel2.Controls.Add(Me.SplitterTemplate)
		Me.SplitterTree.Size = New System.Drawing.Size(494, 133)
		Me.SplitterTree.SplitterDistance = 164
		Me.SplitterTree.TabIndex = 0
		'
		'SDExplorer
		'
		Me.SDExplorer.ContextMenuStrip = Me.SDMenu
		Me.SDExplorer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SDExplorer.HideSelection = False
		Me.SDExplorer.Location = New System.Drawing.Point(0, 0)
		Me.SDExplorer.Name = "SDExplorer"
		Me.SDExplorer.Size = New System.Drawing.Size(164, 133)
		Me.SDExplorer.TabIndex = 0
		'
		'SDMenu
		'
		Me.SDMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAddFolder, Me.MnuAddDiagram, Me.MnuSave, Me.MnuGenerate, Me.MnuDelete, Me.MnuToggleTemplates, Me.MnuShowDiagrams, Me.MnuReloadAll})
		Me.SDMenu.Name = "SDMenu"
		Me.SDMenu.Size = New System.Drawing.Size(202, 180)
		'
		'MnuAddFolder
		'
		Me.MnuAddFolder.Name = "MnuAddFolder"
		Me.MnuAddFolder.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.MnuAddFolder.Size = New System.Drawing.Size(201, 22)
		Me.MnuAddFolder.Text = "Add &Folder"
		'
		'MnuAddDiagram
		'
		Me.MnuAddDiagram.Name = "MnuAddDiagram"
		Me.MnuAddDiagram.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
		Me.MnuAddDiagram.Size = New System.Drawing.Size(201, 22)
		Me.MnuAddDiagram.Text = "&Add Diagram"
		'
		'MnuSave
		'
		Me.MnuSave.Name = "MnuSave"
		Me.MnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.MnuSave.Size = New System.Drawing.Size(201, 22)
		Me.MnuSave.Text = "&Save"
		'
		'MnuGenerate
		'
		Me.MnuGenerate.Name = "MnuGenerate"
		Me.MnuGenerate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
		Me.MnuGenerate.Size = New System.Drawing.Size(201, 22)
		Me.MnuGenerate.Text = "&Generate"
		'
		'MnuDelete
		'
		Me.MnuDelete.Name = "MnuDelete"
		Me.MnuDelete.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
					Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
		Me.MnuDelete.Size = New System.Drawing.Size(201, 22)
		Me.MnuDelete.Text = "&Delete"
		'
		'MnuToggleTemplates
		'
		Me.MnuToggleTemplates.CheckOnClick = True
		Me.MnuToggleTemplates.Name = "MnuToggleTemplates"
		Me.MnuToggleTemplates.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
		Me.MnuToggleTemplates.Size = New System.Drawing.Size(201, 22)
		Me.MnuToggleTemplates.Text = "Show &Templates"
		'
		'MnuShowDiagrams
		'
		Me.MnuShowDiagrams.CheckOnClick = True
		Me.MnuShowDiagrams.Name = "MnuShowDiagrams"
		Me.MnuShowDiagrams.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
		Me.MnuShowDiagrams.Size = New System.Drawing.Size(201, 22)
		Me.MnuShowDiagrams.Text = "Show &Diagrams"
		'
		'MnuReloadAll
		'
		Me.MnuReloadAll.Name = "MnuReloadAll"
		Me.MnuReloadAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.MnuReloadAll.Size = New System.Drawing.Size(201, 22)
		Me.MnuReloadAll.Text = "&Reload All"
		'
		'SplitterTemplate
		'
		Me.SplitterTemplate.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitterTemplate.Location = New System.Drawing.Point(0, 0)
		Me.SplitterTemplate.Name = "SplitterTemplate"
		'
		'SplitterTemplate.Panel1
		'
		Me.SplitterTemplate.Panel1.Controls.Add(Me.DiagramInput)
		'
		'SplitterTemplate.Panel2
		'
		Me.SplitterTemplate.Panel2.Controls.Add(Me.SDTemplates)
		Me.SplitterTemplate.Size = New System.Drawing.Size(326, 133)
		Me.SplitterTemplate.SplitterDistance = 184
		Me.SplitterTemplate.TabIndex = 1
		'
		'DiagramInput
		'
		Me.DiagramInput.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DiagramInput.Location = New System.Drawing.Point(0, 0)
		Me.DiagramInput.Multiline = True
		Me.DiagramInput.Name = "DiagramInput"
		Me.DiagramInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.DiagramInput.Size = New System.Drawing.Size(184, 133)
		Me.DiagramInput.TabIndex = 1
		Me.DiagramInput.Text = "QS0-QjogdGV4dAphY3RpdmF0ZSBCCkItLT5BABAHZGUADgs"
		Me.DiagramInput.WordWrap = False
		'
		'SDTemplates
		'
		Me.SDTemplates.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SDTemplates.Location = New System.Drawing.Point(0, 0)
		Me.SDTemplates.MinimumSize = New System.Drawing.Size(20, 20)
		Me.SDTemplates.Name = "SDTemplates"
		Me.SDTemplates.Size = New System.Drawing.Size(138, 133)
		Me.SDTemplates.TabIndex = 4
		'
		'Diagram
		'
		Me.Diagram.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Diagram.Location = New System.Drawing.Point(0, 0)
		Me.Diagram.Name = "Diagram"
		Me.Diagram.Size = New System.Drawing.Size(494, 136)
		Me.Diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Diagram.TabIndex = 0
		Me.Diagram.TabStop = False
		'
		'SequenceDiagrams
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(494, 273)
		Me.Controls.Add(Me.SplitterUpDown)
		Me.Name = "SequenceDiagrams"
		Me.Text = "SequenceDiagrams"
		Me.SplitterUpDown.Panel1.ResumeLayout(False)
		Me.SplitterUpDown.Panel2.ResumeLayout(False)
		Me.SplitterUpDown.Panel2.PerformLayout()
		Me.SplitterUpDown.ResumeLayout(False)
		Me.SplitterTree.Panel1.ResumeLayout(False)
		Me.SplitterTree.Panel2.ResumeLayout(False)
		Me.SplitterTree.ResumeLayout(False)
		Me.SDMenu.ResumeLayout(False)
		Me.SplitterTemplate.Panel1.ResumeLayout(False)
		Me.SplitterTemplate.Panel1.PerformLayout()
		Me.SplitterTemplate.Panel2.ResumeLayout(False)
		Me.SplitterTemplate.ResumeLayout(False)
		CType(Me.Diagram, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitterUpDown As System.Windows.Forms.SplitContainer
	Friend WithEvents SplitterTree As System.Windows.Forms.SplitContainer
	Friend WithEvents SDExplorer As System.Windows.Forms.TreeView
	Friend WithEvents SDMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents MnuAddFolder As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuAddDiagram As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuSave As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuGenerate As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuDelete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuToggleTemplates As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SplitterTemplate As System.Windows.Forms.SplitContainer
	Friend WithEvents DiagramInput As System.Windows.Forms.TextBox
	Friend WithEvents SDTemplates As System.Windows.Forms.WebBrowser
	Friend WithEvents Diagram As System.Windows.Forms.PictureBox
	Friend WithEvents MnuShowDiagrams As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MnuReloadAll As System.Windows.Forms.ToolStripMenuItem
End Class
