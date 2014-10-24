<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileFinder
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
		Me.Locations = New System.Windows.Forms.TextBox
		Me.Criteria = New System.Windows.Forms.TextBox
		Me.Find = New System.Windows.Forms.Button
		Me.Files = New System.Windows.Forms.ListView
		Me.Index = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'Locations
		'
		Me.Locations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Locations.Location = New System.Drawing.Point(13, 13)
		Me.Locations.Multiline = True
		Me.Locations.Name = "Locations"
		Me.Locations.Size = New System.Drawing.Size(698, 93)
		Me.Locations.TabIndex = 0
		Me.Locations.Text = "D:\Dump\All Docs\"
		'
		'Criteria
		'
		Me.Criteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Criteria.Location = New System.Drawing.Point(12, 112)
		Me.Criteria.Multiline = True
		Me.Criteria.Name = "Criteria"
		Me.Criteria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.Criteria.Size = New System.Drawing.Size(618, 65)
		Me.Criteria.TabIndex = 0
		'
		'Find
		'
		Me.Find.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Find.Location = New System.Drawing.Point(636, 154)
		Me.Find.Name = "Find"
		Me.Find.Size = New System.Drawing.Size(75, 23)
		Me.Find.TabIndex = 1
		Me.Find.Text = "&Find"
		Me.Find.UseVisualStyleBackColor = True
		'
		'Files
		'
		Me.Files.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Files.Location = New System.Drawing.Point(13, 196)
		Me.Files.Name = "Files"
		Me.Files.Size = New System.Drawing.Size(698, 270)
		Me.Files.TabIndex = 2
		Me.Files.UseCompatibleStateImageBehavior = False
		'
		'Index
		'
		Me.Index.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Index.Location = New System.Drawing.Point(636, 112)
		Me.Index.Name = "Index"
		Me.Index.Size = New System.Drawing.Size(75, 23)
		Me.Index.TabIndex = 1
		Me.Index.Text = "&Index"
		Me.Index.UseVisualStyleBackColor = True
		'
		'FileFinder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(723, 478)
		Me.Controls.Add(Me.Files)
		Me.Controls.Add(Me.Index)
		Me.Controls.Add(Me.Find)
		Me.Controls.Add(Me.Criteria)
		Me.Controls.Add(Me.Locations)
		Me.Name = "FileFinder"
		Me.Text = "FileFinder"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Locations As System.Windows.Forms.TextBox
	Friend WithEvents Criteria As System.Windows.Forms.TextBox
	Friend WithEvents Find As System.Windows.Forms.Button
	Friend WithEvents Files As System.Windows.Forms.ListView
	Friend WithEvents Index As System.Windows.Forms.Button
End Class
