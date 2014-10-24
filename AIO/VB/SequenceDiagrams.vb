Imports System.IO
Imports Microsoft.VisualBasic

Public Class SequenceDiagrams

	Dim WithEvents TemplatePasser As HtmlElement
	Private diagrams As New DirectoryInfo("Diagrams")

	Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
		MyBase.OnLoad(e)
		'SDExplorer.SelectedNode = SDExplorer.Nodes.Add("activate")
		SDTemplates.Navigate(App.SDTemplatesUrl)
		SDExplorer.PathSeparator = String.Empty
		ReloadTree(SDExplorer.Nodes, diagrams)
	End Sub

	'Private Sub TemplateNavigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs) Handles SDTemplates.Navigated
	Private Sub TemplateNavigated(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs) Handles SDTemplates.DocumentCompleted
		If SDTemplates.DocumentText.Length = 3725 Or SDTemplates.DocumentText.Length < 100 Or SDTemplates.DocumentText.Contains("brwctl") Then Return
		Dim newFn As String = "document.getElementsByTagName('img')[0].focus();document.getElementById('brwctl').innerHTML = " & App.SDTemplateReplaces(1) & ";document.getElementById('brwctl').focus();"
		Dim url As String = "http://" & SDTemplates.Document.Url.Host & "/"
		Dim text As String = SDTemplates.DocumentText.Replace("window.parent.addText(text);", newFn).Replace("<body>", "<body><pre id='brwctl'></pre>").Replace("src='", "src='" & url)
		SDTemplates.DocumentText = text
		TemplatePasser = SDTemplates.Document.GetElementById("brwctl")
	End Sub

	Private Sub TemplateClicked(ByVal sender As Object, ByVal e As HtmlElementEventArgs) Handles TemplatePasser.GotFocus
		DiagramInput.SelectedText = TemplatePasser.InnerHtml
	End Sub

	Private Sub MenuClick(ByVal sender As Object, ByVal e As EventArgs) Handles MnuAddFolder.Click, MnuAddDiagram.Click, MnuDelete.Click, MnuGenerate.Click, MnuSave.Click, MnuToggleTemplates.Click, MnuShowDiagrams.Click, MnuReloadAll.Click
		If sender Is MnuAddDiagram Then
			Dim dir As DirectoryInfo = Nothing
			Dim nodes As TreeNodeCollection = GetNearestFolderAncestor(dir)
			Dim name As String = Interaction.InputBox("New File")
			If Not String.IsNullOrEmpty(name) Then
				File.WriteAllText(Path.Combine(dir.FullName, name & ".txt"), String.Empty)
				SDExplorer.SelectedNode = nodes.Add(name)
			End If
		ElseIf sender Is MnuAddFolder Then
			Dim dir As DirectoryInfo = Nothing
			Dim nodes As TreeNodeCollection = GetNearestFolderAncestor(dir)
			Dim name As String = Interaction.InputBox("New Folder")
			If Not String.IsNullOrEmpty(name) Then
				dir = Directory.CreateDirectory(Path.Combine(dir.FullName, name))
				SDExplorer.SelectedNode = nodes.Add(name & "\")
				SDExplorer.SelectedNode.Tag = dir
			End If
		ElseIf sender Is MnuReloadAll Then
			SDExplorer.Nodes.Clear()
			ReloadTree(SDExplorer.Nodes, diagrams)
		ElseIf sender Is MnuSave Then
			IO.File.WriteAllText(SDExplorer.SelectedNode.Text & ".txt", DiagramInput.Text)
		ElseIf sender Is MnuToggleTemplates Then
			SplitterTemplate.Panel2Collapsed = Not MnuToggleTemplates.Checked
		ElseIf sender Is MnuShowDiagrams Then
			SplitterTree.Panel1Collapsed = Not MnuShowDiagrams.Checked
		ElseIf sender Is MnuGenerate Then
			Dim file As String = SDExplorer.SelectedNode.Text & ".gif"
			WebRequester.WriteSDImageTo(DiagramInput.Text, "napkin", file)
			Diagram.Load(file)
		End If

	End Sub

	Private Sub SDExplorer_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles SDExplorer.AfterSelect
		DiagramInput.Text = String.Empty
		Diagram.Image = Nothing
		If SDExplorer.SelectedNode.Tag Is Nothing Then
			Dim name As String = Path.Combine(diagrams.FullName, SDExplorer.SelectedNode.FullPath)
			If File.Exists(name & ".txt") Then
				DiagramInput.Text = File.ReadAllText(name & ".txt")
			End If
			If File.Exists(name & ".gif") Then
				Diagram.Load(name & ".gif")
			End If
		End If
	End Sub

	Private Sub ReloadTree(ByVal nodes As TreeNodeCollection, ByVal Dir As DirectoryInfo)
		For Each di As DirectoryInfo In Dir.GetDirectories()
			Dim node As TreeNode = nodes.Add(di.Name & "\")
			node.Tag = di
			ReloadTree(node.Nodes, di)
		Next
		For Each fi As FileInfo In Dir.GetFiles("*.txt", SearchOption.TopDirectoryOnly)
			nodes.Add(fi.Name.Replace(".txt", ""))
		Next
	End Sub

	Private Function GetNearestFolderAncestor(ByRef dir As DirectoryInfo) As TreeNodeCollection
		Dim nodes As TreeNodeCollection = SDExplorer.Nodes
		dir = diagrams
		If Not SDExplorer.SelectedNode.Tag Is Nothing Then
			nodes = SDExplorer.SelectedNode.Nodes
			dir = CType(SDExplorer.SelectedNode.Tag, DirectoryInfo)
		End If
		While SDExplorer.SelectedNode.Tag Is Nothing
			If SDExplorer.SelectedNode.Parent Is Nothing Then Exit While
			SDExplorer.SelectedNode = SDExplorer.SelectedNode.Parent
			If Not SDExplorer.SelectedNode.Tag Is Nothing Then
				nodes = SDExplorer.SelectedNode.Nodes
				dir = CType(SDExplorer.SelectedNode.Tag, DirectoryInfo)
			End If
		End While
		Return nodes
	End Function
End Class