Imports System.Text
Imports System.IO

Public Class RuleMgr

	Public Shared Rules As New List(Of Rule)

	Private Shared savedFile As String = App.GetDataPath("Rules.ini")

	Public Shared Sub Load()
		If File.Exists(savedFile) = False Then Exit Sub
		Rules = New List(Of Rule)
		Dim lins As String = File.ReadAllText(savedFile)
		For Each lin As String In lins.Split(vbLf)
			lin = lin.Trim(vbCr)
			If lin.IndexOf("|") <> -1 Then Rules.Add(New Rule(lin))
		Next

	End Sub

	Public Shared Sub Save()
		Dim sb As New StringBuilder

		For Each r As Rule In Rules
			sb.AppendLine(r.ToString)
		Next
		If File.Exists(savedFile) Then File.Delete(savedFile)
		File.WriteAllText(savedFile, sb.ToString)
	End Sub

End Class