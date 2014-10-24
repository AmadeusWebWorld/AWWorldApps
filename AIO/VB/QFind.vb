Imports System.IO

Public Class QFind

	Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setChangedStatus(OptionsTabBases, False)

		RuleMenuRefresh_Click(sender, e)

		FillAddFilesFromMenu()
	End Sub

	'highlight only rules that can be run for this file type
	Private Sub Entries_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Entries.AfterSelect
		If Entries.SelectedNode Is Nothing Then Exit Sub
		If Entries.SelectedNode.Tag <> Nothing AndAlso Entries.SelectedNode.Tag <> "" Then stbrPath.Text = Entries.SelectedNode.Tag.ToString
		If Entries.SelectedNode.Text = "Root" Then Exit Sub
		If Entries.SelectedNode.Parent.Text <> "Root" Then Exit Sub
		stbrLA.Text = String.Format("selected {1} at {0}", Now.ToLongDateString(), New FileInfo(Entries.SelectedNode.Tag).Name)
		Dim fi As New FileInfo(Entries.SelectedNode.Tag)
		Dim extn As String = ""
		If fi.Extension <> "" Then extn = fi.Extension.Substring(1) & ","
		For Each itm As ListViewItem In Rules.Items
			Dim r As Rule = CType(itm.Tag, Rule)
			If r.AppliesTo = "*" Or (r.AppliesTo + ",").Contains(extn) Then
				itm.ForeColor = Color.Black
				itm.UseItemStyleForSubItems = True
			Else
				itm.ForeColor = Color.Gray
				itm.UseItemStyleForSubItems = True
			End If
		Next
	End Sub

	Private Sub Entries_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Entries.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Right Then

			FileMenuApplyRule.Enabled = isAddedFileSelected()
			FileMenuApplyRuleRecursively.Enabled = FileMenuApplyRule.Enabled
			FileMenuClearNodes.Enabled = FileMenuApplyRule.Enabled

			Me.FileMenu.Show(e.Location + Me.Location + New Point(30, 30))

		End If
	End Sub


