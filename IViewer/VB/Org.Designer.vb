<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Org
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
		Me.tvwItems = New System.Windows.Forms.TreeView()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.lblFol = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'tvwItems
		'
		Me.tvwItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tvwItems.Location = New System.Drawing.Point(8, 38)
		Me.tvwItems.Name = "tvwItems"
		Me.tvwItems.Size = New System.Drawing.Size(454, 324)
		Me.tvwItems.TabIndex = 0
		'
		'btnRefresh
		'
		Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnRefresh.Location = New System.Drawing.Point(387, 9)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
		Me.btnRefresh.TabIndex = 1
		Me.btnRefresh.Text = "&Refresh"
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'lblFol
		'
		Me.lblFol.AutoSize = True
		Me.lblFol.Location = New System.Drawing.Point(5, 14)
		Me.lblFol.Name = "lblFol"
		Me.lblFol.Size = New System.Drawing.Size(39, 13)
		Me.lblFol.TabIndex = 2
		Me.lblFol.Text = "Label1"
		'
		'Org
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(474, 374)
		Me.Controls.Add(Me.lblFol)
		Me.Controls.Add(Me.btnRefresh)
		Me.Controls.Add(Me.tvwItems)
		Me.Name = "Org"
		Me.Text = "Folder Organization"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tvwItems As System.Windows.Forms.TreeView
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents lblFol As System.Windows.Forms.Label
End Class
