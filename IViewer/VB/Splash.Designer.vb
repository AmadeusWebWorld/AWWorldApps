<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
		Me.lblBy = New System.Windows.Forms.Label()
		Me.lblVersion = New System.Windows.Forms.Label()
		Me.lblMsg = New System.Windows.Forms.Label()
		Me.lblMail = New System.Windows.Forms.LinkLabel()
		Me.lblSite = New System.Windows.Forms.LinkLabel()
		Me.SuspendLayout()
		'
		'lblBy
		'
		Me.lblBy.AutoSize = True
		Me.lblBy.BackColor = System.Drawing.Color.White
		Me.lblBy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBy.ForeColor = System.Drawing.Color.Gray
		Me.lblBy.Location = New System.Drawing.Point(97, 147)
		Me.lblBy.Name = "lblBy"
		Me.lblBy.Size = New System.Drawing.Size(131, 14)
		Me.lblBy.TabIndex = 0
		Me.lblBy.Text = "by Imran Ali Namazi."
		'
		'lblVersion
		'
		Me.lblVersion.AutoSize = True
		Me.lblVersion.BackColor = System.Drawing.Color.White
		Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.ForeColor = System.Drawing.Color.Gray
		Me.lblVersion.Location = New System.Drawing.Point(155, 174)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(149, 14)
		Me.lblVersion.TabIndex = 0
		Me.lblVersion.Text = "version: 5.2. build: 424"
		'
		'lblMsg
		'
		Me.lblMsg.BackColor = System.Drawing.Color.White
		Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMsg.ForeColor = System.Drawing.Color.Maroon
		Me.lblMsg.Location = New System.Drawing.Point(13, 198)
		Me.lblMsg.Name = "lblMsg"
		Me.lblMsg.Size = New System.Drawing.Size(432, 42)
		Me.lblMsg.TabIndex = 0
		Me.lblMsg.Text = "IViewer is Absolutely FREE!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(c) 1999 - {0} - No Rights Reserved."
		Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblMail
		'
		Me.lblMail.AutoSize = True
		Me.lblMail.BackColor = System.Drawing.Color.White
		Me.lblMail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
		Me.lblMail.LinkColor = System.Drawing.Color.Teal
		Me.lblMail.Location = New System.Drawing.Point(234, 147)
		Me.lblMail.Name = "lblMail"
		Me.lblMail.Size = New System.Drawing.Size(120, 14)
		Me.lblMail.TabIndex = 2
		Me.lblMail.TabStop = True
		Me.lblMail.Text = "imran@cselian.com"
		'
		'lblSite
		'
		Me.lblSite.AutoSize = True
		Me.lblSite.BackColor = System.Drawing.Color.White
		Me.lblSite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
		Me.lblSite.LinkColor = System.Drawing.Color.Teal
		Me.lblSite.Location = New System.Drawing.Point(110, 247)
		Me.lblSite.Name = "lblSite"
		Me.lblSite.Size = New System.Drawing.Size(229, 14)
		Me.lblSite.TabIndex = 2
		Me.lblSite.TabStop = True
		Me.lblSite.Text = "http://cselian.com/blog/?s=iviewer"
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(458, 271)
		Me.Controls.Add(Me.lblSite)
		Me.Controls.Add(Me.lblMail)
		Me.Controls.Add(Me.lblMsg)
		Me.Controls.Add(Me.lblVersion)
		Me.Controls.Add(Me.lblBy)
		Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.Color.Gray
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Splash"
		Me.Padding = New System.Windows.Forms.Padding(10)
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "About IViewer"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblBy As System.Windows.Forms.Label
	Friend WithEvents lblVersion As System.Windows.Forms.Label
	Friend WithEvents lblMsg As System.Windows.Forms.Label
	Friend WithEvents lblMail As System.Windows.Forms.LinkLabel
	Friend WithEvents lblSite As System.Windows.Forms.LinkLabel

End Class
