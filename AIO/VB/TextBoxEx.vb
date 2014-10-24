Imports System.IO

''' <summary>
''' DragDrop Changes Text to First File path
''' </summary>
''' <remarks></remarks>
Public Class TextBoxEx
	Inherits TextBox

	Enum FileSelectionType
		None
		OneOnly
		Multiple
	End Enum

	Private st As FileSelectionType = FileSelectionType.None

	Public Property FileSelection() As FileSelectionType
		Get
			Return st
		End Get
		Set(ByVal value As FileSelectionType)
			st = value
		End Set
	End Property

	Public Event AfterFileSelect As EventHandler

	Protected Overrides Sub OnDragEnter(ByVal drgevent As System.Windows.Forms.DragEventArgs)
		MyBase.OnDragEnter(drgevent)
		If drgevent.Data.GetDataPresent(DataFormats.FileDrop) Then drgevent.Effect = DragDropEffects.Copy
	End Sub

	Protected Overrides Sub OnDragDrop(ByVal drgevent As System.Windows.Forms.DragEventArgs)
		MyBase.OnDragDrop(drgevent)

		Dim i As IEnumerator = CType(drgevent.Data.GetData(DataFormats.FileDrop), Array).GetEnumerator()
		If i.MoveNext Then Me.Text = i.Current.ToString
	End Sub

	Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.KeyCode = Keys.Insert And st <> FileSelectionType.None Then
			OpenFile()
		ElseIf e.Control And e.KeyCode = Keys.A Then
			Me.SelectAll()
		ElseIf e.Control And e.KeyCode = Keys.C Then
			Clipboard.SetText(Me.SelectedText)
		ElseIf e.Control And e.KeyCode = Keys.V And Clipboard.ContainsText Then
			Me.SelectedText = Clipboard.GetText()
		End If
	End Sub

	Private Sub OpenFile()
		Dim ofd As New OpenFileDialog
		If File.Exists(Me.Text) Then
			ofd.InitialDirectory = New FileInfo(Me.Text).Directory.FullName
		End If

		ofd.Multiselect = st = FileSelectionType.Multiple
		Dim dr As DialogResult = ofd.ShowDialog()
		If dr = Windows.Forms.DialogResult.OK Then
			If st = FileSelectionType.Multiple Then
				Me.Text = String.Join(vbCrLf, ofd.FileNames)
			Else
				Me.Text = ofd.FileName
			End If
			RaiseEvent AfterFileSelect(Me, EventArgs.Empty)
		End If
	End Sub

End Class
