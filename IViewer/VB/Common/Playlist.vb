Imports System.IO

Namespace Common
	Public Module Playlist
		Private ReadOnly PlsFol As String = GetFolder()

		Public Function GetList() As String()
			Dim list As New List(Of String)
			Dim files = New DirectoryInfo(PlsFol).GetFiles("*.pls")
			For Each fil As FileInfo In files
				list.Add(Path.GetFileNameWithoutExtension(fil.Name))
			Next
			Return list.ToArray
		End Function

		Public Function Load(ByVal name) As String()
			Return File.ReadAllLines(PlsFol + name + ".pls")
		End Function

		Public Sub Save(ByVal name As String, ByVal list As List(Of String))
			File.WriteAllLines(PlsFol + name + ".pls", list.ToArray)
		End Sub

		Private Function GetFolder() As String
			Dim fol = New DirectoryInfo("Playlists").FullName
			If Not Directory.Exists(fol) Then Directory.CreateDirectory(fol)
			Return fol + "\"
		End Function

	End Module
End Namespace
