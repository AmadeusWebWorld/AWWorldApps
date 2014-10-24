Public Class LyrEd
	Private LyrInfo As LyrMgr.Info

	Public Sub ShowFor(ByVal lyr As LyrMgr.Info)
		LyrInfo = lyr
		Items.DataSource = lyr.Lines
		Items.DisplayMember = "DisplayText"
		Show()
	End Sub

	Public Sub ShowItem(ByVal item As LyrMgr.Line)
		If (CheckIfLooping(item)) Then Exit Sub
		Items.SelectedItem = item
	End Sub

	Private Sub Items_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Items.MouseDoubleClick
		JumpToLine()
	End Sub

	Private Sub Items_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Items.KeyDown
		If (e.KeyCode = Keys.Enter) Then
			JumpToLine()
		ElseIf e.KeyCode = Keys.I And e.Control Then
			IncludeRestMnu.PerformClick()
		ElseIf e.KeyCode = Keys.Insert Then
			MoveToNowMnu.PerformClick()
		ElseIf e.KeyValue = 219 Or e.KeyValue = 221 Then
			Dim neg = IIf(e.KeyValue = 221, 1, -1)
			Dim stp = IIf(e.Control, 5, 1)
			Dim by = 0.1 * neg * stp
			MoveBy(by)
		End If
	End Sub

	Private Sub JumpToLine()
		Dim itm As LyrMgr.Line = CType(Items.SelectedItem, LyrMgr.Line)
		Vid.Player.Ctlcontrols.currentPosition = itm.Start
	End Sub

	Private Sub MoveToNowMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToNowMnu.Click
		MessageBox.Show("Moving to " & Vid.Player.Ctlcontrols.currentPosition)
	End Sub

	Private Sub MoveByMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveFwdByPt1Mnu.Click, MoveBackByPt1Mnu.Click, MoveFwdByPt5Mnu.Click, MoveBackByPt5Mnu.Click
		Dim name As String = CType(sender, ToolStripMenuItem).Name.Replace("Mnu", String.Empty)
		Dim back As Boolean = name.Contains("Back")
		name = name.Substring(name.IndexOf("By") + 2)
		Dim by As Double = Double.Parse(name.Replace("Pt", ".")) * IIf(back, -1, 1)

		MoveBy(by)
	End Sub

	Private Sub MoveBy(ByVal by As Double)
		MessageBox.Show("Moving by " & by)
	End Sub

#Region "Loop"

	Private LoopedTimes, WantedTimes As Integer

	Private Sub rdoLoop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLoopEvery.CheckedChanged, rdoLoopGroup.CheckedChanged, rdoLoopSelection.CheckedChanged
		If Not CType(sender, RadioButton).Checked Then Exit Sub
		Items.SelectionMode = IIf(sender Is rdoLoopSelection, Windows.Forms.SelectionMode.MultiExtended, Windows.Forms.SelectionMode.One)
	End Sub

	''' <summary>
	''' Returns true if loop action was done and a different item was set
	''' </summary>
	Private Function CheckIfLooping(ByVal nxt As LyrMgr.Line) As Boolean
		If Not chkLoop.Checked Or Items.SelectedItem Is Nothing Then GoTo clearAndFalse
		Dim cur As LyrMgr.Line = CType(Items.SelectedItem, LyrMgr.Line)
		Dim ix As Integer = Array.IndexOf(LyrInfo.Lines, cur)
		If ix = LyrInfo.Lines.Length - 1 Then GoTo clearAndFalse
		If LyrInfo.Lines(ix + 1).GetHashCode <> nxt.GetHashCode Then Return False 'user jumped so all bets are off. 'TODO: Check if this is right

		Dim nextLine As LyrMgr.Line
		If rdoLoopEvery.Checked Then
			'todo: implement
		ElseIf rdoLoopGroup.Checked Then
			If nxt.Group = cur.Group Then Return False
			LoopedTimes += 1
			If WantedTimes = 0 Or LoopedTimes < WantedTimes Then
				nextLine = LyrInfo.FindFirst(cur.Group)
				GoTo setNext
			End If
		ElseIf rdoLoopSelection.Checked Then
			'todo: implement
		End If

		If WantedTimes <> 0 AndAlso LoopedTimes >= WantedTimes Then LoopedTimes = 0 'clear before moving out
		Exit Function

setNext:
		lblLoopNth.Text = String.Format("{0} of", LoopedTimes)
		lblLoopNth.Visible = True
		Items.SelectedItem = nextLine
		JumpToLine()
		Return True

clearAndFalse:
		LoopedTimes = 0
		lblLoopNth.Visible = False
		Return False
	End Function

	Private Sub txtLoopTimes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoopTimes.TextChanged
		If txtLoopTimes.Text.Length = 0 Then WantedTimes = 0 Else WantedTimes = Integer.Parse(txtLoopTimes.Text)
	End Sub

#End Region

End Class
