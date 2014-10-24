Imports System.Net
Imports System.IO

Public Class WebRequester

	Public Shared Sub WriteSDImageTo(ByVal input As String, ByVal style As String, ByVal path As String)
		Dim data() As Byte = System.Text.Encoding.Default.GetBytes(String.Format(App.SDImageUrl(1), input, style))
		Dim req As HttpWebRequest = HttpWebRequest.Create(App.SDImageUrl(0))
		req.Method = "POST"
		req.ContentType = "application/x-www-form-urlencoded"
		req.ContentLength = data.Length
		Dim stream As Stream = req.GetRequestStream()
		stream.Write(data, 0, data.Length)
		stream.Close()
		Dim page As String = New StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd()
		Dim pos As Integer = page.IndexOf("?img=")
		Dim imageUrl As String = page.Substring(pos + 5, page.IndexOf("&", pos) - pos)

		Dim bitmap As New Bitmap(req.GetResponse().GetResponseStream())
		bitmap.Save(path)
	End Sub

End Class
