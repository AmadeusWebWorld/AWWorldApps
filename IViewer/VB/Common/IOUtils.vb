Imports System.IO

Namespace Common

	Public Class IOUtils

		Public Shared Sub SortDirectories(ByRef fols() As DirectoryInfo)
			Array.Sort(fols, New DIComparer)
		End Sub

		Private Class DIComparer
			Implements IComparer(Of DirectoryInfo)

			Public Function Compare(ByVal x As DirectoryInfo, ByVal y As DirectoryInfo) As Integer Implements System.Collections.Generic.IComparer(Of DirectoryInfo).Compare
				If String.Equals(x.FullName, y.FullName) Then
					Return 0
				ElseIf x.FullName > y.FullName Then
					Return 1
				Else
					Return -1
				End If
				'Value Condition Less than zero x is less than y. Zero x equals y. Greater than zero x is greater than y. 
			End Function

		End Class

		Public Shared Function GetFileSize(ByVal bytes As Long) As String
			Select Case bytes
				Case Is > 1024 * 1024 * 1024
					Return String.Format("{0:F2} GB", bytes / 1024 / 1024 / 1024)
				Case Is > 1024 * 1024
					Return String.Format("{0:F2} MB", bytes / 1024 / 1024)
				Case Is > 1024
					Return String.Format("{0:F2} KB", bytes / 1024)
				Case Else
					Return String.Format("{0:F2}  b", bytes)
			End Select
		End Function

	End Class

End Namespace

