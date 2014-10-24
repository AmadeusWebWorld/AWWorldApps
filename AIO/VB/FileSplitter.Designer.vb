<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSplitter
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
		Me.FilePath = New System.Windows.Forms.TextBox
		Me.Output = New System.Windows.Forms.TextBox
		Me.Expression = New System.Windows.Forms.TextBox
		Me.SuspendLayout()
		'
		'FilePath
		'
		Me.FilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FilePath.Location = New System.Drawing.Point(12, 12)
		Me.FilePath.Name = "FilePath"
		Me.FilePath.Size = New System.Drawing.Size(699, 20)
		Me.FilePath.TabIndex = 0
		'
		'Output
		'
		Me.Output.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Output.Location = New System.Drawing.Point(12, 63)
		Me.Output.Multiline = True
		Me.Output.Name = "Output"
		Me.Output.Size = New System.Drawing.Size(699, 375)
		Me.Output.TabIndex = 0
		'
		'Expression
		'
		Me.Expression.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Expression.Location = New System.Drawing.Point(12, 37)
		Me.Expression.Name = "Expression"
		Me.Expression.Size = New System.Drawing.Size(699, 20)
		Me.Expression.TabIndex = 0
		'
		'FileSplitter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(723, 450)
		Me.Controls.Add(Me.Output)
		Me.Controls.Add(Me.Expression)
		Me.Controls.Add(Me.FilePath)
		Me.Name = "FileSplitter"
		Me.Text = "FileSplitter"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents FilePath As System.Windows.Forms.TextBox
	Friend WithEvents Output As System.Windows.Forms.TextBox
	Friend WithEvents Expression As System.Windows.Forms.TextBox

End Class
