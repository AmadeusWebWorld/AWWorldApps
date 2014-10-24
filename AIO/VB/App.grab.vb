Imports System.IO

Public Class App

	'Public Shared DataFolder As String = New DirectoryInfo(".\").FullName

	Public Shared GenDataFolder

	Public Shared Function GetDataPath(ByVal relPath As String) As String
		Return Path.Combine(GenDataFolder, relPath)
	End Function

	Public Shared Function GetGenDataPath(ByVal relPath As String) As String
		Return Path.Combine(GenDataFolder, relPath)
	End Function

End Class
