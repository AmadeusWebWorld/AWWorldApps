Imports System.IO

Public Class FileSplitter

	Const BREAKSTARTS As String = "/*Table structure for table `"
	Const BREAKENDS As String = "` */"


	Private Sub FilePath_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilePath.KeyDown
		If e.KeyCode = Keys.Return Then

			Dim locn As String = FilePath.Text
			'If c:\file.sql, then c:\filetables\
			locn = locn.Substring(0, locn.LastIndexOf(".")) & "tables\"
			If Directory.Exists(locn) = False Then Directory.CreateDirectory(locn)

			Dim str As String = File.ReadAllText(FilePath.Text)

			'Begin from the first definition only
			str = str.Substring(str.IndexOf(BREAKSTARTS) + BREAKSTARTS.Length)
			Output.Text = ""
			Dim tables() As String = Split(str, BREAKSTARTS)
			For Each table As String In tables
				Dim ind As Integer = table.IndexOf(BREAKENDS)
				Dim op As String = table.Substring(0, ind)
				Dim fil As String = String.Concat(locn, op, ".sql")
				table = table.Substring(ind + BREAKENDS.Length)
				If File.Exists(fil) Then File.Delete(fil)
				File.WriteAllText(fil, table)
				Output.Text += fil + vbCrLf
			Next

		End If
	End Sub

End Class
