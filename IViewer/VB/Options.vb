Imports System.Windows.Forms.Design
Imports System.IO

Public Class Options

	Public opener As Vid
	Private dirtySettings As List(Of AppConstants)

	Public Sub New(ByVal owner As Vid)
		opener = owner
		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		InitMenu()
		InitFavorites()
	End Sub

	Private Sub InitFavorites()
		Favorites.Items.Clear()
		For Each path As String In AppSettings.Favorites
			Favorites.Items.Add(path)
			Favorites.Items(Favorites.Items.Count - 1).SubItems.Add(IO.Directory.Exists(path))
		Next
	End Sub

	Private Sub SaveSettings()

	End Sub

#Region "Menu"

	Private Sub InitMenu()
		MenuItems.Items.Clear()
		For Each mnu As ToolStripMenuItem In opener.VidMenu.Items
			Dim name As String = mnu.Name.Substring(3)
			'Dim nameLen As Integer = name.Length

			For Each obj As Object In mnu.DropDownItems
				Dim mnuItm As ToolStripMenuItem = TryCast(obj, ToolStripMenuItem)
				If mnuItm IsNot Nothing AndAlso mnuItm.Name.StartsWith(name) Then
					Dim itm As ListViewItem = MenuItems.Items.Add(New ListViewItem(mnuItm.Text.Replace("&", "")))
					'mnuItm.Name.Substring(nameLen, mnuItm.Name.LastIndexOf("Mnu") - nameLen)))
					itm.SubItems.Add(name)
					itm.SubItems.Add(GetSCString(mnuItm.ShortcutKeys))
				End If
			Next
		Next
	End Sub

	Private Function GetSCString(ByVal kys As Keys) As String
		Dim result As String = ""
		result = kys.ToString
		If result.IndexOf(", ") <> -1 Then
			Dim rev() As String = result.Split(", ")
			result = ""
			For i As Integer = UBound(rev) To LBound(rev) Step -1
				result += rev(i).Trim()
				If i <> 0 Then result += " + "
			Next
		End If
		Return result
	End Function

	Private Sub SCKey_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SCKey.KeyDown
		If e.KeyCode <> Keys.Return And e.KeyCode <> Keys.ControlKey And e.KeyCode <> Keys.Alt And e.KeyCode <> Keys.ShiftKey Then
			Dim key As Keys
			'SCKey.Text = ""
			If e.Control Then key = key Or Keys.ControlKey ' SCKey.Text = "Control + "
			If e.Alt Then key = key Or Keys.Alt 'SCKey.Text += "Alt + "
			If e.Shift Then key = key Or Keys.ShiftKey 'SCKey.Text += "Shift + "
			key = key Or e.KeyCode
			SCKey.Text = GetSCString(e.KeyCode)
		End If
		e.SuppressKeyPress = True
	End Sub

	Private Sub MenuItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItems.DoubleClick
		SCKey.Visible = True
		SCKey.Top = MenuItems.Top + MenuItems.SelectedItems(0).Position.Y
		SCKey.Text = MenuItems.SelectedItems(0).SubItems(2).Text
		SCKey.Focus()
		SCKey.SelectAll()
	End Sub

#End Region

	Private Sub Favorites_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Favorites.KeyDown
		If e.KeyCode = Keys.F2 Then
			Favorites.SelectedItems(0).BeginEdit()
		ElseIf e.KeyCode = Keys.Insert Then
			Dim itm As New ListViewItem("New Favorite Folder")
			itm.SubItems.Add("")
			Favorites.Items.Add(itm)
			itm.Selected = True
			itm.BeginEdit()
		ElseIf e.KeyCode = Keys.Delete Then
			Favorites.Items.Remove(Favorites.SelectedItems(0))
		End If
	End Sub

	Private Sub Favorites_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles Favorites.AfterLabelEdit
		Favorites.Items(e.Item).SubItems(1).Text = Directory.Exists(e.Label).ToString
	End Sub

	Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
		Dim fols As New List(Of String)
		For Each itm As ListViewItem In Favorites.Items
			fols.Add(itm.Text)
		Next
		AppSettings.Favorites = fols.ToArray
		Vid.ReloadFavorites()
	End Sub
End Class