#Region "FileMenu commands - Add, Clear, SaveList(of files) ~//~ Apply Rules"

	Private Sub ClearNodes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuClearNodes.Click
		If isAddedFileSelected() Then Entries.SelectedNode.Nodes.Clear()
	End Sub

	Private Sub SaveFileNames(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuSaveFileNames.Click

	End Sub

	Private Sub ApplyRules(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileMenuApplyRule.Click
		If Entries.SelectedNode IsNot Nothing Then
			Dim s As New IO.FileInfo(Entries.SelectedNode.Tag)
			Dim base As String = ""
			If TryGetBaseFolder(s.FullName, base) Then

				For Each itm As ListViewItem In Rules.Items
					If itm.Checked AndAlso itm.ForeColor = Color.Black Then
						Dim r As Rule = CType(itm.Tag, Rule)
						Dim p As New Parser(r, base)
						'Entries.SelectedNode.Nodes.Clear()
						p.Parse(Entries.SelectedNode)
					End If
				Next

			Else
				MsgBox(String.Format("base path not found for: {0}", s.FullName))
			End If
		End If
	End Sub

	Private Sub ApplyRulesRecursively(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileMenuApplyRuleRecursively.Click
		If Entries.SelectedNode IsNot Nothing Then
			Dim s As New IO.FileInfo(Entries.SelectedNode.Tag)
			Dim base As String = ""
			If TryGetBaseFolder(s.FullName, base) Then

				For Each itm As ListViewItem In Rules.Items
					If itm.Checked AndAlso itm.ForeColor = Color.Black Then
						recursingRule = CType(itm.Tag, Rule)
						recursingParser = New Parser(recursingRule, base)

						recursingParser.RootNode = Entries.SelectedNode
						recursingParser.Results = Entries.SelectedNode.Tag + ":" + vbCrLf
						recursingParser.Parse(Entries.SelectedNode)	'this is to get the results at the top
						If recursingRule.ResultType = "TextList" Then
							RecursivelyApplyRules(Entries.SelectedNode)
							File.WriteAllText(recursingParser.ResultsNode.Tag, recursingParser.Results)
						End If
					End If
				Next

			Else
				MsgBox(String.Format("base path not found for: {0}", s.FullName))
			End If
		End If

	End Sub

	Private recursingRule As Rule
	Private recursingParser As Parser
	'run results in individual files will make it add a list for each child node.
	'if we want it on the base, we need to use the same parser which has the baseNode cached.

	Private Sub RecursivelyApplyRules(ByVal node As TreeNode)
		For Each nod As TreeNode In node.Nodes
			RecursivelyApplyRules(nod)
		Next
		If node.Equals(recursingParser.RootNode) = False AndAlso node.Text.StartsWith("_List_") = False Then
			recursingParser.Results += vbCrLf + node.Tag + ":" + vbCrLf
			recursingParser.Parse(node)
		End If

	End Sub


#Region "AddFiles"

	Private Sub AddFiles(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuAddFiles.Click
		AddFiles("")
	End Sub

	Private Sub AddFiles(ByVal dir As String)
		If dir <> "" Then ofd.InitialDirectory = dir
		ofd.Multiselect = True
		Dim dr As DialogResult = ofd.ShowDialog()
		If dr = Windows.Forms.DialogResult.OK Then
			AddFiles(ofd.FileNames().GetEnumerator)
		End If
	End Sub

	'from an enumerator
	Private Sub AddFiles(ByVal en As IEnumerator)
		Dim nods() As TreeNode
		While en.MoveNext
			nods = Entries.Nodes(0).Nodes.Find("", False)
			If nods.Length > 0 Then
				nods(0).EnsureVisible()
			Else
				Dim fil As New FileInfo(en.Current.ToString)
				Dim nod As TreeNode = Entries.Nodes(0).Nodes.Add(fil.FullName.ToLower, fil.Name)
				nod.Tag = fil.FullName
				nod.ToolTipText = fil.FullName
			End If
		End While
	End Sub

	'have a menu item for each base folder (this sub handles the events of those dynamically loaded items)
	Private Sub AddFilesFrom(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim t As ToolStripItem = TryCast(sender, ToolStripItem)
		If Not t Is Nothing Then AddFiles(t.Text)
	End Sub

	'Populate AddFilesFrom based on the BaseFolders (needs to reload every time that changes)
	Private Sub FillAddFilesFromMenu()
		For i As Integer = FileMenu.Items.IndexOf(FileMenuAddFiles) + 3 To FileMenu.Items.Count
			FileMenu.Items.RemoveAt(i)
		Next

		For Each lin As String In Bases.Text.Split(vbLf)
			lin = lin.Trim(vbCr)
			'Dim t As ToolStripItem = 
			FileMenu.Items.Add(lin, Nothing, AddressOf AddFilesFrom)
		Next
	End Sub

#End Region

	Private Function isAddedFileSelected() As Boolean
		If Entries.SelectedNode.Text = "Root" Then Return False
		If Entries.SelectedNode.Parent.Text <> "Root" Then Return False
		Return True
	End Function

#End Region


#Region "Parser Helper Class"

	Private Class Parser
		'Dim pi As ParserInfo
		Private rule As Rule
		Private basePath As String
		Public RootNode As TreeNode
		Public ResultsNode As TreeNode	'for storing list of recursed images etc
		Public Results As String				'textlist

		Public Sub New(ByVal r As Rule, ByVal pBasePath As String)
			rule = r
			basePath = pBasePath
			'If r.ResultType = "" Then
		End Sub

		Public Sub Parse(ByVal p As TreeNode)
			If RootNode Is Nothing Then RootNode = p
			'Entries_DoubleClick(Nothing, Nothing)
			If File.Exists(p.Tag) Then
				Dim s As String = IO.File.ReadAllText(p.Tag), pos As Integer = 0, len As Integer = 1
				Dim f As String, fi As IO.FileInfo, n As TreeNode
				pos = s.IndexOf(rule.StringMatchStartsWith)
				While pos <> -1
					pos += rule.StringMatchStartsWith.Length
					len = s.IndexOf(rule.StringMatchEndsWith, pos)
					If rule.ResultType = "File" Then
						f = getPath(s.Substring(pos, len - pos))
						fi = New FileInfo(f)
						n = p.Nodes(f)
						If n Is Nothing Then
							n = p.Nodes.Add(f, fi.Name)
							n.Tag = f
						End If
						Parse(n)
					ElseIf rule.ResultType = "TextList" Then
						If ResultsNode Is Nothing Then
							fi = New FileInfo(RootNode.Tag)
							Dim key As String = String.Format("{0}.{1}List.txt", fi.FullName, rule.Name)
							ResultsNode = RootNode.Nodes(key)
							If ResultsNode Is Nothing Then
								ResultsNode = RootNode.Nodes.Add(key, "_List_" + rule.Name)
								ResultsNode.Tag = key
							End If
						End If
						Results += s.Substring(pos, len - pos) + vbCrLf
					End If
					pos = s.IndexOf(rule.StringMatchStartsWith, pos)
					'exit sub
				End While
			Else
				'todo: missing file icon (may be directory if resulttype = directory)
			End If
			If p.Equals(rootNode) And rule.ResultType = "TextList" Then	'write the output
				File.WriteAllText(resultsNode.Tag, results)
			End If
		End Sub

		Private Function getPath(ByVal str)
			Return String.Format("{0}{1}", basePath, str).Replace("/", "\").Replace("\\", "\")
		End Function

	End Class

#End Region


#Region "Related to tabs & opening of files"

	Private Sub Tabs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabs.DoubleClick
		If Tabs.SelectedTab.Name <> "TabsOptions" Then
			Tabs.TabPages.Remove(Tabs.SelectedTab)
		End If
	End Sub

	Private Function AddTab(ByVal f As String) As TabPage
		Dim fil As New IO.FileInfo(f)
		Tabs.TabPages.Add(f.ToLower, fil.Name)
		AddTab = Tabs.TabPages(Tabs.TabPages.Count - 1)
		AddTab.Select()
		Dim tx As New TextBox()
		Tabs.TabPages(Tabs.TabPages.Count - 1).Controls.Add(tx)
		If IO.File.Exists(f) Then tx.Text = IO.File.ReadAllText(f)
		tx.Width = Tabs.SelectedTab.ClientSize.Width
		tx.Height = Tabs.SelectedTab.ClientSize.Height
		tx.ScrollBars = ScrollBars.Both
		tx.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
		tx.Multiline = True
		'AddHandler tx.KeyPress, New KeyPressEventHandler(AddressOf TabText_KeyDown)
	End Function


	'Private Sub TabText_KeyDown(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)

	Private Sub Entries_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entries.DoubleClick
		If Entries.SelectedNode IsNot Nothing Then
			Dim f As String = Entries.SelectedNode.Tag
			Dim i As Integer = Tabs.TabPages.IndexOfKey(f.ToLower)
			If i <> -1 Then
				Tabs.TabPages(i).Select()
			Else
				AddTab(f).Select()
			End If
		End If
	End Sub

	Private Sub Entries_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Entries.DragDrop
		AddFiles(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetEnumerator())
	End Sub

	Private Sub Entries_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Entries.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy
	End Sub

#End Region


#Region "Base Folders - show * when modified, Save, trygetbase"

	Private Sub Bases_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bases.TextChanged
		setChangedStatus(OptionsTabBases, True)
	End Sub

	Private Sub Bases_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Bases.KeyDown
		If e.Control And e.KeyCode = Keys.S And isStatusChanged(OptionsTabBases) Then
			'todo: save
			setChangedStatus(OptionsTabBases, False)
		End If
	End Sub

	Private Function TryGetBaseFolder(ByVal fil As String, ByRef base As String) As Boolean
		fil = fil.ToLower
		For Each baseFol As String In Bases.Text.ToLower.Split(vbCrLf)
			baseFol = baseFol.Trim()
			If fil.StartsWith(baseFol) Then base = baseFol : Return True
		Next
		Return False
	End Function

	Private changedIndicator As String = "* "

	Private Sub setChangedStatus(ByVal tab As TabPage, ByVal modified As Boolean)
		If modified AndAlso Not isStatusChanged(tab) Then
			tab.Text = changedIndicator & tab.Text
		ElseIf Not modified AndAlso isStatusChanged(tab) Then
			tab.Text = tab.Text.Substring(changedIndicator.Length)
		End If
	End Sub

	Private Function isStatusChanged(ByVal tab As TabPage) As Boolean
		Return tab.Text.StartsWith(changedIndicator)
	End Function
#End Region



#Region "Rule Menu - refresh, save, edit/update"

	Private Sub RuleMenuAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RuleMenuAdd.Click
		Dim r As New Rule()
		RuleMgr.Rules.Add(r)
		Dim itm As ListViewItem = Rules.Items.Add(r.Name)
		'itm.SubItems.Clear()
		itm.SubItems.AddRange(r.GetSubItems())
		'itm.Group = getRuleGroup(r.Group)
		itm.Tag = r
		RuleMenuSave.Enabled = True
	End Sub

	Private Sub RuleMenuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuleMenuRefresh.Click
		Rules.Items.Clear()
		RuleMgr.Load()
		For Each r As Rule In RuleMgr.Rules
			Dim itm As ListViewItem = Rules.Items.Add(r.Name)
			'itm.SubItems.Clear()
			itm.SubItems.AddRange(r.GetSubItems())
			itm.Group = getRuleGroup(r.Group)
			itm.Tag = r
		Next
		RuleMenuSave.Enabled = False
	End Sub

	Private Function getRuleGroup(ByVal name As String) As ListViewGroup
		Dim r As ListViewGroup = Rules.Groups("Rules_" + name)
		If r Is Nothing Then
			r = Rules.Groups.Add("Rules_" + name, name)
		End If
		Return r
	End Function

	Private Sub RuleMenuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuleMenuSave.Click
		RuleMgr.Save()
		RuleMenuSave.Enabled = False
	End Sub

	'functions related to the edit

	Private Sub RuleMenuMatchTypes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuleMenuMatchTypes.TextChanged

		RuleMenuStringMatchStart.Visible = (RuleMenuMatchTypes.Text = "String")
		RuleMenuStringMatchEnd.Visible = (RuleMenuMatchTypes.Text = "String")

		RuleMenuRegExMatchString.Visible = (RuleMenuMatchTypes.Text = "RegEx")

	End Sub

	Private Sub Rules_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Rules.MouseDown

		If e.Button = Windows.Forms.MouseButtons.Right And Rules.SelectedItems.Count = 1 Then
			Dim r As Rule = CType(Rules.SelectedItems(0).Tag, Rule)

			RuleMenuAppliesTo.Text = r.AppliesTo
			RuleMenuResultTypes.Text = r.ResultType
			RuleMenuMatchTypes.Text = r.MatchType
			RuleMenuRegExMatchString.Text = r.RegexMatchString
			RuleMenuStringMatchStart.Text = r.StringMatchStartsWith
			RuleMenuStringMatchEnd.Text = r.StringMatchEndsWith

			RuleMenu.Show(Rules, New Point(0, 20))
			RuleMenu.Visible = True
		End If

	End Sub

	Private Sub RuleMenuUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuleMenuUpdate.Click
		If Rules.SelectedItems.Count = 1 Then
			Dim itm As ListViewItem = Rules.SelectedItems(0)
			Dim r As Rule = CType(itm.Tag, Rule)
			r.Name = RuleMenuName.Text
			r.AppliesTo = RuleMenuAppliesTo.Text
			r.ResultType = RuleMenuResultTypes.Text
			r.MatchType = RuleMenuMatchTypes.Text
			r.RegexMatchString = RuleMenuRegExMatchString.Text
			r.StringMatchStartsWith = RuleMenuStringMatchStart.Text
			r.StringMatchEndsWith = RuleMenuStringMatchEnd.Text

			'lets not clear the other in case we want to try / switch

			itm.SubItems.Clear()
			itm.SubItems.AddRange(r.GetSubItems())
			RuleMenu.Visible = False
			RuleMenuSave.Enabled = True
		End If
	End Sub


#End Region

End Class