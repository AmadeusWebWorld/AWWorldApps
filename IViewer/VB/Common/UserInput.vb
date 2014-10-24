Public Class UserInput
	Inherits Form

	Private WithEvents lstItems As System.Windows.Forms.ListBox
	Private WithEvents btnCancel As System.Windows.Forms.Button
	Private WithEvents btnOk As System.Windows.Forms.Button

	Public Sub New(ByVal options() As Object, ByVal selected() As Object, ByVal multiple As Boolean)
		InitializeComponent()

		Text = "Select Which Folders to add to library"
		lstItems.Items.AddRange(options)
		If multiple Then lstItems.SelectionMode = SelectionMode.MultiExtended
		If Not selected Is Nothing Then
			For Each sel As Object In selected
				lstItems.SelectedItems.Add(sel)
			Next
		End If
	End Sub

	Public ReadOnly Property SelectedItem As Object
		Get
			Return lstItems.SelectedItem
		End Get
	End Property

	Public ReadOnly Property SelectedItems As Object()
		Get
			Dim items As New List(Of Object)
			For Each itm As Object In lstItems.SelectedItems
				items.Add(itm)
			Next
			Return items.ToArray
		End Get
	End Property

	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
		Close()
	End Sub

	Private Sub InitializeComponent()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.lstItems = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnOk
		'
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(66, 130)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 0
		Me.btnOk.Text = "&Select"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(147, 130)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "&Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'lstItems
		'
		Me.lstItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstItems.FormattingEnabled = True
		Me.lstItems.Location = New System.Drawing.Point(12, 12)
		Me.lstItems.Name = "lstItems"
		Me.lstItems.Size = New System.Drawing.Size(210, 108)
		Me.lstItems.TabIndex = 2
		'
		'UserInput
		'
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(234, 166)
		Me.Controls.Add(Me.lstItems)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 200)
		Me.Name = "UserInput"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Select Items"
		Me.ResumeLayout(False)

	End Sub
End Class
