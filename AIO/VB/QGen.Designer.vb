<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QGen
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
        Me.Input = New System.Windows.Forms.TextBox
        Me.InputFile = New System.Windows.Forms.ComboBox
        Me.OutputFileFormat = New System.Windows.Forms.TextBox
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.Generate = New System.Windows.Forms.Button
        Me.Append = New System.Windows.Forms.CheckBox
        Me.Output = New System.Windows.Forms.TextBox
        Me.SplitLR = New System.Windows.Forms.SplitContainer
        Me.SplitterUP = New System.Windows.Forms.SplitContainer
        Me.LineTemplateLevels = New System.Windows.Forms.TabControl
        Me.Level1 = New System.Windows.Forms.TabPage
        Me.LineTemplate = New System.Windows.Forms.TextBox
        Me.Level2 = New System.Windows.Forms.TabPage
        Me.Level2Template = New System.Windows.Forms.TextBox
        Me.Level3 = New System.Windows.Forms.TabPage
        Me.Level3Template = New System.Windows.Forms.TextBox
        Me.Level4 = New System.Windows.Forms.TabPage
        Me.Level4Template = New System.Windows.Forms.TextBox
        Me.SplitterOP = New System.Windows.Forms.SplitContainer
        Me.FileTemplate = New System.Windows.Forms.TextBox
        Me.RefreshFiles = New System.Windows.Forms.Button
        Me.MakeCasing = New System.Windows.Forms.Button
        Me.ReplaceBraces = New System.Windows.Forms.CheckBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabsInput = New System.Windows.Forms.CheckBox
        Me.Merge = New System.Windows.Forms.TabPage
        Me.MergeTemplate = New System.Windows.Forms.TextBox
        Me.SplitLR.Panel1.SuspendLayout()
        Me.SplitLR.Panel2.SuspendLayout()
        Me.SplitLR.SuspendLayout()
        Me.SplitterUP.Panel1.SuspendLayout()
        Me.SplitterUP.Panel2.SuspendLayout()
        Me.SplitterUP.SuspendLayout()
        Me.LineTemplateLevels.SuspendLayout()
        Me.Level1.SuspendLayout()
        Me.Level2.SuspendLayout()
        Me.Level3.SuspendLayout()
        Me.Level4.SuspendLayout()
        Me.SplitterOP.Panel1.SuspendLayout()
        Me.SplitterOP.Panel2.SuspendLayout()
        Me.SplitterOP.SuspendLayout()
        Me.Merge.SuspendLayout()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input.Location = New System.Drawing.Point(0, 0)
        Me.Input.Multiline = True
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(207, 143)
        Me.Input.TabIndex = 2
        Me.Input.Text = "string,Id,Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "string,Name,Person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address,Address,Person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "string,Street,Addr" & _
            "ess"
        '
        'InputFile
        '
        Me.InputFile.AllowDrop = True
        Me.InputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputFile.Location = New System.Drawing.Point(12, 13)
        Me.InputFile.Name = "InputFile"
        Me.InputFile.Size = New System.Drawing.Size(441, 21)
        Me.InputFile.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.InputFile, "Use Control + S to save (can type new name and save).")
        '
        'OutputFileFormat
        '
        Me.OutputFileFormat.AllowDrop = True
        Me.OutputFileFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputFileFormat.Location = New System.Drawing.Point(12, 40)
        Me.OutputFileFormat.Name = "OutputFileFormat"
        Me.OutputFileFormat.Size = New System.Drawing.Size(441, 20)
        Me.OutputFileFormat.TabIndex = 1
        Me.OutputFileFormat.Text = "{2}.cs"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Generate
        '
        Me.Generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Generate.Location = New System.Drawing.Point(564, 15)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(54, 22)
        Me.Generate.TabIndex = 2
        Me.Generate.Text = "&Gen"
        Me.ToolTip.SetToolTip(Me.Generate, "Generates")
        Me.Generate.UseVisualStyleBackColor = True
        '
        'Append
        '
        Me.Append.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Append.AutoSize = True
        Me.Append.Location = New System.Drawing.Point(564, 38)
        Me.Append.Name = "Append"
        Me.Append.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Append.Size = New System.Drawing.Size(56, 21)
        Me.Append.TabIndex = 3
        Me.Append.Text = "&Merge"
        Me.Append.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.Append, "Merges into a single file.")
        Me.Append.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Output.Location = New System.Drawing.Point(0, 0)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(393, 96)
        Me.Output.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Output, "Double Click the Generated File.")
        '
        'SplitLR
        '
        Me.SplitLR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitLR.Location = New System.Drawing.Point(12, 66)
        Me.SplitLR.Name = "SplitLR"
        '
        'SplitLR.Panel1
        '
        Me.SplitLR.Panel1.Controls.Add(Me.SplitterUP)
        '
        'SplitLR.Panel2
        '
        Me.SplitLR.Panel2.Controls.Add(Me.SplitterOP)
        Me.SplitLR.Size = New System.Drawing.Size(606, 254)
        Me.SplitLR.SplitterDistance = 207
        Me.SplitLR.SplitterWidth = 6
        Me.SplitLR.TabIndex = 4
        '
        'SplitterUP
        '
        Me.SplitterUP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitterUP.Location = New System.Drawing.Point(0, 0)
        Me.SplitterUP.Name = "SplitterUP"
        Me.SplitterUP.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitterUP.Panel1
        '
        Me.SplitterUP.Panel1.Controls.Add(Me.LineTemplateLevels)
        '
        'SplitterUP.Panel2
        '
        Me.SplitterUP.Panel2.Controls.Add(Me.Input)
        Me.SplitterUP.Size = New System.Drawing.Size(207, 254)
        Me.SplitterUP.SplitterDistance = 105
        Me.SplitterUP.SplitterWidth = 6
        Me.SplitterUP.TabIndex = 3
        '
        'LineTemplateLevels
        '
        Me.LineTemplateLevels.Controls.Add(Me.Level1)
        Me.LineTemplateLevels.Controls.Add(Me.Level2)
        Me.LineTemplateLevels.Controls.Add(Me.Level3)
        Me.LineTemplateLevels.Controls.Add(Me.Level4)
        Me.LineTemplateLevels.Controls.Add(Me.Merge)
        Me.LineTemplateLevels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineTemplateLevels.Location = New System.Drawing.Point(0, 0)
        Me.LineTemplateLevels.Name = "LineTemplateLevels"
        Me.LineTemplateLevels.SelectedIndex = 0
        Me.LineTemplateLevels.Size = New System.Drawing.Size(207, 105)
        Me.LineTemplateLevels.TabIndex = 4
        '
        'Level1
        '
        Me.Level1.Controls.Add(Me.LineTemplate)
        Me.Level1.Location = New System.Drawing.Point(4, 22)
        Me.Level1.Margin = New System.Windows.Forms.Padding(0)
        Me.Level1.Name = "Level1"
        Me.Level1.Size = New System.Drawing.Size(199, 79)
        Me.Level1.TabIndex = 0
        Me.Level1.Text = "First"
        Me.Level1.UseVisualStyleBackColor = True
        '
        'LineTemplate
        '
        Me.LineTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineTemplate.Location = New System.Drawing.Point(0, 0)
        Me.LineTemplate.Multiline = True
        Me.LineTemplate.Name = "LineTemplate"
        Me.LineTemplate.Size = New System.Drawing.Size(199, 79)
        Me.LineTemplate.TabIndex = 2
        Me.LineTemplate.Text = "///Gets or sets the {1} of the given {2}." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "public virtual {0} {1} << get; set; >>" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Level2
        '
        Me.Level2.Controls.Add(Me.Level2Template)
        Me.Level2.Location = New System.Drawing.Point(4, 22)
        Me.Level2.Name = "Level2"
        Me.Level2.Size = New System.Drawing.Size(199, 79)
        Me.Level2.TabIndex = 1
        Me.Level2.Text = "Lvl 2"
        Me.Level2.UseVisualStyleBackColor = True
        '
        'Level2Template
        '
        Me.Level2Template.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Level2Template.Location = New System.Drawing.Point(0, 0)
        Me.Level2Template.Multiline = True
        Me.Level2Template.Name = "Level2Template"
        Me.Level2Template.Size = New System.Drawing.Size(199, 79)
        Me.Level2Template.TabIndex = 3
        Me.Level2Template.Text = "[LEVEL1]"
        '
        'Level3
        '
        Me.Level3.Controls.Add(Me.Level3Template)
        Me.Level3.Location = New System.Drawing.Point(4, 22)
        Me.Level3.Name = "Level3"
        Me.Level3.Size = New System.Drawing.Size(199, 79)
        Me.Level3.TabIndex = 2
        Me.Level3.Text = "Lvl 3"
        Me.Level3.UseVisualStyleBackColor = True
        '
        'Level3Template
        '
        Me.Level3Template.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Level3Template.Location = New System.Drawing.Point(0, 0)
        Me.Level3Template.Multiline = True
        Me.Level3Template.Name = "Level3Template"
        Me.Level3Template.Size = New System.Drawing.Size(199, 79)
        Me.Level3Template.TabIndex = 4
        Me.Level3Template.Text = "[LEVEL2]"
        '
        'Level4
        '
        Me.Level4.Controls.Add(Me.Level4Template)
        Me.Level4.Location = New System.Drawing.Point(4, 22)
        Me.Level4.Name = "Level4"
        Me.Level4.Size = New System.Drawing.Size(199, 79)
        Me.Level4.TabIndex = 3
        Me.Level4.Text = "Lvl 4"
        Me.Level4.UseVisualStyleBackColor = True
        '
        'Level4Template
        '
        Me.Level4Template.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Level4Template.Location = New System.Drawing.Point(0, 0)
        Me.Level4Template.Multiline = True
        Me.Level4Template.Name = "Level4Template"
        Me.Level4Template.Size = New System.Drawing.Size(199, 79)
        Me.Level4Template.TabIndex = 4
        Me.Level4Template.Text = "[LEVEL3]"
        '
        'SplitterOP
        '
        Me.SplitterOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitterOP.Location = New System.Drawing.Point(0, 0)
        Me.SplitterOP.Name = "SplitterOP"
        Me.SplitterOP.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitterOP.Panel1
        '
        Me.SplitterOP.Panel1.Controls.Add(Me.FileTemplate)
        '
        'SplitterOP.Panel2
        '
        Me.SplitterOP.Panel2.Controls.Add(Me.Output)
        Me.SplitterOP.Size = New System.Drawing.Size(393, 254)
        Me.SplitterOP.SplitterDistance = 154
        Me.SplitterOP.TabIndex = 4
        '
        'FileTemplate
        '
        Me.FileTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileTemplate.Location = New System.Drawing.Point(0, 0)
        Me.FileTemplate.Multiline = True
        Me.FileTemplate.Name = "FileTemplate"
        Me.FileTemplate.Size = New System.Drawing.Size(393, 154)
        Me.FileTemplate.TabIndex = 3
        Me.FileTemplate.Text = "using System;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "namespace MyApp <<" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "public class {2} <<" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#region Properties" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[" & _
            "LINES]#endregion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RefreshFiles
        '
        Me.RefreshFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshFiles.Location = New System.Drawing.Point(459, 14)
        Me.RefreshFiles.Name = "RefreshFiles"
        Me.RefreshFiles.Size = New System.Drawing.Size(60, 22)
        Me.RefreshFiles.TabIndex = 2
        Me.RefreshFiles.Text = "&Refresh"
        Me.ToolTip.SetToolTip(Me.RefreshFiles, "Refresh list of files in DropDown.")
        Me.RefreshFiles.UseVisualStyleBackColor = True
        '
        'MakeCasing
        '
        Me.MakeCasing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MakeCasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MakeCasing.Location = New System.Drawing.Point(459, 39)
        Me.MakeCasing.Name = "MakeCasing"
        Me.MakeCasing.Size = New System.Drawing.Size(43, 21)
        Me.MakeCasing.TabIndex = 2
        Me.MakeCasing.Text = "&Case"
        Me.ToolTip.SetToolTip(Me.MakeCasing, "Converts first parameter into 3 parts forr having upper({1}{2} and lower{0}{2} ca" & _
                "se. Obsolete with C# 3.5 Auto Properties.")
        Me.MakeCasing.UseVisualStyleBackColor = True
        '
        'ReplaceBraces
        '
        Me.ReplaceBraces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReplaceBraces.AutoSize = True
        Me.ReplaceBraces.Checked = True
        Me.ReplaceBraces.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ReplaceBraces.Location = New System.Drawing.Point(525, 14)
        Me.ReplaceBraces.Name = "ReplaceBraces"
        Me.ReplaceBraces.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.ReplaceBraces.Size = New System.Drawing.Size(33, 21)
        Me.ReplaceBraces.TabIndex = 3
        Me.ReplaceBraces.Text = "&E"
        Me.ReplaceBraces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.ReplaceBraces, "Replaces << with {, >> with } and  \r\n with NewLine.")
        Me.ReplaceBraces.UseVisualStyleBackColor = True
        '
        'TabsInput
        '
        Me.TabsInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabsInput.AutoSize = True
        Me.TabsInput.Checked = True
        Me.TabsInput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TabsInput.Location = New System.Drawing.Point(508, 38)
        Me.TabsInput.Name = "TabsInput"
        Me.TabsInput.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.TabsInput.Size = New System.Drawing.Size(50, 21)
        Me.TabsInput.TabIndex = 3
        Me.TabsInput.Text = "&Tabs"
        Me.TabsInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.TabsInput, "Input is Tab not Comma delimited.")
        Me.TabsInput.UseVisualStyleBackColor = True
        '
        'Merge
        '
        Me.Merge.Controls.Add(Me.MergeTemplate)
        Me.Merge.Location = New System.Drawing.Point(4, 22)
        Me.Merge.Name = "Merge"
        Me.Merge.Padding = New System.Windows.Forms.Padding(3)
        Me.Merge.Size = New System.Drawing.Size(199, 79)
        Me.Merge.TabIndex = 4
        Me.Merge.Text = "Merge"
        Me.Merge.UseVisualStyleBackColor = True
        '
        'MergeTemplate
        '
        Me.MergeTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MergeTemplate.Location = New System.Drawing.Point(3, 3)
        Me.MergeTemplate.Multiline = True
        Me.MergeTemplate.Name = "MergeTemplate"
        Me.MergeTemplate.Size = New System.Drawing.Size(193, 73)
        Me.MergeTemplate.TabIndex = 5
        Me.MergeTemplate.Text = "[FILES]"
        '
        'QGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 332)
        Me.Controls.Add(Me.SplitLR)
        Me.Controls.Add(Me.MakeCasing)
        Me.Controls.Add(Me.TabsInput)
        Me.Controls.Add(Me.ReplaceBraces)
        Me.Controls.Add(Me.Append)
        Me.Controls.Add(Me.RefreshFiles)
        Me.Controls.Add(Me.Generate)
        Me.Controls.Add(Me.OutputFileFormat)
        Me.Controls.Add(Me.InputFile)
        Me.Name = "QGen"
        Me.Text = "Quick Gen"
        Me.SplitLR.Panel1.ResumeLayout(False)
        Me.SplitLR.Panel2.ResumeLayout(False)
        Me.SplitLR.ResumeLayout(False)
        Me.SplitterUP.Panel1.ResumeLayout(False)
        Me.SplitterUP.Panel2.ResumeLayout(False)
        Me.SplitterUP.Panel2.PerformLayout()
        Me.SplitterUP.ResumeLayout(False)
        Me.LineTemplateLevels.ResumeLayout(False)
        Me.Level1.ResumeLayout(False)
        Me.Level1.PerformLayout()
        Me.Level2.ResumeLayout(False)
        Me.Level2.PerformLayout()
        Me.Level3.ResumeLayout(False)
        Me.Level3.PerformLayout()
        Me.Level4.ResumeLayout(False)
        Me.Level4.PerformLayout()
        Me.SplitterOP.Panel1.ResumeLayout(False)
        Me.SplitterOP.Panel1.PerformLayout()
        Me.SplitterOP.Panel2.ResumeLayout(False)
        Me.SplitterOP.Panel2.PerformLayout()
        Me.SplitterOP.ResumeLayout(False)
        Me.Merge.ResumeLayout(False)
        Me.Merge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents InputFile As System.Windows.Forms.ComboBox
    Friend WithEvents OutputFileFormat As System.Windows.Forms.TextBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Generate As System.Windows.Forms.Button
    Friend WithEvents Append As System.Windows.Forms.CheckBox
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents SplitLR As System.Windows.Forms.SplitContainer
    Friend WithEvents LineTemplate As System.Windows.Forms.TextBox
    Friend WithEvents SplitterUP As System.Windows.Forms.SplitContainer
    Friend WithEvents RefreshFiles As System.Windows.Forms.Button
    Friend WithEvents MakeCasing As System.Windows.Forms.Button
    Friend WithEvents SplitterOP As System.Windows.Forms.SplitContainer
    Friend WithEvents FileTemplate As System.Windows.Forms.TextBox
    Friend WithEvents ReplaceBraces As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TabsInput As System.Windows.Forms.CheckBox
    Friend WithEvents LineTemplateLevels As System.Windows.Forms.TabControl
    Friend WithEvents Level1 As System.Windows.Forms.TabPage
    Friend WithEvents Level2 As System.Windows.Forms.TabPage
    Friend WithEvents Level3 As System.Windows.Forms.TabPage
    Friend WithEvents Level4 As System.Windows.Forms.TabPage
    Friend WithEvents Level2Template As System.Windows.Forms.TextBox
    Friend WithEvents Level3Template As System.Windows.Forms.TextBox
    Friend WithEvents Level4Template As System.Windows.Forms.TextBox
    Friend WithEvents Merge As System.Windows.Forms.TabPage
    Friend WithEvents MergeTemplate As System.Windows.Forms.TextBox

End Class
