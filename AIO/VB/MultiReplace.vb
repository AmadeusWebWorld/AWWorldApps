Imports System.IO
Imports System.Text


Public Class MultiReplace

#Region "File Selection - Dragdrop, File Dialog"

    Private Sub txtDragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputFile.DragDrop, FindIn.DragDrop, ReplaceTo.DragDrop
        Dim txt As TextBox = CType(sender, TextBox)
        Dim i As IEnumerator = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetEnumerator()
        If i.MoveNext Then txt.Text = i.Current.ToString
    End Sub

    Private Sub txtDragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputFile.DragEnter, FindIn.DragEnter, ReplaceTo.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub txtKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles InputFile.KeyDown, FindIn.KeyDown, ReplaceTo.KeyDown
        If (sender Is InputFile And e.KeyCode = Keys.S And e.Control) Then
            SaveInputFile()
        ElseIf e.KeyCode = Keys.Insert And Not sender Is InputFile Then
            Dim txt As TextBox = CType(sender, TextBox)
            If File.Exists(txt.Text) Then
                OFD.InitialDirectory = New IO.FileInfo(txt.Text).Directory.FullName
            End If

            OFD.Multiselect = False
            Dim dr As DialogResult = OFD.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                'txt.Text = GetFileText(OFD.FileName, sender Is Input())
            End If

        End If
    End Sub

#End Region

    Private ReadOnly FileElementSeparator = String.Concat(vbCrLf, "~|~|~|~", vbCrLf)
    Private finds As New List(Of TextBox), replaces As New List(Of TextBox), splitters As New List(Of SplitContainer)

	Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		If Not Me.Tag Is Nothing Then
			ReplaceTo.Visible = False
			FindIn.Visible = False
		End If
		Dim d As New DirectoryInfo(App.GenDataFolder)
		If Not d.Exists Then
			MessageBox.Show("Not found: " & App.GenDataFolder) : Exit Sub
		Else
			InputFile.Items.Clear()
			For Each f As FileInfo In d.GetFiles("*.rep")
				InputFile.Items.Add(f.Name)
			Next
		End If
		AddRow.PerformClick()
	End Sub

    Private Sub LoadInputFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputFile.SelectedIndexChanged
        Dim blocks = Split(File.ReadAllText(App.GetGenDataPath(InputFile.SelectedItem)), FileElementSeparator)
        FindIn.Text = blocks(0)
        ReplaceTo.Text = blocks(1)

        For Each s As SplitContainer In splitters
            RemoveHandler s.SplitterMoved, AddressOf splitter_SplitterMoved
        Next
        While Items.Controls.Count > 0
            Items.Controls.RemoveAt(0)
        End While
        finds.Clear() : replaces.Clear() : splitters.Clear()

        For index As Integer = 2 To UBound(blocks) - 1 Step 2
            AddRow.PerformClick()
            finds(finds.Count - 1).Text = blocks(index)
            replaces(finds.Count - 1).Text = blocks(index + 1)
        Next
    End Sub

    Private Sub SaveInputFile()
        Dim fileName As String = InputFile.Text
        If Not fileName.EndsWith(".rep") Then fileName += ".rep"
        Dim s As New StringBuilder()
        s.Append(FindIn.Text)
        s.Append(FileElementSeparator)
        s.Append(ReplaceTo.Text)
        s.Append(FileElementSeparator)


        For index As Integer = 0 To finds.Count - 1
            If (String.IsNullOrEmpty(finds(index).Text) AndAlso _
                String.IsNullOrEmpty(replaces(index).Text)) Then Continue For
            s.Append(finds(index).Text)
            s.Append(FileElementSeparator)
            s.Append(replaces(index).Text)
            If (index <> finds.Count - 1) Then _
                s.Append(FileElementSeparator)
        Next

        File.WriteAllText(App.GetGenDataPath(fileName), s.ToString)
        If Not InputFile.Items.Contains(fileName) Then InputFile.Items.Add(fileName) : InputFile.SelectedIndex = InputFile.Items.Count - 1
    End Sub

    Private Sub Me_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Items.MinimumSize = New Size(Me.Width - 50, LineHeight)
    End Sub

    Private Sub MultilineCount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultilineCount.ValueChanged
        For Each ctl As Control In Items.Controls
            ctl.Height = LineHeight
        Next
    End Sub

    Private Sub AddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRow.Click
        Dim newfind = NewTextBox()
        finds.Add(newfind)

        Dim newreplace = NewTextBox
        replaces.Add(newreplace)

        Dim splitter As New SplitContainer
        splitter.SplitterDistance = splitter.Width / 2
        splitter.SplitterWidth = 2
        splitter.Dock = DockStyle.Top
        splitter.Panel1.Padding = New Padding(0, 0, 0, 5)
        splitter.Panel2.Padding = New Padding(0, 0, 0, 5)
        splitter.Panel1.Controls.Add(newfind)
        splitter.Panel2.Controls.Add(newreplace)
        splitter.Height = LineHeight
        splitter.BringToFront() 'so that goes to bottom
        splitters.Add(splitter)
        AddHandler splitter.SplitterMoved, AddressOf splitter_SplitterMoved
        Items.Controls.Add(splitter)
    End Sub

    Private Sub splitter_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs)
        Dim current As SplitContainer = CType(sender, SplitContainer)
        For Each s As SplitContainer In splitters
            If (s.GetHashCode <> current.GetHashCode) Then _
            s.SplitterDistance = current.SplitterDistance
        Next
    End Sub

    Private ReadOnly Property LineHeight() As Integer
        Get
            Return MultilineCount.Value * 20 + 5
        End Get
    End Property

    Private Function NewTextBox() As TextBox
        Dim txt As New TextBox
        txt.ScrollBars = ScrollBars.Both
        txt.Dock = DockStyle.Fill
        txt.Multiline = True
        Return txt
    End Function

	Private Sub Replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Replace.Click
		If sender IsNot Nothing And Me.Tag IsNot Nothing Then
			Dim list = CType(Me.Tag, System.Collections.Generic.List(Of String))
			For Each f As String In list
				ReplaceTo.Text = f
				FindIn.Text = f
				Replace_Click(Nothing, Nothing)
			Next
		End If

		Dim text As String = File.ReadAllText(App.GetDataPath(FindIn.Text))

		For index As Integer = 0 To finds.Count - 1
			Dim find As String = finds(index).Text
			Dim found As Boolean = False
			If find = "EOF" Then
				text = text & replaces(index).Text
				found = True
			ElseIf find = "SOF" Then
				text = replaces(index).Text & text
				found = True
			Else
				If Not String.IsNullOrEmpty(find) AndAlso text.Contains(find) Then
					text = text.Replace(finds(index).Text, replaces(index).Text)
					found = True
				Else

				End If
			End If
			finds(index).BackColor = IIf(found, Color.LightGreen, Color.LightPink)
		Next
		File.WriteAllText(App.GetDataPath(ReplaceTo.Text), text)
	End Sub

End Class
