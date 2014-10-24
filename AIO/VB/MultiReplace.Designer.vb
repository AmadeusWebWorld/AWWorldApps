<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiReplace
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
        Me.InputFile = New System.Windows.Forms.ComboBox
        Me.FindIn = New System.Windows.Forms.TextBox
        Me.Replace = New System.Windows.Forms.Button
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReplaceTo = New System.Windows.Forms.TextBox
        Me.MultilineCount = New System.Windows.Forms.NumericUpDown
        Me.AddRow = New System.Windows.Forms.Button
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.Items = New System.Windows.Forms.Panel
        CType(Me.MultilineCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputFile
        '
        Me.InputFile.AllowDrop = True
        Me.InputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputFile.Location = New System.Drawing.Point(12, 13)
        Me.InputFile.Name = "InputFile"
        Me.InputFile.Size = New System.Drawing.Size(521, 21)
        Me.InputFile.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.InputFile, "Use Control + S to save (can type new name and save).")
        '
        'FindIn
        '
        Me.FindIn.AllowDrop = True
        Me.FindIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindIn.Location = New System.Drawing.Point(12, 40)
        Me.FindIn.Name = "FindIn"
        Me.FindIn.Size = New System.Drawing.Size(521, 20)
        Me.FindIn.TabIndex = 1
        Me.FindIn.Text = "Input.txt"
        '
        'Replace
        '
        Me.Replace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Replace.Location = New System.Drawing.Point(539, 15)
        Me.Replace.Name = "Replace"
        Me.Replace.Size = New System.Drawing.Size(54, 22)
        Me.Replace.TabIndex = 2
        Me.Replace.Text = "&Rep"
        Me.ToolTip.SetToolTip(Me.Replace, "Replaces")
        Me.Replace.UseVisualStyleBackColor = True
        '
        'ReplaceTo
        '
        Me.ReplaceTo.AllowDrop = True
        Me.ReplaceTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReplaceTo.Location = New System.Drawing.Point(12, 66)
        Me.ReplaceTo.Name = "ReplaceTo"
        Me.ReplaceTo.Size = New System.Drawing.Size(521, 20)
        Me.ReplaceTo.TabIndex = 1
        Me.ReplaceTo.Text = "Substituted.txt"
        '
        'MultilineCount
        '
        Me.MultilineCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MultilineCount.Location = New System.Drawing.Point(539, 40)
        Me.MultilineCount.Name = "MultilineCount"
        Me.MultilineCount.Size = New System.Drawing.Size(54, 20)
        Me.MultilineCount.TabIndex = 3
        Me.MultilineCount.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'AddRow
        '
        Me.AddRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddRow.Location = New System.Drawing.Point(539, 66)
        Me.AddRow.Name = "AddRow"
        Me.AddRow.Size = New System.Drawing.Size(54, 22)
        Me.AddRow.TabIndex = 2
        Me.AddRow.Text = "&Add"
        Me.AddRow.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Items
        '
        Me.Items.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Items.AutoSize = True
        Me.Items.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Items.Location = New System.Drawing.Point(12, 98)
        Me.Items.MinimumSize = New System.Drawing.Size(500, 100)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(500, 100)
        Me.Items.TabIndex = 5
        '
        'MultiReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(630, 332)
        Me.Controls.Add(Me.Items)
        Me.Controls.Add(Me.MultilineCount)
        Me.Controls.Add(Me.AddRow)
        Me.Controls.Add(Me.Replace)
        Me.Controls.Add(Me.ReplaceTo)
        Me.Controls.Add(Me.FindIn)
        Me.Controls.Add(Me.InputFile)
        Me.Name = "MultiReplace"
        Me.Text = "Quick Gen"
        CType(Me.MultilineCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputFile As System.Windows.Forms.ComboBox
    Friend WithEvents FindIn As System.Windows.Forms.TextBox
    Friend WithEvents Replace As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ReplaceTo As System.Windows.Forms.TextBox
    Friend WithEvents MultilineCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddRow As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Items As System.Windows.Forms.Panel

End Class
