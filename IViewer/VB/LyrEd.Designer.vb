<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LyrEd
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
		Me.components = New System.ComponentModel.Container()
		Me.Items = New System.Windows.Forms.ListBox()
		Me.EdMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.IncludeRestMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MoveToNowMnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MoveFwdByPt1Mnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MoveBackByPt1Mnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MoveFwdByPt5Mnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.MoveBackByPt5Mnu = New System.Windows.Forms.ToolStripMenuItem()
		Me.chkLoop = New System.Windows.Forms.CheckBox()
		Me.txtEvery = New System.Windows.Forms.TextBox()
		Me.tabControls = New System.Windows.Forms.TabControl()
		Me.tabGeneral = New System.Windows.Forms.TabPage()
		Me.tabLoop = New System.Windows.Forms.TabPage()
		Me.rdoLoopSelection = New System.Windows.Forms.RadioButton()
		Me.rdoLoopGroup = New System.Windows.Forms.RadioButton()
		Me.lblLoopTimes = New System.Windows.Forms.Label()
		Me.txtLoopTimes = New System.Windows.Forms.TextBox()
		Me.rdoLoopEvery = New System.Windows.Forms.RadioButton()
		Me.lblLoopNth = New System.Windows.Forms.Label()
		Me.EdMenu.SuspendLayout()
		Me.tabControls.SuspendLayout()
		Me.tabLoop.SuspendLayout()
		Me.SuspendLayout()
		'
		'Items
		'
		Me.Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Items.ContextMenuStrip = Me.EdMenu
		Me.Items.FormattingEnabled = True
		Me.Items.Location = New System.Drawing.Point(12, 78)
		Me.Items.Name = "Items"
		Me.Items.Size = New System.Drawing.Size(560, 199)
		Me.Items.TabIndex = 0
		'
		'EdMenu
		'
		Me.EdMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncludeRestMnu, Me.MoveToNowMnu, Me.MoveFwdByPt1Mnu, Me.MoveBackByPt1Mnu, Me.MoveFwdByPt5Mnu, Me.MoveBackByPt5Mnu})
		Me.EdMenu.Name = "ContextMenuStrip1"
		Me.EdMenu.Size = New System.Drawing.Size(258, 136)
		'
		'IncludeRestMnu
		'
		Me.IncludeRestMnu.CheckOnClick = True
		Me.IncludeRestMnu.Name = "IncludeRestMnu"
		Me.IncludeRestMnu.ShortcutKeyDisplayString = "Ctrl + I"
		Me.IncludeRestMnu.Size = New System.Drawing.Size(257, 22)
		Me.IncludeRestMnu.Text = "Include Rest when Moving"
		'
		'MoveToNowMnu
		'
		Me.MoveToNowMnu.Name = "MoveToNowMnu"
		Me.MoveToNowMnu.ShortcutKeyDisplayString = "Insert"
		Me.MoveToNowMnu.Size = New System.Drawing.Size(257, 22)
		Me.MoveToNowMnu.Text = "Move to where now Playing"
		'
		'MoveFwdByPt1Mnu
		'
		Me.MoveFwdByPt1Mnu.Name = "MoveFwdByPt1Mnu"
		Me.MoveFwdByPt1Mnu.ShortcutKeyDisplayString = "]"
		Me.MoveFwdByPt1Mnu.Size = New System.Drawing.Size(257, 22)
		Me.MoveFwdByPt1Mnu.Text = "Move Fwd By .1"
		'
		'MoveBackByPt1Mnu
		'
		Me.MoveBackByPt1Mnu.Name = "MoveBackByPt1Mnu"
		Me.MoveBackByPt1Mnu.ShortcutKeyDisplayString = "["
		Me.MoveBackByPt1Mnu.Size = New System.Drawing.Size(257, 22)
		Me.MoveBackByPt1Mnu.Text = "Move Back by .1"
		'
		'MoveFwdByPt5Mnu
		'
		Me.MoveFwdByPt5Mnu.Name = "MoveFwdByPt5Mnu"
		Me.MoveFwdByPt5Mnu.ShortcutKeyDisplayString = "Ctrl + ]"
		Me.MoveFwdByPt5Mnu.Size = New System.Drawing.Size(257, 22)
		Me.MoveFwdByPt5Mnu.Text = "Move Fwd by .5"
		'
		'MoveBackByPt5Mnu
		'
		Me.MoveBackByPt5Mnu.Name = "MoveBackByPt5Mnu"
		Me.MoveBackByPt5Mnu.ShortcutKeyDisplayString = "Ctrl + ["
		Me.MoveBackByPt5Mnu.Size = New System.Drawing.Size(257, 22)
		Me.MoveBackByPt5Mnu.Text = "Move Back by .5"
		'
		'chkLoop
		'
		Me.chkLoop.AutoSize = True
		Me.chkLoop.Location = New System.Drawing.Point(6, 7)
		Me.chkLoop.Name = "chkLoop"
		Me.chkLoop.Size = New System.Drawing.Size(50, 17)
		Me.chkLoop.TabIndex = 1
		Me.chkLoop.Text = "Loop"
		Me.chkLoop.UseVisualStyleBackColor = True
		'
		'txtEvery
		'
		Me.txtEvery.Location = New System.Drawing.Point(114, 5)
		Me.txtEvery.Name = "txtEvery"
		Me.txtEvery.Size = New System.Drawing.Size(28, 20)
		Me.txtEvery.TabIndex = 2
		'
		'tabControls
		'
		Me.tabControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControls.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tabControls.Controls.Add(Me.tabGeneral)
		Me.tabControls.Controls.Add(Me.tabLoop)
		Me.tabControls.Location = New System.Drawing.Point(12, 12)
		Me.tabControls.Multiline = True
		Me.tabControls.Name = "tabControls"
		Me.tabControls.SelectedIndex = 0
		Me.tabControls.Size = New System.Drawing.Size(560, 60)
		Me.tabControls.TabIndex = 4
		'
		'tabGeneral
		'
		Me.tabGeneral.Location = New System.Drawing.Point(4, 25)
		Me.tabGeneral.Name = "tabGeneral"
		Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
		Me.tabGeneral.Size = New System.Drawing.Size(552, 31)
		Me.tabGeneral.TabIndex = 0
		Me.tabGeneral.Text = "General"
		Me.tabGeneral.UseVisualStyleBackColor = True
		'
		'tabLoop
		'
		Me.tabLoop.Controls.Add(Me.lblLoopNth)
		Me.tabLoop.Controls.Add(Me.rdoLoopSelection)
		Me.tabLoop.Controls.Add(Me.rdoLoopGroup)
		Me.tabLoop.Controls.Add(Me.lblLoopTimes)
		Me.tabLoop.Controls.Add(Me.txtLoopTimes)
		Me.tabLoop.Controls.Add(Me.txtEvery)
		Me.tabLoop.Controls.Add(Me.rdoLoopEvery)
		Me.tabLoop.Controls.Add(Me.chkLoop)
		Me.tabLoop.Location = New System.Drawing.Point(4, 25)
		Me.tabLoop.Name = "tabLoop"
		Me.tabLoop.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLoop.Size = New System.Drawing.Size(552, 31)
		Me.tabLoop.TabIndex = 1
		Me.tabLoop.Text = "Looping"
		Me.tabLoop.UseVisualStyleBackColor = True
		'
		'rdoLoopSelection
		'
		Me.rdoLoopSelection.AutoSize = True
		Me.rdoLoopSelection.Location = New System.Drawing.Point(243, 8)
		Me.rdoLoopSelection.Name = "rdoLoopSelection"
		Me.rdoLoopSelection.Size = New System.Drawing.Size(69, 17)
		Me.rdoLoopSelection.TabIndex = 7
		Me.rdoLoopSelection.TabStop = True
		Me.rdoLoopSelection.Text = "&Selection"
		Me.rdoLoopSelection.UseVisualStyleBackColor = True
		'
		'rdoLoopGroup
		'
		Me.rdoLoopGroup.AutoSize = True
		Me.rdoLoopGroup.Checked = True
		Me.rdoLoopGroup.Location = New System.Drawing.Point(183, 8)
		Me.rdoLoopGroup.Name = "rdoLoopGroup"
		Me.rdoLoopGroup.Size = New System.Drawing.Size(54, 17)
		Me.rdoLoopGroup.TabIndex = 6
		Me.rdoLoopGroup.TabStop = True
		Me.rdoLoopGroup.Text = "&Group"
		Me.rdoLoopGroup.UseVisualStyleBackColor = True
		'
		'lblLoopTimes
		'
		Me.lblLoopTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLoopTimes.AutoSize = True
		Me.lblLoopTimes.Location = New System.Drawing.Point(509, 9)
		Me.lblLoopTimes.Name = "lblLoopTimes"
		Me.lblLoopTimes.Size = New System.Drawing.Size(37, 13)
		Me.lblLoopTimes.TabIndex = 5
		Me.lblLoopTimes.Text = "time(s)"
		'
		'txtLoopTimes
		'
		Me.txtLoopTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtLoopTimes.Location = New System.Drawing.Point(475, 5)
		Me.txtLoopTimes.Name = "txtLoopTimes"
		Me.txtLoopTimes.Size = New System.Drawing.Size(28, 20)
		Me.txtLoopTimes.TabIndex = 2
		'
		'rdoLoopEvery
		'
		Me.rdoLoopEvery.AutoSize = True
		Me.rdoLoopEvery.Location = New System.Drawing.Point(62, 7)
		Me.rdoLoopEvery.Name = "rdoLoopEvery"
		Me.rdoLoopEvery.Size = New System.Drawing.Size(115, 17)
		Me.rdoLoopEvery.TabIndex = 4
		Me.rdoLoopEvery.TabStop = True
		Me.rdoLoopEvery.Text = "&Every              lines"
		Me.rdoLoopEvery.UseVisualStyleBackColor = True
		'
		'lblLoopNth
		'
		Me.lblLoopNth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLoopNth.AutoSize = True
		Me.lblLoopNth.Location = New System.Drawing.Point(444, 9)
		Me.lblLoopNth.Name = "lblLoopNth"
		Me.lblLoopNth.Size = New System.Drawing.Size(25, 13)
		Me.lblLoopNth.TabIndex = 8
		Me.lblLoopNth.Text = "0 of"
		'
		'LyrEd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(584, 286)
		Me.Controls.Add(Me.tabControls)
		Me.Controls.Add(Me.Items)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "LyrEd"
		Me.Text = "Lyrics Editor"
		Me.EdMenu.ResumeLayout(False)
		Me.tabControls.ResumeLayout(False)
		Me.tabLoop.ResumeLayout(False)
		Me.tabLoop.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Items As System.Windows.Forms.ListBox
	Friend WithEvents chkLoop As System.Windows.Forms.CheckBox
	Friend WithEvents txtEvery As System.Windows.Forms.TextBox
	Friend WithEvents EdMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents IncludeRestMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MoveToNowMnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MoveFwdByPt1Mnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MoveBackByPt1Mnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MoveFwdByPt5Mnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MoveBackByPt5Mnu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tabControls As System.Windows.Forms.TabControl
	Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
	Friend WithEvents tabLoop As System.Windows.Forms.TabPage
	Friend WithEvents rdoLoopEvery As System.Windows.Forms.RadioButton
	Friend WithEvents lblLoopTimes As System.Windows.Forms.Label
	Friend WithEvents txtLoopTimes As System.Windows.Forms.TextBox
	Friend WithEvents rdoLoopSelection As System.Windows.Forms.RadioButton
	Friend WithEvents rdoLoopGroup As System.Windows.Forms.RadioButton
	Friend WithEvents lblLoopNth As System.Windows.Forms.Label
End Class
