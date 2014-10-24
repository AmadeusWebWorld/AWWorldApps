Imports System.IO
Imports System.Text

Namespace Common

	Public Class MediaLibrary

		Private Shared files As New List(Of String)

		Shared Sub New()
			Refresh()
		End Sub

		Shared Function SaveLibrary() As Boolean
			files.Clear()
			Dim dlg As UserInput = New UserInput(AppSettings.Favorites, Nothing, True)
			If dlg.ShowDialog() <> DialogResult.OK Then Return False
			Dim fols = dlg.SelectedItems
			For Each path As String In fols
				Dim fol As New DirectoryInfo(path)
				If fol.Exists Then
					For Each f As FileInfo In fol.GetFiles("*.mp3", SearchOption.AllDirectories)
						files.Add(f.FullName)
					Next
				End If
			Next
			File.WriteAllLines(AppSettings.LegacyLibrary, files.ToArray())
			files.Sort()
			Return True
		End Function

		Shared Sub Refresh()
			files.Clear()

			If Not File.Exists(AppSettings.LegacyLibrary) Then Return

			For Each lin As String In File.ReadAllLines(AppSettings.LegacyLibrary)
				If Not String.IsNullOrEmpty(lin) Then files.Add(lin)
			Next

			files.Sort()
		End Sub

		Public Shared ReadOnly Property AllFiles() As String()
			Get
				Return files.ToArray
			End Get
		End Property

	End Class

End Namespace
