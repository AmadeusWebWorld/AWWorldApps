Public NotInheritable Class Splash

	Private Sub Splash_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
		Dim v As Version = AppSettings.GetVersion()
		BackgroundImage = My.Resources.splash
		lblMsg.Text = String.Format(lblMsg.Text, DateTime.Today.Year)

		lblVersion.Text = String.Format("version: {0}.{1} build: {2}", v.Major, v.Minor, v.Revision)
	End Sub

	Private Sub link_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblMail.LinkClicked, lblSite.LinkClicked
		Clipboard.SetText(CType(sender, LinkLabel).Text)
		MessageBox.Show("Copied to clipboard", "IViewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub Splash_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.Escape Then Close()
	End Sub

	Private Sub Splash_MouseDown(ByVal sender As System.Object, ByVal e As EventArgs) Handles Me.MouseDown
		Close()
	End Sub

	Public Property SplashLabel() As String
		Get
			Return lblMsg.Text
		End Get
		Set(ByVal value As String)
			lblMsg.Text = value
			Application.DoEvents()
		End Set
	End Property
End Class
