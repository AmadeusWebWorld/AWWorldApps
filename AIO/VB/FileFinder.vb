Imports System.IO
Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class FileFinder

	Private Sub FileFinder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Files.Columns.Add("File")
		Files.Columns.Add("Path")
		Files.Columns.Add("Extension")
		Files.Columns.Add("DateModified")
		Files.Columns.Add("Attrs")

	End Sub



	Private Sub Index_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Index.Click
		Using con As New SqlConnection(IndexedFileBuilder.ConnStr)
			con.Open()
			Dim cmd As New SqlCommand()
			cmd.Connection = con
			cmd.CommandType = CommandType.Text
			For Each str As String In Split(Locations.Text, vbCrLf)
				Dim fol As New DirectoryInfo(str)
				For Each fil As FileInfo In fol.GetFiles("*.jpg")
					cmd.CommandText = IndexedFileBuilder.InsertString(fil)
					cmd.ExecuteNonQuery()
				Next
			Next
		End Using
	End Sub

	Private Sub Find_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Find.Click
		Files.Items.Clear()
		Dim fils As List(Of IndexedFile) = IndexedFileBuilder.Load(Criteria.Text)
		For Each f As IndexedFile In fils
			Dim i As ListViewItem = Files.Items.Add(f.File)
			i.SubItems.AddRange(f.GetSubItems())
			i.Tag = f
		Next

	End Sub
End Class