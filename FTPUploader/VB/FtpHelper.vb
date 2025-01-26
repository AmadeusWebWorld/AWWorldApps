Imports System.Net
Imports System.IO

Public Class FtpHelper

	Public Shared ReadOnly Credentials As New NetworkCredential

	Const DIRECTORYNOTEXISTSERROR As String = "The remote server returned an error: (550) File unavailable (e.g., file not found, no access)."

	Public Shared Function CreateFTPReq(ByVal uri As String, Optional ByVal method As String = Nothing) As FtpWebRequest
		'// Create FtpWebRequest object from the Uri provided
		Dim res As FtpWebRequest = FtpWebRequest.Create(New Uri(uri))

		'// Provide the WebPermission Credentials
		res.Credentials = Credentials

		'// By default KeepAlive is true, where the control connection is not closed after a command is executed.
		res.KeepAlive = False

		If method <> Nothing Then
			res.Method = method
		End If

		Return res
	End Function

	Public Shared Function SyncFTP(ByVal relPath As String, Optional ByVal delete As Boolean = False) As String
		Dim result As String = "No Action on file: " + relPath

		Dim fileInf As New FileInfo(FtpInfo.Selected.LocalFolder + relPath)
		Dim uri As String = FtpInfo.Selected.FtpFolder + relPath.Replace("\", "/")

tryagain:
		Dim reqFTP As FtpWebRequest

		If delete Then
			reqFTP = CreateFTPReq(uri, WebRequestMethods.Ftp.DeleteFile)
			Try
				Dim response As FtpWebResponse = reqFTP.GetResponse()
				result = "Delete Status: " & response.StatusDescription.Replace(vbCrLf, "")
				response.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Delete Error")
				result = "Delete Error - " + ex.ToString
			End Try
		Else
			'// Specify the command to be executed.
			reqFTP = CreateFTPReq(uri, WebRequestMethods.Ftp.UploadFile)

			'// Specify the data transfer type.
			reqFTP.UseBinary = True

			'// Notify the server about the size of the uploaded file
			reqFTP.ContentLength = fileInf.Length

			'// The buffer size is set to 2kb
			Dim buffLength As Integer = 2048
			Dim buff(buffLength) As Byte
			Dim contentLen As Integer

			Try

				'// Opens a file stream (System.IO.FileStream) to read the file to be uploaded
				Using fs As FileStream = fileInf.OpenRead()

					'// Stream to which the file to be upload is written
					Dim strm As Stream = reqFTP.GetRequestStream()

					'// Read from the file stream 2kb at a time
					contentLen = fs.Read(buff, 0, buffLength)

					'// Till Stream content ends
					While contentLen <> 0
						'// Write Content from the file stream to the FTP Upload Stream
						strm.Write(buff, 0, contentLen)
						contentLen = fs.Read(buff, 0, buffLength)
						Application.DoEvents()
					End While

					'// Close the file stream and the Request Stream
					strm.Close()
					fs.Close()
				End Using

				result = "Upload OK"

			Catch ex As Exception
				If ex.Message = DIRECTORYNOTEXISTSERROR Then
					Dim fol As String = uri.Substring(0, uri.LastIndexOf("/"))
					CreateFTPFol(fol)
					SetMessage("Create Folder:" + fol)
					GoTo tryagain
				Else
					MessageBox.Show(ex.Message, "Upload Error")
					result = "Upload Error - " + ex.ToString
				End If
			End Try
		End If
		Return result
	End Function

	Private Shared Sub CreateFTPFol(ByVal fol As String)
		Dim reqFTP As FtpWebRequest = CreateFTPReq(fol, WebRequestMethods.Ftp.MakeDirectory)
		Try
			Using response As FtpWebResponse = CType(reqFTP.GetResponse, FtpWebResponse)
				response.Close()
			End Using
		Catch ex As Exception
			If ex.Message = DIRECTORYNOTEXISTSERROR Then
				CreateFTPFol(fol.Substring(0, fol.LastIndexOf("/")))
				Dim mkdir As FtpWebRequest = CreateFTPReq(fol, WebRequestMethods.Ftp.MakeDirectory)
				Using response As FtpWebResponse = CType(mkdir.GetResponse, FtpWebResponse)
					response.Close()
				End Using
			Else
				SetMessage("Create Folder Error - " + ex.ToString)
			End If
		End Try
	End Sub

	Public Shared Function MakeWebRequest(Optional ByVal url As String = Nothing) As String
		If (url Is Nothing) Then url = InputBox("Enter the url to make the request", "Web Request", "http://mini.cselian.com/js/fckeditor/editor/filemanager/browser/default/connectors/php/connector.php?Command=GetFoldersAndFiles&Type=Image&CurrentFolder=%2F")
		Dim req = HttpWebRequest.Create(url)
		Dim res = New StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd()
		If (Program.SilentMode) Then Return res
		File.WriteAllText("Response.txt", res)
		MessageBox.Show("Response written to : " + New FileInfo("Response.txt").FullName)
	End Function

	Public Shared Sub SetMessage(ByVal msg As String, Optional ByVal item As ListViewItem = Nothing)
		msg = String.Format("{0} - {1}", Now.ToString("HH:mm:ss"), msg)
		If Not item Is Nothing Then UpdateItem(msg, item)

		Log.AppendText(msg + vbCrLf)
		File.AppendAllText("FTP AutoSync Actions.log", Now.ToString("dd MMM yyyy ") + msg + vbCrLf)
	End Sub

	Public Shared Log As TextBox

	Private Shared Sub UpdateItem(ByVal msg As String, ByVal item As ListViewItem)
		If item IsNot Nothing Then
			If item.SubItems.Count = 1 Then item.SubItems.Add(msg) Else item.SubItems(1).Text = msg

			Dim size As String = "Not Exists"
			If File.Exists(item.Tag) Then
				Dim fil As New FileInfo(item.Tag)
				Dim kb As Double = fil.Length
				Select Case kb
					Case Is > 1024 * 1024 * 1024
						size = Decimalize(kb / 1024 / 1024 / 1024) & " Gb"
					Case Is > 1024 * 1024
						size = Decimalize(kb / 1024 / 1024) & " Mb"
					Case Is > 1024
						size = Decimalize(kb / 1024) & " Kb"
					Case Else
						size = Decimalize(kb) & " b"
				End Select
			End If
			If item.SubItems.Count = 2 Then item.SubItems.Add(size) Else item.SubItems(2).Text = size

			msg = String.Format("{0} - ({1}) - {2}", item.SubItems(1).Text, item.SubItems(0).Text, item.SubItems(2).Text)
		End If
	End Sub

	Private Shared Function Decimalize(ByVal val As Double) As String
		val = System.Convert.ToInt64(val * 100) / 100
		Return CStr(val)
	End Function

End Class
