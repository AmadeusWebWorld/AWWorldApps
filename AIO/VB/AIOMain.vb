Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class AIOMain
	'Me.IsMdiContainer = True

	Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
		Dim OpenFileDialog As New OpenFileDialog
		OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
		If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			Dim FileName As String = OpenFileDialog.FileName
			' TODO: Add code here to open the file.
		End If
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim SaveFileDialog As New SaveFileDialog
		SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

		If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			Dim FileName As String = SaveFileDialog.FileName
			' TODO: Add code here to save the current contents of the form to a file.
		End If
	End Sub

#Region "Menus"

	Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
		MessageBox.Show("(c) 2007 - 2009 cselian.com." & _
		 vbCrLf & "All Rights Reserved", "Cselian AIO with QGen v2.0", _
		 MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Global.System.Windows.Forms.Application.Exit()
	End Sub

	Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
		Me.Toolbar.Visible = Me.ToolBarToolStripMenuItem.Checked
	End Sub

	Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
		Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
	End Sub

	Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.ArrangeIcons)
	End Sub

	Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
		' Close all child forms of the parent.
		For Each ChildForm As Form In Me.MdiChildren
			ChildForm.Close()
		Next
	End Sub

#End Region


#Region "Form Toolbar Buttons"

	Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
		MyBase.OnLoad(e)
		Dim en As IEnumerator = [Enum].GetValues(FormNames.FileFinder.GetType).GetEnumerator
		While en.MoveNext
			Dim form As FormNames = CType(en.Current, FormNames)
			Toolbar.Items.Add(New FormNewButton(Me, Form))
		End While
	End Sub

	Public Enum FormNames
		QGen
		FolderCompare
        SequenceDiagrams
        MultiReplace
		'Transformer
		FileSplitter
		QFind
        FileFinder
    End Enum

	Public Class FormNewButton
		Inherits ToolStripSplitButton

		Private openedCount As Integer
		Dim _parent As AIOMain
		Dim _type As FormNames
		Dim icon As Icon

		Public Sub New(ByVal parent As AIOMain, ByVal type As FormNames)
			Me.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
			Me.Name = "New" & type.ToString
			_parent = parent
			_type = type
			icon = CType(App.Resources.GetObject(_type.ToString), Icon)
			If Not icon Is Nothing Then icon = New Icon(icon, New Size(16, 16)) : Me.Image = icon.ToBitmap()
			Me.Text = Utilities.Humanize(_type.ToString)
			Me.Padding = New Padding(0, 0, 10, 0)
		End Sub

		Public Sub BtnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.ButtonClick
			Dim frm As Form = Nothing
			Select Case _type
				Case FormNames.QGen
					frm = New QGen
				Case FormNames.QFind
					frm = New QFind
				Case FormNames.FileSplitter
					frm = New FileSplitter
				Case FormNames.FileFinder
					frm = New FileFinder
				Case FormNames.FolderCompare
					frm = New FolderCompare
				Case FormNames.SequenceDiagrams
					frm = New SequenceDiagrams
                Case FormNames.MultiReplace
                    frm = New MultiReplace
                    'Case FormNames.Transformer
                    '	frm = New Transformer
            End Select
            frm.Icon = CType(App.Resources.GetObject(Me.GetType().Name), Icon)
			frm.MdiParent = _parent
			frm.WindowState = FormWindowState.Maximized
			'TODO: Icon size is too big
			'frm.Icon = icon

			Dim title As String = String.Concat(Me.Text, " ", openedCount)
			frm.Text = title
			Dim btn As New ToolStripButton(title)

			btn.Image = Me.Image
			Me.DropDownItems.Add(btn)

			AddHandler frm.FormClosing, AddressOf _parent.ChildFormClosing
			AddHandler frm.FormClosed, AddressOf _parent.ChildFormClose
			AddHandler btn.Click, AddressOf _parent.FormSelect

			openedCount += 1

			frm.Show()
		End Sub

	End Class

	Private Sub ChildFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
		Dim frm As Form = CType(sender, Form)
		If Not Me.FindForm Is sender Then
			frm.Select()
			Application.DoEvents()
		End If

		If MsgBox("Sure you want to close " + frm.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then _
		e.Cancel = True
	End Sub

	Private Sub ChildFormClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
		Dim frm As Form = CType(sender, Form)
		Dim name As String = sender.GetType.Name
		For Each t As FormNewButton In Toolbar.Items
			If t.Name = "New" + name Then
				Dim ind As Integer = 0
				For Each b As ToolStripButton In t.DropDownItems
					If b.Text = frm.Text Then Exit For
					ind += 1
				Next
				If ind < t.DropDownItems.Count Then t.DropDownItems.RemoveAt(ind)
			End If
		Next
	End Sub

	Private Sub FormSelect(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim title As String = CType(sender, ToolStripItem).Text
		For Each frm As Form In Me.MdiChildren
			If frm.Text = title Then
				frm.Focus()
				Exit For
			End If
		Next
	End Sub

#End Region

End Class
