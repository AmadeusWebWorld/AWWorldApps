Imports System.IO

Partial Public Class Vid

	Dim _splash As Splash

	Private Sub SetLoadStatus(ByVal msg As String, Optional ByVal sleep As Long = 1000, Optional ByVal load As Boolean = False)
		If _splash Is Nothing AndAlso load = False Then Exit Sub

		If _splash Is Nothing Then
			_splash = New Splash
			_splash.Show(Me)
			Application.DoEvents()
		End If

		If String.IsNullOrEmpty(msg) Then
			_splash.Close()
		Else
			_splash.SplashLabel = msg
			If sleep > 0 Then Threading.Thread.Sleep(sleep)
		End If

	End Sub

#Region "Menu: File"

	Private Sub PlsNewMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlsNewMnu.Click
		CheckPlaylistNotDirty()
		playlist.Items.Clear()
		PlaylistName = Nothing
		PlaylistDirty = False
	End Sub

	Private Sub PlsOpenMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlsOpenMnu.Click
		If MessageBox.Show("To open, double click an icon in the Playlists node in the tree. Did you mean to reload playlists?", _
		 "Open Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return
		ReloadPlaylists()
	End Sub

	Private Sub PlsSaveMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlsSaveMnu.Click
		SavePlaylist()
	End Sub

	Private Sub PlsSaveAsMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlsSaveAsMnu.Click
		Dim orig = PlaylistName
		PlaylistName = Nothing
		SavePlaylist(orig)
		If PlaylistName Is Nothing Then PlaylistName = orig 'user cancelled
	End Sub

	Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExitMnu.Click
		'Exit the application
		Global.System.Windows.Forms.Application.Exit()
	End Sub

#End Region

#Region "Menu: View Toggle, Return etc"

	'Change whether or not the folders pane is visible
	Private Sub ViewFolsToggle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFolsMnu.Click, ViewFolsBtn.Click
		ViewFolsMnu.Checked = Not ViewFolsMnu.Checked
		ViewFolsBtn.Checked = ViewFolsMnu.Checked

		' Collapse the Panel containing the TreeView.
		Me.SplitFol.Panel1Collapsed = Not ViewFolsMnu.Checked
		Me.Settings(AppConstants.FolVisibility) = ViewFolsMnu.Checked
	End Sub

	Private Sub ViewToolBarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolBarMnu.Click
		ViewToolBarMnu.Checked = Not ViewToolBarMnu.Checked
		ToolBar.Visible = ViewToolBarMnu.Checked
	End Sub

	Private Sub ViewStatusBarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStatusBarMnu.Click
		ViewStatusBarMnu.Checked = Not ViewStatusBarMnu.Checked
		StatusBar.Visible = ViewStatusBarMnu.Checked
	End Sub

	Private Sub ViewReturnMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewReturnMnu.Click
		If SelectedFile IsNot Nothing Then
			SelectedFile.Selected = True
			SelectedFile.EnsureVisible()
			For Each itm As LvwItem In playlist.Items
				If itm.Path = SelectedFile.Path Then
					itm.Selected = True
					itm.EnsureVisible()
					Exit Sub
				End If
			Next
			If playlist.SelectedItems.Count = 1 Then playlist.SelectedItems(0).Selected = False
		End If
	End Sub

#End Region

#Region "Horizontal"

	Dim _doingHorzMove As Boolean = True

	Private Sub ViewHorzToggle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHorzMnu.Click, ViewHorzBtn.Click
		_doingHorzMove = True

		ViewHorzMnu.Checked = Not ViewHorzMnu.Checked
		ViewHorzBtn.Checked = ViewHorzMnu.Checked
		ViewHorzBtn.Image = BarIcons.Images(IIf(ViewHorzMnu.Checked, "h", "v"))

		SplitViewer.Orientation = 1 - SplitViewer.Orientation	'IIf(ViewHorizontalMnu.Checked, Orientation.Horizontal, Orientation.Vertical)
		With SplitViewer
			.Panel1.Controls.Add(.Panel2.Controls(0))
			.Panel2.Controls.Add(.Panel1.Controls(0))
		End With
		SplitFol.Orientation = 1 - SplitViewer.Orientation

		'restore saved distance
		Settings(AppConstants.FolOrientation) = SplitViewer.Orientation
		SplitFol.SplitterDistance = Settings(IIf(SplitFol.Orientation = Orientation.Horizontal, AppConstants.FolHorzDistance, AppConstants.FolVertDistance))

		_doingHorzMove = False
	End Sub

	Private Sub SplitFol_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitFol.SplitterMoved
		If Not _doingHorzMove Then
			If SplitFol.Orientation = Orientation.Horizontal Then
				Settings(AppConstants.FolHorzDistance) = e.SplitY
			Else
				Settings(AppConstants.FolVertDistance) = e.SplitX
			End If
		End If
	End Sub

#End Region

#Region "Menu: LView"

	Private Sub LViewMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LViewList.Click, LViewDetails.Click, LViewLarge.Click, LViewSmall.Click, LViewTile.Click
		SetView(CInt(CType(sender, ToolStripMenuItem).Tag))
	End Sub

	Private Sub SetView(ByVal vw As View)
		'Debug.Fail("Unexpected View")

		'Check the appropriate menu item and deselect all others under the Views menu
		For Each MenuItem As ToolStripMenuItem In LViewButtons.DropDownItems
			If MenuItem.Tag = vw Then
				MenuItem.Checked = True
			Else
				MenuItem.Checked = False
			End If
		Next

		'Finally, set the view requested
		fils.CheckBoxes = False
		fils.View = vw
		fils.CheckBoxes = playlist.Visible And fils.View <> View.Tile
		playlist.View = vw
	End Sub

#End Region

#Region "Menu: Media"

	Private Sub MediaVolumeMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaVolumeUpMnu.Click, MediaVolumeDownMnu.Click
		Player.settings.volume += CInt(CType(sender, ToolStripMenuItem).Tag) * 5
	End Sub

	Private Sub MediaVolumeMuteMnu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MediaVolumeMuteMnu.Click
		Player.settings.mute = Not Player.settings.mute
		MediaVolumeMuteMnu.Checked = Player.settings.mute
	End Sub

	Private Sub MediaRestartMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaRestartMnu.Click
		If SelectedFile IsNot Nothing Then Player.URL = SelectedFile.Path
	End Sub


	'Dim _int As Integer = 1
	'Private Sub MediaPanMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaPanLeftMnu.Click, MediaPanRightMnu.Click
	'	Player.DoVerb(_int)
	'	_int += 1
	'End Sub

#End Region

#Region "Menu: Tools / Help"

	Private Sub ToolsOptionsMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsOptionsMnu.Click
		Dim o As New Options(Me)
		o.ShowDialog()
	End Sub

	Private Sub ToolsInvalidFileLinksMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsInvalidFileLinksMnu.Click
		MediaLibrary.Refresh()
		Dim sb As New System.Text.StringBuilder
		For Each fil As String In MediaLibrary.AllFiles
			If File.Exists(fil) = False Then
				sb.AppendLine(fil)
			End If
		Next
		Dim op As New FileInfo(AppSettings.LogInvalidFiles)
		If op.Exists Then
			If op.IsReadOnly Then op.IsReadOnly = False
			op.Delete()
		End If
		IO.File.WriteAllText(op.FullName, sb.ToString)
		Shell("notepad.exe """ & op.FullName & """", AppWinStyle.MaximizedFocus)
	End Sub

	Private Sub ToolsReloadMediaLibraryMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsReloadMediaLibraryMnu.Click
		fils.Items.Clear()
		ReloadMediaLibrary()
	End Sub

	Private Sub ToolsSaveMediaLibraryMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsSaveMediaLibraryMnu.Click
		If Not MediaLibrary.SaveLibrary() Then Exit Sub
		ToolsReloadMediaLibraryMnu.PerformClick()
	End Sub

	Private Sub HelpReadmeMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpReadmeMnu.Click
		Dim fil = Path.Combine(Environment.CurrentDirectory.Replace("bin\Debug", String.Empty), "Readme.txt")
		Process.Start(fil)
	End Sub

	Private Sub HelpAboutMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAboutMnu.Click
		Dim f As New Splash
		f.ShowDialog()
	End Sub

#End Region

#Region "Rest of Vid"

	Private Sub Splitter_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SplitFol.PreviewKeyDown, SplitViewer.PreviewKeyDown, SplitPls.PreviewKeyDown
		If Not e.KeyCode = Keys.PageDown AndAlso Not e.KeyCode = Keys.PageUp Then Exit Sub
		Dim spl As SplitContainer = CType(sender, SplitContainer)
		If e.KeyCode = Keys.PageUp Then
			If spl.Panel2Collapsed Then spl.Panel2Collapsed = False Else spl.Panel1Collapsed = True
		Else
			If spl.Panel1Collapsed Then spl.Panel1Collapsed = False Else spl.Panel2Collapsed = True
		End If

	End Sub

	Private Sub FileItemWindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileItemWindows.Click
		'Return
		Dim itm As LvwItem = SelectedItm(fils)
		'Dim sh As New AndreasJohansson.Win32.Shell.ShellContextMenu()

		Dim list As New List(Of FileInfo)
		list.Add(New FileInfo(itm.Path))
		'sh.ShowContextMenu(IntPtr.Zero, list.ToArray, itm.Position)
	End Sub

	Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
		If SysUtils.IsKey(keyData, Keys.Right) Or SysUtils.IsKey(keyData, Keys.Left) Then
			Dim dirn As Integer = IIf((keyData And Keys.Left) = Keys.Left, -1, 1)
			Dim stp As Integer
			If SysUtils.IsKey(keyData, Keys.Control) Then stp = 5 Else If SysUtils.IsKey(keyData, Keys.Shift) Then stp = 1 Else If SysUtils.IsKey(keyData, Keys.Alt) Then stp = 30 Else GoTo baseev

			Dim pos = Player.Ctlcontrols.currentPosition + dirn * stp
			Player.Ctlcontrols.currentPosition = pos
		End If
baseev:
		Return MyBase.ProcessCmdKey(msg, keyData)
	End Function

	Private Sub ToolsViewOrganizerMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsViewOrganizerMnu.Click
		Dim dlg As UserInput = New UserInput(AppSettings.Favorites, Nothing, True)
		If dlg.ShowDialog() <> DialogResult.OK Then Exit Sub
		Dim fol As String = dlg.SelectedItems(0)
		Dim o As Org = New Org(fol)
		o.ShowDialog()
	End Sub

#End Region

End Class
