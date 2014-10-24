Public Class Program

	Public Shared SilentMode As Boolean

	Shared Sub Main(ByVal str() As String)
		If str Is Nothing Or str.Length = 0 Then
			Application.Run(New ActiveSync)
			Exit Sub
		End If

		SilentMode = True
		If str.Length = 1 And str(0) = "demo" Then str = New String() {"Svn", "/req", "http://code.cselian.com/ip.php", "ip.txt", "ip.txt"}
		Dim frm = CreateDialog()
		FtpHelper.SetMessage("Command Line Params: " & String.Join(" ", str))

		FtpInfo.SetSelected(str(0))

		FtpHelper.Credentials.UserName = FtpInfo.Selected.Username
		If FtpInfo.Selected.Password = String.Empty Then FtpInfo.Selected.Password = FtpInfo.GetKey(Names.FtpPassword)
		FtpHelper.Credentials.Password = FtpInfo.Selected.Password

		FtpHelper.SetMessage(str(1) & " - " & FtpInfo.Selected.ToString, Nothing)
		For i As Integer = 1 To str.Length - 1
			If str(i) = "/req" Then
				FtpHelper.SetMessage("Save Request: " & str(i + 1) & " to: " & str(i + 2), Nothing)
				SaveRequestTo(str(i + 1), str(i + 2))
				i += 2
			Else
				FtpHelper.SetMessage("Uploading: " & str(i))
				FtpHelper.SetMessage(FtpHelper.SyncFTP(str(i)))
			End If
			Application.DoEvents()
		Next
		frm.Hide()
		FtpHelper.SetMessage("Done Command Line Close dialog to exit")
		frm.ShowDialog()
	End Sub

	Private Shared Sub SaveRequestTo(ByVal address As String, ByVal relPath As String)
        IO.File.WriteAllText(FtpInfo.Selected.LocalFolder & relPath, FtpHelper.MakeWebRequest(address))
	End Sub

	Private Shared Function CreateDialog() As Form
		Dim frm As New Form()
		frm.Height = 250 : frm.Width = 550 : frm.Text = "FTP Sync /Silent"
		frm.StartPosition = FormStartPosition.CenterScreen
		frm.KeyPreview = True

		FtpHelper.Log = New TextBox
		FtpHelper.Log.Multiline = True
		FtpHelper.Log.Dock = DockStyle.Fill

		frm.Controls.Add(FtpHelper.Log)
		frm.Show()
		Return frm
	End Function

End Class
