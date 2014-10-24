Imports System.IO

Partial Public Class Vid

#Region "Player Starts"

	Dim SelectedFile As LvwItem = Nothing
	Private Selector As SelectorType
	Private ViewPlaylistVertically As Boolean

	Private ReadOnly Property MyLvw() As ListView
		Get
			If ((Selector = SelectorType.Both AndAlso PlsStickBtn.Checked) Or Selector = SelectorType.Playlist) Then
				Return playlist
			Else
				Return fils
			End If
		End Get
	End Property

	Private ReadOnly Property SelectedItm(Optional ByVal lvw As ListView = Nothing) As LvwItem
		Get
			If lvw Is Nothing Then lvw = MyLvw
			If lvw.SelectedItems.Count >= 1 Then Return CType(lvw.SelectedItems(0), LvwItem)
			Return Nothing
		End Get
	End Property

	Private Sub TryPlayFile(Optional ByVal ctl As ListView = Nothing)
		If Not ctl Is Nothing Then 'override SelectedItm for control events
			SelectedFile = ctl.SelectedItems(0)
		ElseIf Not SelectedItm Is Nothing AndAlso Not SelectedFile Is Nothing AndAlso SelectedFile.Path = SelectedItm.Path Then
			Return
		Else
			SelectedFile = SelectedItm
		End If

		If SelectedFile Is Nothing Then UIUtils.SetAndAlign(lblDuration) : Return

		With SelectedFile
			If LyrMgr.Exists(.Path) Then
				LoadLyrics(.Path)
			Else
				DontLyrics()
			End If
			Player.URL = .Path
			StatusFile.Text = .Text
			StatusFile.ToolTipText = .Path
			Me.Text = .Text
		End With
	End Sub

	Private Sub fils_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fils.KeyDown, playlist.KeyDown
		If e.KeyCode = Keys.Enter Then TryPlayFile(CType(sender, ListView))
	End Sub

	Private Sub fils_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fils.MouseDoubleClick, playlist.MouseDoubleClick
		If e.Button = Windows.Forms.MouseButtons.Left Then TryPlayFile(CType(sender, ListView))
	End Sub

	Private Sub PlayNext_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PlayNext.Tick
		Dim lvw As ListView = MyLvw
		If lvw.SelectedItems.Count < 1 Then Exit Sub

		If Player.playState = WMPLib.WMPPlayState.wmppsPlaying AndAlso lblDuration.Text <> Player.currentMedia.durationString Then
			UIUtils.SetAndAlign(lblDuration, Player.currentMedia.durationString)
		End If

		If Not MediaStopMnu.Checked And Player.playState = WMPLib.WMPPlayState.wmppsStopped Then
			If lvw.SelectedIndices.Item(0) = lvw.Items.Count - 1 Then
				lvw.SelectedItems.Clear()
				lvw.Items(0).Selected = True
			Else
				Dim ix = lvw.SelectedIndices.Item(0) + 1
				lvw.SelectedItems.Clear()
				lvw.Items(ix).Selected = True
			End If
			TryPlayFile()
		End If
	End Sub

#End Region

	'TODO: Play from / Stick to playlist, Load / Save Playlist
