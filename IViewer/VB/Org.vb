Imports System.IO

Public Class Org
	Private ReadOnly Folder As String

	Public Sub New()
		Me.New("D:\Imran\M")
	End Sub

	Public Sub New(ByVal fol As String)
		InitializeComponent()

		lblFol.Text = fol
		Folder = fol
		btnRefresh_Click(Nothing, Nothing)
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		tvwItems.Nodes.Clear()
		Add(tvwItems.Nodes, Folder, New DirectoryInfo(Folder).GetDirectories(), 1)
		tvwItems.ExpandAll()
	End Sub

	Private Sub Add(ByVal nodes As TreeNodeCollection, ByVal fol As String, ByVal subDirs As DirectoryInfo(), ByVal level As Integer)
		Dim n As TreeNode = nodes.Add(fol)
		'If level > 2 Then Exit Sub

		Dim empties As New List(Of String)

		For Each sFol As DirectoryInfo In subDirs
			Dim dirs As DirectoryInfo() = sFol.GetDirectories()
			If (dirs.Length = 0 Or fol = "Floyd" Or fol = "Eagles") Then empties.Add(sFol.Name) : Continue For
			Add(n.Nodes, sFol.Name, dirs, level + 1)
		Next

		If empties.Count > 0 Then
			Dim name = String.Join(" / ", empties.ToArray())
			n.Nodes.Insert(0, name)
		End If
	End Sub

End Class