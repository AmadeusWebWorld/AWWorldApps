Imports System.IO
Imports System.Text

Public Class QGen

	'Undocumented Feature
	Private Sub Swap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Swap.Click
		Dim result As String = ""

		For Each lin As String In Output.Text.Replace(vbTab, "").Split(vbCrLf)
			If lin.IndexOf(" = ") <> -1 Then
				Dim s() As String = lin.Trim(vbCr).Split(" = ")
				If UBound(s) = 2 Then	'else cancel
					result += String.Format("{2} = {1}{0}", vbCrLf, s(0), s(2))
				Else
					result += lin + vbCrLf
				End If
			End If
		Next
		Output.Text = result
	End Sub


#Region "File Selection - Dragdrop, File Dialog"

	Private Sub txtDragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputFile.DragDrop, OutputFileFormat.DragDrop
		Dim txt As TextBox = CType(sender, TextBox)
		Dim i As IEnumerator = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetEnumerator()
		If i.MoveNext Then txt.Text = i.Current.ToString
	End Sub

	Private Sub txtDragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputFile.DragEnter, OutputFileFormat.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy
	End Sub

    Private Sub txtLevelKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles Level2Template.KeyDown, Level3Template.KeyDown, Level4Template.KeyDown
        If e.KeyCode = Keys.Insert Then
            Level(CType(sender, TextBox), False)
        ElseIf e.KeyCode = Keys.Delete And e.Control Then
            Level(CType(sender, TextBox), True)
        End If
    End Sub

    Private Sub txtLevelChange(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Level2Template.TextChanged, Level3Template.TextChanged, Level4Template.TextChanged
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.Text.Length > 0 And Not txt.Parent.Text.Contains("*") Then
            txt.Parent.Text = txt.Parent.Text + "*"
        Else
            txt.Parent.Text = txt.Parent.Text.Replace("*", String.Empty)
        End If
    End Sub

    Private Sub Level(ByVal txt As TextBox, ByVal del As Boolean)
        If del Then txt.Clear() Else txt.SelectedText = "[LEVEL" & (CInt(txt.Name.Substring(5, 1)) - 1) & "]"
    End Sub


    Private Sub txtKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles InputFile.KeyDown, OutputFileFormat.KeyDown, Input.KeyDown
        If (sender Is InputFile And e.KeyCode = Keys.S And e.Control) Then
            SaveInputFile()
        ElseIf e.KeyCode = Keys.Insert And Not sender Is InputFile Then
            Dim txt As TextBox = CType(sender, TextBox)
            If File.Exists(txt.Text) Then
                OFD.InitialDirectory = New IO.FileInfo(txt.Text).Directory.FullName
            ElseIf txt Is Input Then
                OFD.InitialDirectory = App.GenDataFolder
            End If

            OFD.Multiselect = False
            Dim dr As DialogResult = OFD.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                txt.Text = GetFileText(OFD.FileName, sender Is Input)
            End If

        End If
    End Sub

#End Region

    Private Sub QGen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, RefreshFiles.Click
        Level2Template.Clear() : Level3Template.Clear() : Level4Template.Clear()
        Dim d As New DirectoryInfo(App.GenDataFolder)
        If Not d.Exists Then
            MessageBox.Show("Not found: " & App.GenDataFolder) : Exit Sub
        Else
            InputFile.Items.Clear()
            For Each f As FileInfo In d.GetFiles("*.gen")
                InputFile.Items.Add(f.Name)
            Next
        End If
    End Sub

    Private ReadOnly GenFileSeparator = String.Concat(vbCrLf, "~|~|~|~", vbCrLf)

    Private Sub LoadInputFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputFile.SelectedIndexChanged
        Dim path As String = App.GetGenDataPath(InputFile.Text)
        If File.Exists(path) Then
            Dim f As String = File.ReadAllText(path)
            Dim lt() As String = Split(f, GenFileSeparator)
            If lt.Length <= 2 Then MessageBox.Show("Not enough parts separated by:" & GenFileSeparator) : Exit Sub
            OutputFileFormat.Text = lt(0)
            FileTemplate.Text = lt(1)
            LineTemplate.Text = lt(2)
            Input.Text = lt(3)
            If (lt.Length > 4) Then
                Level2Template.Text = lt(4)
                Level3Template.Text = lt(5)
                Level4Template.Text = lt(6)
            Else
                Level2Template.Text = String.Empty
                Level3Template.Text = String.Empty
                Level4Template.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub SaveInputFile()
        Dim name As String = InputFile.Text
        If Not name.EndsWith(".gen") Then name += ".gen"
        'Dim settings As String = String.Format("{0},{1},{2}", TabsInput.Checked, ReplaceBraces.Checked, Append.Checked)
        File.WriteAllText(App.GetGenDataPath(name), String.Join(GenFileSeparator, New String() _
                                            {OutputFileFormat.Text, _
                                             FileTemplate.Text, _
                                             LineTemplate.Text, _
                                             Input.Text, _
                                             Level2Template.Text, _
                                             Level3Template.Text, _
                                             Level4Template.Text}))
        If Not InputFile.Items.Contains(name) Then InputFile.Items.Add(name) : InputFile.SelectedIndex = InputFile.Items.Count - 1
    End Sub

    Private Function Separator() As String
        Return IIf(TabsInput.Checked, vbTab, ",")
    End Function

    Private Const ExternalInput As String = "#include "

    Private Function GetFileText(ByVal filePath As String, ByVal isExternal As Boolean) As String
        If Not isExternal Then Return filePath

        Dim name As String = filePath
        Dim pos As Integer = filePath.IndexOf(App.GenDataFolder.ToLower, StringComparison.OrdinalIgnoreCase)
        If pos > -1 Then name = filePath.Substring(pos + App.GenDataFolder.Length + 1)
        Dim sb As New StringBuilder(ExternalInput & name)
        Dim columns As New List(Of String)(Split(Split(File.ReadAllText(filePath), vbCrLf)(0), Separator()))
        sb.AppendFormat("{0}[COL]=SkipLine{0}{1}={2}2{0}{1}={2}4{0}{1}={2}4{0}", vbCrLf, "[COL]", "SkipLevel")
        Dim i As Integer
        For Each col As String In columns
            sb.AppendLine(col & "=" & i)
            i += 1
        Next
        Return sb.ToString
    End Function

    Private Function GetExternalPath(ByVal external As String)
        external = external.Substring(ExternalInput.Length)
        If Not File.Exists(external) Then external = App.GetGenDataPath(external)
        Return external
    End Function


    Private Sub GenerateFiles(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Generate.Click
        Dim newIndices() As Integer = Nothing
        Dim lines() As String, skipLine As Nullable(Of Integer)
        Dim levels() As Nullable(Of Integer) = {Nothing, Nothing, Nothing}

        Dim lookupColumnIndex As Nullable(Of Integer), lookupPad As String
        Dim lookupColumns As New List(Of Integer), lookupColumnOptions As New Dictionary(Of Integer, Dictionary(Of String, String))


        If Input.Text.StartsWith(ExternalInput) Then
            Dim external() As String = Split(Input.Text, vbCrLf)
            Dim path As String = GetExternalPath(external(0))
            Dim externalLines As New List(Of String)(File.ReadAllLines(path, App.Encoding))
            If external.Length > 1 Then
                Dim indexLkp As New SortedDictionary(Of Integer, Integer)
                Dim max = 0
                Dim columns As New List(Of String)(externalLines(0).Split(Separator()))
                For index As Integer = 1 To UBound(external)
                    If String.IsNullOrEmpty(external(index)) Then Continue For
                    Dim ci As String() = Split(external(index), "=")
                    If ci(1) = "SkipLine" Then
                        skipLine = GetIndexOf(columns, ci(0), ci(1))
                    ElseIf ci(1) = "SkipLevel2" Then
                        levels(0) = GetIndexOf(columns, ci(0), ci(1))
                    ElseIf ci(1) = "SkipLevel3" Then
                        levels(1) = GetIndexOf(columns, ci(0), ci(1))
                    ElseIf ci(1) = "SkipLevel4" Then
                        levels(2) = GetIndexOf(columns, ci(0), ci(1))
                    ElseIf ci(1) = "LookupColumn" Then 'used as FileFormatIndex
                        lookupColumnIndex = GetIndexOf(columns, ci(0), ci(1))
                    Else
                        Dim replaceIndex = CInt(ci(1))
                        max = Math.Max(max, replaceIndex)
                        If indexLkp.ContainsKey(replaceIndex) Then Throw New Exception(String.Format("Index {0} declared for {1} is already used", replaceIndex, ci(0)))

                        If ci(0) = "LookupColumn" Then
                            lookupColumns.Add(replaceIndex)
                            Dim values As New Dictionary(Of String, String)
                            For lookupValueIndex As Integer = 2 To ci.Length - 1 Step 2
                                values.Add(ci(lookupValueIndex), ci(lookupValueIndex + 1).Replace("\eq", "="))
                            Next
                            lookupColumnOptions.Add(replaceIndex, values)
                            indexLkp.Add(replaceIndex, columns.Count - 1 + lookupColumns.Count)
                        Else
                            Dim colIndex As Integer = GetIndexOf(columns, ci(0), ci(1))
                            indexLkp.Add(replaceIndex, colIndex)
                        End If
                    End If
                Next

                'Add lookups to end & adjust lookupPad accordingly
                lookupPad = New String(Separator().ToCharArray()(0), lookupColumns.Count)

                Dim indices As New List(Of Integer)
                For index As Integer = 0 To max
                    indices.Add(indexLkp(index))
                Next
                newIndices = indices.ToArray
                externalLines.RemoveAt(0)
            End If
            lines = externalLines.ToArray
        Else
            lines = Split(Input.Text, vbCrLf)
        End If
        'Dim tpl As String = File.ReadAllText(InputFile.Text)
        Dim op As String, opFil As String = "QGen output.txt"
        If Append.Checked Then
            opFil = OutputFileFormat.Text
            If File.Exists(opFil) Then File.Delete(opFil)
        End If
        Dim fileLines As New Dictionary(Of String, StringBuilder)()
        Dim files As New Dictionary(Of String, String)()
        Dim sb As StringBuilder

        For Each line As String In lines
            If line <> "" Then
                Dim str() As String = (line + lookupPad).Split(Separator())
                If lookupColumnIndex.HasValue Then
                    Dim val = str(lookupColumnIndex)
                    For Each lkp As Integer In lookupColumns
                        str(newIndices(lkp)) = lookupColumnOptions(lkp)(val)
                    Next
                End If
                Dim skip As Boolean = skipLine.HasValue AndAlso String.IsNullOrEmpty(str(skipLine)) = False
                Dim skipLevels() As Boolean = {True, True, True}
                If (skip) Then Continue For
                skipLevels(0) = Not (levels(0).HasValue AndAlso String.IsNullOrEmpty(str(levels(0).Value)))
                skipLevels(1) = Not (levels(1).HasValue AndAlso String.IsNullOrEmpty(str(levels(1).Value)))
                skipLevels(2) = Not (levels(2).HasValue AndAlso String.IsNullOrEmpty(str(levels(2).Value)))
                If newIndices IsNot Nothing Then
                    Dim reindexed As New List(Of String)
                    For index As Integer = 0 To UBound(newIndices)
                        If (str.Length < newIndices(index)) Then Throw New Exception( _
                            String.Concat("Insufficient Items for Column: ", index, " for line:" + vbCrLf, line))
                        reindexed.Add(str(newIndices(index)))
                    Next
                    str = reindexed.ToArray
                End If
                op = ApplyTemplate(LineTemplate.Text, str, ReplaceBraces.Checked)
                '0 - LEVEL, 1234 - LEVEL

                Dim levelOutput() As String = {op, op, Nothing, Nothing, Nothing}
                If Not skipLevels(0) Then op = ApplyLevelTemplate(1, levelOutput, Level2Template.Text, str, ReplaceBraces.Checked)
                If Not skipLevels(1) Then op = ApplyLevelTemplate(2, levelOutput, Level3Template.Text, str, ReplaceBraces.Checked)
                If Not skipLevels(2) Then op = ApplyLevelTemplate(3, levelOutput, Level4Template.Text, str, ReplaceBraces.Checked)

                opFil = String.Format(OutputFileFormat.Text, str)
                If Not fileLines.TryGetValue(opFil, sb) Then
                    sb = New StringBuilder
                    fileLines.Add(opFil, sb)
                    If Not String.IsNullOrEmpty(FileTemplate.Text) Then
                        Dim fileOut As String = ApplyTemplate(FileTemplate.Text, str, ReplaceBraces.Checked)
                        files.Add(opFil, fileOut)
                    End If
                End If
                sb.Append(op)
            End If
        Next

        Dim ob As StringBuilder = Nothing
        If Not Append.Checked Then Output.Text = New DirectoryInfo(".\").FullName Else ob = New StringBuilder
        For Each key As String In fileLines.Keys
            Dim out As String = fileLines(key).ToString
            If files.Count > 0 Then
                out = files(key).Replace("[LINES]", out)
            End If
            If Append.Checked Then
                ob.AppendLine(out)
            Else
                Dim fileName As String = App.GetDataPath(key)
                If File.Exists(fileName) Then File.Delete(fileName)
                File.WriteAllText(fileName, out, Encoding.UTF8)
                Output.Text += vbCrLf + key
            End If
        Next

        If Append.Checked Then Output.Text = ob.ToString : File.WriteAllText(InputFile.Text & ".txt", Output.Text)
    End Sub

    Private Shared Function GetIndexOf(ByVal columns As List(Of String), ByVal column As String, ByVal asWhat As String) As Integer
        Dim index = columns.IndexOf(column)
        If index = -1 Then
            Throw New Exception("Not found column : '" + column + "' defined for '" + asWhat + "'")
        End If
        Return index
    End Function

    Private Shared Function ApplyTemplate(ByVal template As String, ByVal str() As String, ByVal replace As Boolean) As String
        Try
            ApplyTemplate = String.Format(template, str)
            If replace Then
                ApplyTemplate = ApplyTemplate.Replace("<<", "{").Replace(">>", "}").Replace("\r\n", vbCrLf).Replace("\t", vbTab)
            End If
        Catch ex As FormatException
            Throw New Exception(String.Format("Use << and >> instead of curly braces.{0}{0}{0}Could not substitute {1} columns:{0}    {3}{0}in Template: {0}{0}{2}", vbCrLf, str.Length, template, String.Join(vbCrLf & vbTab, str)))
        End Try
    End Function

    Private Shared Function ApplyLevelTemplate(ByVal level As Integer, _
                                               ByRef levelOutput As String(), _
                                               ByVal template As String, _
                                               ByVal str() As String, _
                                               ByVal replace As Boolean) As String
        Dim replaced As String = ApplyTemplate(template, str, replace)

        For currentLevel As Integer = 0 To level
            Dim levelPlaceholder As String = String.Format("[LEVEL{0}]", IIf(currentLevel = 0, "", currentLevel.ToString))
            If replaced.Contains(levelPlaceholder) Then _
                replaced = replaced.Replace(levelPlaceholder, levelOutput(currentLevel))
        Next
        levelOutput(0) = replaced
        levelOutput(level) = replaced
        Return replaced
    End Function

    Private Sub MakeCasing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeCasing.Click
        Dim sep = Separator()
        Dim lines() As String = Split(Input.Text, vbCrLf)
        For i As Integer = 0 To lines.Length - 1
            If String.IsNullOrEmpty(lines(i)) = False Then
                Dim st As String = lines(i).Substring(0, 1)
                lines(i) = String.Concat(st.ToLower, sep, st.ToUpper, sep, lines(i).Substring(1))
            End If
        Next
        Input.Text = String.Join(vbCrLf, lines)
    End Sub

    Private Sub Output_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Output.DoubleClick, Input.DoubleClick
        If sender Is Input Then
            If Input.Text.StartsWith(ExternalInput) Then
                Process.Start("notepad.exe", GetExternalPath(Input.Lines(0)))
            End If
            Return
        End If
        If Append.Checked Then Return
        Dim pos As Integer = 0
        For Each line As String In Output.Lines
            If (Output.SelectionStart < pos + line.Length) Then
                Dim filePath As String = App.GetDataPath(line)
                If Directory.Exists(filePath) Then
                    Process.Start(filePath)
                ElseIf File.Exists(filePath) Then
                    'Dim file = Path.Combine(New DirectoryInfo(".\").FullName, line)
                    Process.Start("notepad.exe", filePath)
                End If
                Return
            End If
            pos += line.Length + 2 '+CrLf
        Next
    End Sub

    Private Sub FileTemplate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FileTemplate.KeyDown
        If e.KeyCode = Keys.A And e.Control Then
            FileTemplate.SelectAll()
        ElseIf e.KeyCode = Keys.V And e.Alt And ReplaceBraces.Checked AndAlso Clipboard.ContainsText Then
            FileTemplate.SelectedText = Clipboard.GetText().Replace("{", "<<").Replace("}", ">>")
        End If
    End Sub

    Private Sub Append_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Append.CheckedChanged
        MergeTemplate.Enabled = Append.CheckState = CheckState.Checked
    End Sub
End Class