#Region "Playlist"

	Private Sub Selector_CheckStateChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles SelBothBtn.Click, SelFileBtn.Click, SelPlsBtn.Click
		Dim s As SelectorType = SelectorType.Both
		If SelPlsBtn.Equals(sender) Then s = SelectorType.Playlist _
		Else If SelFileBtn.Equals(sender) Then s = SelectorType.Filelist
		SetSelector(s)
	End Sub

	Private Sub SetSelector(ByVal s As SelectorType)
		Selector = s
		Settings(AppConstants.SelectorType) = s

		SelPlsBtn.Checked = s = SelectorType.Playlist
		SelFileBtn.Checked = s = SelectorType.Filelist
		SelBothBtn.Checked = s = SelectorType.Both
		PlsStickBtn.Visible = s = SelectorType.Both
		PlsVertBtn.Visible = PlsStickBtn.Visible

		ChangingFiles = True
		fils.CheckBoxes = Selector = SelectorType.Both
		ChangingFiles = False

		If Selector = SelectorType.Playlist Then
			SplitPls.Panel1Collapsed = True
			SplitPls.Panel2Collapsed = False
		ElseIf Selector = SelectorType.Both Then
			SplitPls.Panel1Collapsed = False
			SplitPls.Panel2Collapsed = False
		Else
			SplitPls.Panel1Collapsed = False
			SplitPls.Panel2Collapsed = True
		End If
	End Sub

	Private Sub ViewPlaylistVerticalMnu_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPlaylistVerticalMnu.Click, PlsVertBtn.Click
		_doingHorzMove = True

		ViewPlaylistVertically = Not ViewPlaylistVertically
		PlsVertBtn.Checked = ViewPlaylistVertically
		SplitPls.Orientation = IIf(ViewPlaylistVertically, Orientation.Vertical, Orientation.Horizontal)

		Settings(AppConstants.PlsOrientation) = SplitViewer.Orientation
		SplitPls.SplitterDistance = Settings(IIf(SplitPls.Orientation = Orientation.Horizontal, AppConstants.PlsHorzDistance, AppConstants.PlsVertDistance))

		_doingHorzMove = False

	End Sub

	Private Sub SplitPls_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitPls.SplitterMoved
		If Not _doingHorzMove Then
			If SplitPls.Orientation = Orientation.Horizontal Then
				Settings(AppConstants.PlsHorzDistance) = e.SplitY
			Else
				Settings(AppConstants.PlsVertDistance) = e.SplitX
			End If
		End If
	End Sub

	Private Sub fils_ItemChecked(ByVal sender As Object, ByVal e As ItemCheckedEventArgs) Handles fils.ItemChecked
		If (ChangingFiles) Then Return
		Dim itm As LvwItem = e.Item
		If itm.Checked Then
			Dim newItm = itm.Clone
			itm.Tag = newItm
			playlist.Items.Add(newItm)
		Else
			Dim plsItem As LvwItem = itm.Tag
			playlist.Items.Remove(plsItem)
		End If
		PlaylistDirty = True
	End Sub

	Private Sub playlist_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles playlist.KeyDown
		If e.KeyCode = Keys.Delete And playlist.SelectedItems.Count = 1 Then
			Dim path = CType(playlist.SelectedItems(0), LvwItem).Path
			playlist.Items.Remove(playlist.SelectedItems(0))
			PlaylistDirty = True
			For Each itm As LvwItem In _allFiles
				If itm.Path = path Then
					itm.Checked = False
					Exit Sub
				End If
			Next
			For Each itm As LvwItem In fils.Items
				If itm.Path = path Then
					itm.Checked = False
					Exit Sub
				End If
			Next
			If MessageBox.Show("playlist item " & path & " not in library / current folder - must have been from a previously loaded folder. Select yes to copy path to clipboard", "Playlist Item Removed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
				Clipboard.SetText(path)
			End If
		End If
	End Sub

#End Region

#Region "Lyrics"

	Private LyrItem As LyrMgr.Info
	Private LyrLine As LyrMgr.Line

	Public Sub LoadLyrics(ByVal media As String)
		LyrItem = LyrMgr.Load(media)
		PanLyrics.Enabled = True
		lblLyrics.Visible = True
		ToolsLyricsDisplayMnu.Visible = True
	End Sub

	Public Sub DontLyrics()
		PanLyrics.Enabled = False 'timer first
		LyrItem = Nothing
		ToolsLyricsDisplayMnu.Visible = False
		UIUtils.SetAndAlign(lblLyrics)
	End Sub

	Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanLyrics.Tick
		If LyrItem.Within(LyrLine, Player.Ctlcontrols.currentPosition) Then Return 'speeds up the checking
		Dim itm = LyrItem.Find(Player.Ctlcontrols.currentPosition)
		If itm IsNot Nothing AndAlso itm.Equals(LyrLine) = False Then
			LyrLine = itm
			UIUtils.SetAndAlign(lblLyrics, LyrLine.Text)
			If LyrEd.Visible Then LyrEd.ShowItem(LyrLine)
		ElseIf itm Is Nothing Then
			UIUtils.SetAndAlign(lblLyrics, String.Empty)
		End If
	End Sub

	Private Sub plrCont_Resised(ByVal sender As Object, ByVal e As EventArgs) Handles SplitViewer.Panel1.Resize
		If lblLyrics Is Nothing Or lblLyrics.Parent Is Nothing Then Exit Sub
		If lblLyrics.Visible Then UIUtils.SetAndAlign(lblLyrics, lblLyrics.Text)
	End Sub

	Private Sub LyrFontSizeMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LyrIncreaseSizeMnu.Click, LyrDecreaseSizeMnu.Click
		Dim siz = lblLyrics.Font.Size + 2 * IIf(sender Is LyrIncreaseSizeMnu, 1, -1)
		lblLyrics.Font = New Font(lblLyrics.Font.FontFamily, siz)
		UIUtils.AlignToRight(lblLyrics)
	End Sub

	Private Sub LyrColorMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LyrColorMnu.Click
		Dim cp As New ColorDialog()
		cp.Color = lblLyrics.ForeColor
		If cp.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Return
		lblLyrics.ForeColor = cp.Color
	End Sub

	Private Sub LyrEditorMnu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LyrEditorMnu.CheckedChanged
		If (LyrEditorMnu.Checked) Then
			LyrEd.ShowFor(LyrItem)
		Else
			LyrEd.Close()
		End If
	End Sub

#End Region

End Class
