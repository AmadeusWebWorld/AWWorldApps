Imports System.IO

Partial Public Class Vid

#Region "Init / InitLvw & LvwItemType"

	Private Sub Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Icon = Cselian.IViewer.My.Resources.iviewer
		'Set up the UI
		SetLoadStatus("Loading Application State", 200, True)
		SetView(View.Details)

		SetLoadStatus("Loading Tree", 600)
		LoadTree()

		SetLoadStatus("Loading Folder View", 350)

		If Settings(AppConstants.FolOrientation) <> Orientation.Horizontal Then ViewHorzToggle(sender, e) 'it will toggle to false

		ViewPlaylistVertically = Settings(AppConstants.PlsOrientation) = Orientation.Horizontal	' set the not since toggling will happen in handler
		ViewPlaylistVerticalMnu_Clicked(Nothing, Nothing)

		SetSelector(Settings(AppConstants.SelectorType))
		ToolsLyricsDisplayMnu.DropDown = LyrMenu

		InitLvw(fils)
		InitLvw(playlist)
		playlist.Columns.Add("Folder")
		playlist.Columns(4).Width = Settings(AppConstants.FilColWidthFolder)

		'TODO: sorter for playlist
		fils.ListViewItemSorter = sorter

		SetLoadStatus("Loading Files", 800)
		'fols.SelectedNode = fols.Nodes(0)	' This will invoke fols_AfterSelect

		If Settings(AppConstants.FolOrientation) = "1" Then ViewHorzToggle(sender, e)
		If Settings(AppConstants.FolVisibility) = "False" Then ViewFolsToggle(sender, e)
		SetLoadStatus(Nothing)

		AddHandler Application.ThreadException, AddressOf OnError
	End Sub

	Private Sub InitLvw(ByRef lvw As ListView)
		lvw.Columns.Clear()

		lvw.Columns.Add("Name")
		lvw.Columns(0).Width = Settings(AppConstants.FilColWidthName)

		lvw.Columns.Add("Size")
		lvw.Columns(1).Width = Settings(AppConstants.FilColWidthSize)
		lvw.Columns(1).TextAlign = HorizontalAlignment.Right

		lvw.Columns.Add("Ext")
		lvw.Columns(2).Width = Settings(AppConstants.FilColWidthExt)

		lvw.Columns.Add("Modified")
		lvw.Columns(3).Width = Settings(AppConstants.FilColWidthModified)
	End Sub

	Private Sub OnError(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
		IO.File.AppendAllText("IViewer Errors.log", String.Concat(Now.ToString(), vbCrLf, e.Exception.ToString, vbCrLf, vbCrLf))
	End Sub

	Dim _allFiles() As LvwItem
	Dim _itmType As LvwItem.ItemType = LvwItem.ItemType.SingleFolder

	Private Property LvwItemType() As LvwItem.ItemType
		Get
			Return _itmType
		End Get
		Set(ByVal value As LvwItem.ItemType)
			If _itmType <> value Then
				Select Case value
					Case LvwItem.ItemType.Mixed
						fils.Columns.Add("Folder", "Folder").Width = Settings(AppConstants.FilColWidthFolder)
					Case LvwItem.ItemType.SingleFolder
						fils.Columns.RemoveByKey("Folder")
				End Select
				_itmType = value
			End If
		End Set
	End Property

#End Region

#Region "Tree & Folder Load"

	Dim navigatingToFol, loading As Boolean
	Dim PlsNode As TreeNode
	Dim Search As SearchMode

	'Refresh for LoadTree
	Private Sub fols_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fols.KeyDown
		If e.KeyCode = Keys.F5 Then LoadTree()
	End Sub

	Private Sub LoadTree()
		fols.Nodes.Clear()

		loading = True
		Dim folRoot As TreeNode = fols.Nodes.Add("Root")
		folRoot.ImageKey = "Root" : folRoot.SelectedImageKey = folRoot.ImageKey

		PlsNode = fols.Nodes.Add("Playlists")
		PlsNode.ImageKey = "fave"
		ReloadPlaylists()

		SetLoadStatus("Loading Media Library")
		ReloadMediaLibrary()

		Dim drvNode As TreeNode
		For Each drv As DriveInfo In DriveInfo.GetDrives()
			If Not drv.IsReady Then
				drvNode = folRoot.Nodes.Add(drv.RootDirectory.FullName, drv.Name)
			Else
				drvNode = folRoot.Nodes.Add(drv.RootDirectory.FullName, String.Format("{0} ({1})", drv.Name, drv.VolumeLabel))
				Dim di As New DirectoryInfo(drv.RootDirectory.FullName)
				If di.GetDirectories().Length > 0 Then drvNode.Nodes.Add("")
			End If
			drvNode.Tag = drv.RootDirectory.FullName
			drvNode.ImageKey = "Drive" : drvNode.SelectedImageKey = drvNode.ImageKey
		Next
		ReloadFavorites()
	End Sub

	Public Sub ReloadFavorites()
		Do While fols.Nodes.Count > 2
			fols.Nodes.RemoveAt(2)
		Loop

		For Each path As String In AppSettings.Favorites
			Dim fol As New DirectoryInfo(path)
			AddFol(fol, fols.Nodes)
		Next
	End Sub

	'if selectednode text = "", expand & addfol
	Private Sub fols_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles fols.BeforeExpand
		If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Text = "" Then
			e.Node.Nodes.Clear()
			Dim subFols() As DirectoryInfo = New DirectoryInfo(e.Node.Tag).GetDirectories()
			Common.IOUtils.SortDirectories(subFols)
			For Each fol As DirectoryInfo In subFols
				AddFol(fol, e.Node.Nodes)
			Next
		End If
	End Sub

	Private Sub AddFol(ByVal fol As DirectoryInfo, ByVal nodes As TreeNodeCollection)
		Dim folNode As TreeNode = nodes.Add(fol.FullName, fol.Name)
		folNode.ImageKey = "fol" : folNode.SelectedImageKey = "cur"
		If fol.Exists AndAlso fol.GetDirectories().Length > 0 Then folNode.Nodes.Add("")
		folNode.Tag = fol.FullName
	End Sub



	'LoadFolder into filelist
	Private Sub fols_AfterSelect(ByVal sender As Object, ByVal f As TreeViewEventArgs) Handles fols.AfterSelect
		If fols.SelectedNode.GetHashCode = PlsNode.GetHashCode Or _
		 (fols.SelectedNode.Parent IsNot Nothing AndAlso fols.SelectedNode.Parent.GetHashCode = PlsNode.GetHashCode) Then Exit Sub

		If navigatingToFol Or fols.SelectedNode Is Nothing Then Exit Sub
		If loading Then loading = False : Exit Sub

		fils.Items.Clear()
		If fols.SelectedNode.Tag Is Nothing Then 'Root
			LvwItemType = LvwItem.ItemType.Mixed
			ChangingFiles = True
			fils.Items.AddRange(_allFiles)
			ChangingFiles = False
			StatusSearch.Text = String.Format("All Media Files ({0})", _allFiles.Length)
		Else
			LvwItemType = LvwItem.ItemType.SingleFolder
			Dim fol As New DirectoryInfo(fols.SelectedNode.Tag)
			If Not fol.Exists Then Exit Sub
			Dim filter As String = IIf(String.IsNullOrEmpty(FolderFilter.Text), "*", "*" + FolderFilter.Text + "*")
			ChangingFiles = True
			For Each fi As FileInfo In fol.GetFiles(filter, SearchOption.TopDirectoryOnly)
				fils.Items.Add(New LvwItem(fi, fils, LvwItemType))
			Next
			ChangingFiles = False
			StatusSearch.Text = String.Format("Folder Files ({0})", fils.Items.Count)
		End If

	End Sub

	'open playlist
	Private Sub fols_NodeDoubleClick(ByVal sender As Object, ByVal f As TreeNodeMouseClickEventArgs) Handles fols.NodeMouseDoubleClick
		If fols.SelectedNode.Parent IsNot Nothing AndAlso fols.SelectedNode.Parent.GetHashCode = PlsNode.GetHashCode Then
			LoadPlaylist(fols.SelectedNode.Text)
		End If
	End Sub

	Private Sub ReloadMediaLibrary()
		Try
			ReDim _allFiles(MediaLibrary.AllFiles.Length - 1)
			Dim ind As Integer = 0
			For Each fil As String In MediaLibrary.AllFiles
				_allFiles(ind) = New LvwItem(New FileInfo(fil), fils, LvwItem.ItemType.Mixed) 'because in folder load, we dont use _allFiles
				ind += 1
			Next
		Catch e As Exception
			IO.File.AppendAllText("IViewer Errors.log", String.Concat(Now.ToString(), vbCrLf, e.ToString, vbCrLf, vbCrLf))
		End Try
	End Sub

#End Region

#Region "Playlists - Load / Save"

	Private PlaylistName As String
	Private PlaylistDirty, ChangingFiles As Boolean

	Private Sub ReloadPlaylists()
		PlsNode.Nodes.Clear()

		For Each name As String In Common.Playlist.GetList()
			Dim nod = PlsNode.Nodes.Add(name)
			nod.ImageKey = "fave"
		Next
	End Sub

	Private Sub LoadPlaylist(ByVal name As String)
		CheckPlaylistNotDirty()
		playlist.Items.Clear()

		PlaylistName = name
		Dim items = Common.Playlist.Load(name)
		For Each file As String In items
			Dim itm As New LvwItem(New FileInfo(file), playlist, LvwItem.ItemType.Mixed)
			playlist.Items.Add(itm)
		Next
		PlaylistDirty = False
	End Sub

	Private Sub SavePlaylist(Optional ByVal newName As String = Nothing)
		Dim changed = False
		If PlaylistName = Nothing Then
			PlaylistName = InputBox("Enter a name for the playlist", "Save Playlist", newName)
			If PlaylistName = Nothing Then Return
			changed = True
		End If

		Dim list As New List(Of String)
		For Each itm As LvwItem In playlist.Items
			list.Add(itm.Path)
		Next

		Common.Playlist.Save(PlaylistName, list)
		If changed Then ReloadPlaylists()
	End Sub

	Private Sub CheckPlaylistNotDirty()
		If Not PlaylistDirty Then Exit Sub
		If MessageBox.Show("Save Playlist first", "Save Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.OK Then
			SavePlaylist()
		End If
	End Sub

#End Region

#Region "FileView Column Sorting"

	Dim sorter As New LvwItem.Sorter()

	Private Sub fils_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles fils.ColumnClick
		' Determine if the clicked column is already the column that is being sorted.
		If (e.Column = sorter.SortColumn) Then
			' Reverse the current sort direction for this column.
			sorter.Order = 3 - sorter.Order	'Asc, Desc are 1,2
		Else
			' Set the column number that is to be sorted; default to ascending.
			sorter.SortColumn = e.Column
			sorter.Order = SortOrder.Ascending
		End If

		'sorter.CompareCount = 0 : Dim tm = DateTime.Now
		fils.Sort()
		'If sorter.SortColumn = 3 Then IO.File.AppendAllText("datetime stats.log", String.Format("{0}	{1} ({2} files)", tm, DateTime.Now.Subtract(tm), fils.Items.Count) & vbCrLf)
	End Sub

#End Region

#Region "Filter"

	Private Sub SearchFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchFilter.TextChanged, SearchModes.SelectedIndexChanged
		If SearchFilter.Text.Length < 3 Then Exit Sub

		Search = SearchModes.SelectedIndex
		LvwItemType = LvwItem.ItemType.Mixed
		ChangingFiles = True
		fils.Items.Clear()
		For Each itm As LvwItem In _allFiles
			If (IIf(Search = SearchMode.FullPath, itm.Path, IIf(Search = SearchMode.Folder, itm.Folder, itm.Text))).IndexOf(SearchFilter.Text, System.StringComparison.InvariantCultureIgnoreCase) <> -1 Then fils.Items.Add(itm)
		Next
		ChangingFiles = False
		StatusSearch.Text = String.Format("{0} Search ({1}/{2})", SearchModes.Text, fils.Items.Count, _allFiles.Length)
	End Sub

	Private Sub FolderFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderFilter.TextChanged
		If fols.SelectedNode Is Nothing Or fols.SelectedNode.Tag Is Nothing Then Exit Sub
		fols_AfterSelect(sender, Nothing)
	End Sub

#End Region

#Region "Rest of Vid IO"

	Sub fols_Click(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles fols.MouseDown
		If (e.Button = Windows.Forms.MouseButtons.Right) Then
			Dim hit As TreeViewHitTestInfo = fols.HitTest(e.Location)
			If Not hit.Node Is Nothing Then
				fols.SelectedNode = hit.Node
				TreeMenu.Show(fols, e.Location)
			End If
		End If
	End Sub

	Sub fils_Click(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles fils.MouseDown
		If (e.Button = Windows.Forms.MouseButtons.Right) Then
			Dim hit As ListViewHitTestInfo = fils.HitTest(e.Location.X, e.Location.Y)
			If Not hit.Item Is Nothing Then
				fils.SelectedItems.Clear()
				hit.Item.Selected = True
				FileItemUncheckAll.Visible = Selector = SelectorType.Both
				FileItemCheckAll.Visible = FileItemUncheckAll.Visible
				FileMenu.Show(fils, e.Location)
			End If
		End If
	End Sub

	Private ReadOnly Property IsValidFolder() As Boolean
		Get
			Return Not fols.SelectedNode.Tag Is Nothing
		End Get
	End Property

	Private Sub TreeMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeItemOpen.Click, TreeItemRefresh.Click
		If sender Is TreeItemOpen Then
			If IsValidFolder Then Process.Start(fols.SelectedNode.Tag)
		Else
			If IsValidFolder Then
				fols.SelectedNode.Nodes.Clear()
				Dim fol As New DirectoryInfo(fols.SelectedNode.Tag)
				If fol.Exists AndAlso fol.GetDirectories().Length > 0 Then
					fols.SelectedNode.Nodes.Add("")
					fols_BeforeExpand(Nothing, New TreeViewCancelEventArgs(fols.SelectedNode, False, TreeViewAction.Expand))
				End If
			End If
		End If
	End Sub

	Private Sub FileItemOpenContainingFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileItemOpenContainingFolder.Click
		Dim itm As LvwItem = SelectedItm(fils)
		Process.Start("explorer.exe", itm.Folder) 'TODO: make it go to selection
	End Sub

	Private Sub FileItemGoToFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileItemGoToFolder.Click
		Dim itm As LvwItem = SelectedItm(fils)
		If itm Is Nothing Then Exit Sub

		Dim searchIn As TreeNodeCollection = fols.Nodes
		Dim root As TreeNode = Nothing
search:
		For Each node As TreeNode In searchIn
			If node.Parent Is Nothing AndAlso node.Index < 2 Then Continue For
			If itm.Folder.StartsWith(CType(node.Tag, String)) Then
				root = node
				Exit For
			End If
		Next
		If root Is Nothing Then
			searchIn = fols.Nodes(0).Nodes
			GoTo search
		End If

check:
		navigatingToFol = True
		fols.SelectedNode = root
		Dim cur As String = CType(root.Tag, String)
		If itm.Folder = cur Then
			navigatingToFol = False
			fols_AfterSelect(Nothing, Nothing)
			fils.SelectedItems.Clear()
			For Each file As LvwItem In fils.Items
				If file.Path = itm.Path Then
					file.Selected = True
					Return
				End If
			Next
			Return
		End If


		If root.Nodes.Count = 1 AndAlso root.Nodes(0).Text = "" Then
			fols_BeforeExpand(Nothing, New TreeViewCancelEventArgs(root, False, TreeViewAction.Expand))
		End If

		For Each fol As TreeNode In root.Nodes
			cur = CType(fol.Tag, String)
			If itm.Folder.StartsWith(cur & "\") Or itm.Folder = cur Then 'need to use \ else substring problem
				root = fol
				Exit For
			End If
		Next

		GoTo check
	End Sub

	Private Sub FileMenuCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileItemCheckAll.Click, FileItemUncheckAll.Click
		Dim check = sender Is FileItemCheckAll
		For Each item As ListViewItem In fils.Items
			item.Checked = check
		Next
	End Sub

#End Region

End Class
