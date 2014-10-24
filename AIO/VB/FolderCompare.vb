Imports System.IO

Public Class FolderCompare

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FilesFound.ListViewItemSorter = New Sorter(ColLevel)
        WhatToShow.Items.AddRange(Filter.Options)
    End Sub

	Private Sub txtChange(ByVal sender As Object, ByVal e As EventArgs) _
		Handles Directory1.TextChanged, Directory2.TextChanged
		Compare.Enabled = Directory.Exists(Directory1.Text) AndAlso Directory.Exists(Directory2.Text)
	End Sub


    Private Sub Compare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Compare.Click
        FilesFound.Items.Clear() : found = Nothing
        Dim s1, s2 As String
        Dim d1 As List(Of FileInfo) = GetFiles(Directory1.Text, s1)
        Dim d2 As List(Of FileInfo) = GetFiles(Directory2.Text, s2)
        Dim itms() As String = {"", "", "", "", ""}
        For Each d As FileInfo In d1
            Dim key As String = d.FullName.Substring(s1.Length)
            Dim itm As ListViewItem = FilesFound.Items.Add(key, key, String.Empty)
            itm.SubItems.AddRange(itms)
            SubItem(itm, ColLeft) = "Y"
            SubItem(itm, ColLevel) = (key.Length - key.Replace("\", String.Empty).Length).ToString
            Dim second As FileInfo = d2.Find(Function(f As FileInfo) f.FullName = (s2 + key))
            If Not second Is Nothing Then
                SubItem(itm, ColRight) = "Y"
                SubItem(itm, ColSame) = IIf(App.FileEquals(d, second), "Y", "N")
                d2.Remove(second)
            End If
        Next
        For Each d As FileInfo In d2
            Dim key = d.FullName.Substring(s2.Length)
            Dim itm As ListViewItem = FilesFound.Items.Add(key, key, String.Empty)
            itm.SubItems.AddRange(itms)
            SubItem(itm, ColRight) = "Y"
            SubItem(itm, ColLevel) = (key.Length - key.Replace("\", String.Empty).Length).ToString
        Next
        'FilesFound.Sort()
    End Sub

    Private Shared Property SubItem(ByVal itm As ListViewItem, ByVal col As ColumnHeader) As String
        Get
            If itm.SubItems.Count = 1 Then Return String.Empty
            Return itm.SubItems(col.Index).Text
        End Get
        Set(ByVal value As String)
            itm.SubItems(col.Index).Text = value
        End Set
    End Property

    Private Shared Function GetFiles(ByVal dir As String, ByRef s As String) As List(Of FileInfo)
        Dim d As New DirectoryInfo(dir)
        Dim files As New List(Of FileInfo)(d.GetFiles("*.*", SearchOption.AllDirectories))
        files.RemoveAll(Function(f As FileInfo) _
                            f.FullName.Contains("\obj\") Or _
                            f.FullName.Contains("\bin\") Or _
                            f.FullName.Contains("\.svn\"))
        s = d.FullName & IIf(d.FullName.EndsWith("\"), String.Empty, "\")
        Return files
    End Function

    Private Class Sorter
        Implements IComparer

        ReadOnly Level As ColumnHeader

        Public Sub New(ByVal colLevel As ColumnHeader)
            Level = colLevel
        End Sub

        Private Function CompareItems(ByVal o1 As Object, ByVal o2 As Object) As Integer Implements IComparer.Compare
            Dim i1 As ListViewItem = CType(o1, ListViewItem)
            Dim i2 As ListViewItem = CType(o2, ListViewItem)
            'Dim one As Integer = SubItem(i1, Level).CompareTo(SubItem(i2, Level))
            'If one = 0 Then
            Return i1.Text.CompareTo(i2.Text) 'Else Return one
        End Function
    End Class





    Private Sub FilesFound_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles FilesFound.DoubleClick
        ShowSelection()
    End Sub

    Private Sub FilesFound_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles FilesFound.KeyDown
        If e.KeyCode = Keys.Return Then ShowSelection()
    End Sub

    Private Sub ShowSelection()
        For Each itm As ListViewItem In FilesFound.SelectedItems
            If SubItem(itm, ColRight).Equals(SubItem(itm, ColLeft)) Then
                If SubItem(itm, ColRight) = "Y" Then
                    Dim f1 = """" & Directory1.Text & itm.Text & """"
                    Dim f2 = """" & Directory2.Text & itm.Text & """"
                    Process.Start("""" & App.DiffUtil & """", f1 & " " & f2)
                End If
            Else
                Dim base = IIf(itm.SubItems(ColRight.Index).Text = "Y", Directory2.Text, Directory1.Text)
                Process.Start("notepad.exe", base & itm.Text)
            End If
        Next
    End Sub

    Dim found As List(Of ListViewItem)

    Private Sub WhatToShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatToShow.Click
        If found Is Nothing Then
            found = New List(Of ListViewItem)()
            For Each itm As ListViewItem In FilesFound.Items
                found.Add(itm)
            Next
        End If
        Dim f As New Filter(CStr(WhatToShow.SelectedItem), New Integer() {ColLeft.Index, ColRight.Index, ColSame.Index})
        FilesFound.Items.Clear()
        Dim p As New Predicate(Of ListViewItem)(AddressOf f.Match)
        FilesFound.Items.AddRange(found.FindAll(p).ToArray)
    End Sub

    Private Class Filter
        Public Shared ReadOnly Options() As String = {"All", "LeftOnly", "RightOnly", "Both", "Different"}

        Private ReadOnly filterBy As Integer, cols() As Integer

        'Left, Right, Same
        Public Sub New(ByVal what As String, ByVal colsLRS() As Integer)
            filterBy = Array.IndexOf(Options, what)
            cols = colsLRS
        End Sub

        Public Function Match(ByVal itm As ListViewItem) As Boolean 'Handles Predicate(Of ListViewItem)
            Select Case filterBy
                Case 0
                    Return True
                Case 1
                    Return itm.SubItems(cols(0)).Text = "Y" AndAlso itm.SubItems(cols(1)).Text = ""
                Case 2
                    Return itm.SubItems(cols(0)).Text = "" AndAlso itm.SubItems(cols(1)).Text = "Y"
                Case 3
                    Return itm.SubItems(cols(0)).Text.Length = 1 AndAlso itm.SubItems(cols(1)).Text.Length = 1
                Case 4
                    Return itm.SubItems(cols(2)).Text = "N"
            End Select
        End Function

    End Class
End Class