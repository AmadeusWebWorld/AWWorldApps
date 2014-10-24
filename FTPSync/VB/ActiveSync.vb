Imports System.IO

Public Enum Names
    LocalFolder
    FtpFolder
    FtpUsername
    FtpPassword
End Enum


Public Class ActiveSync

    'dont care about trailing slashes or / ~ \ mixups.just make sure not to put // or \\

	Private Sub ActiveSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Files.Items.Clear()

		FtpHelper.Log = Log
		FtpHelper.Credentials.UserName = FtpInfo.Selected.Username

		fsw.EnableRaisingEvents = False
		ChangeServer()

	End Sub

#Region " Credentials & Settings (ChangeServer) "

	Dim waitState As Integer


	Private Sub ChangeServer()
		Dim ini As Boolean = FtpInfo.Selected.Name <> "Default"
		If Not ini Then FtpInfo.Selected.LocalFolder = FtpInfo.GetKey(Names.LocalFolder)

		If (FtpInfo.Selected.LocalFolder = String.Empty) Then
			Return
		End If

		FtpInfo.Selected.LocalFolder = FtpInfo.Selected.LocalFolder.Replace("/", "\")
		FtpInfo.Selected.LocalFolder += IIf(FtpInfo.Selected.LocalFolder.EndsWith("\"), "", "\")

		If Directory.Exists(FtpInfo.Selected.LocalFolder) Then

			fsw.Path = FtpInfo.Selected.LocalFolder

			If Not fsw.EnableRaisingEvents Then
				fsw.EnableRaisingEvents = True
				fsw.IncludeSubdirectories = True
				fsw.NotifyFilter = IO.NotifyFilters.FileName Or IO.NotifyFilters.LastWrite
				'Or IO.NotifyFilters.Size 'May not always change, makes 2 calls since LastWrite will anyway be raised
				AddHandler fsw.Changed, AddressOf fsw_Changed
				AddHandler fsw.Created, AddressOf fsw_Changed
				'AddHandler fsw.Renamed, AddressOf fsw_Changed
			End If
		End If


		FtpHelper.SetMessage("*** FileWatcher Initialised on " + FtpInfo.Selected.LocalFolder + Now.ToString(" dd MMM yyyy"))


		If Not ini Then FtpInfo.Selected.FtpFolder = FtpInfo.GetKey(Names.FtpFolder)

		If Not ini Then FtpInfo.Selected.Username = FtpInfo.GetKey(Names.FtpUsername)
		FtpHelper.Credentials.UserName = FtpInfo.Selected.Username

		FtpInfo.Selected.FtpFolder = FtpInfo.Selected.FtpFolder.Replace("\", "/")
		FtpInfo.Selected.FtpFolder += IIf(FtpInfo.Selected.FtpFolder.EndsWith("/"), "", "/")
		Sync.Enabled = FtpInfo.Selected.FtpFolder <> ""

		If Not ini Or FtpInfo.Selected.Password = String.Empty Then FtpInfo.Selected.Password = FtpInfo.GetKey(Names.FtpPassword)
		FtpHelper.Credentials.Password = FtpInfo.Selected.Password

		FtpHelper.SetMessage(String.Format("FTP Credentials Set for '{0}' (User: '{1}' Pass: '{2}')", FtpInfo.Selected.FtpFolder, FtpHelper.Credentials.UserName, "".PadRight(FtpHelper.Credentials.Password.Length, "*")))
	End Sub

#End Region

#Region " Record Changes (fsw handles & setMessage)"

	Private Sub fsw_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs)
		If e.FullPath.Contains(".svn") Then Exit Sub

		Dim itm() As ListViewItem = Files.Items.Find(e.FullPath, False)

		Dim item As ListViewItem = Nothing
		If e.ChangeType = IO.WatcherChangeTypes.Deleted Then
			'If itm.Length = 1 Then Files.Items.Remove(itm(0)) 'remove since forced to remove nonexistant files anyway
		ElseIf itm.Length = 0 Or e.ChangeType = IO.WatcherChangeTypes.Renamed Then
			item = Files.Items.Add(e.FullPath, e.Name, 0)
			item.Tag = e.FullPath	'key doesnt seem to be accessible on item :(
		ElseIf itm.Length = 1 Then
			item = itm(0)
		End If
		If item IsNot Nothing Then
			FtpHelper.SetMessage(e.ChangeType.ToString, item)
			item.Checked = True
		End If

		RemoveNonExistant()

	End Sub

	Private Sub fsw_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles fsw.Renamed
		Dim itm() As ListViewItem = Files.Items.Find(e.FullPath, False)
		Dim r As IO.RenamedEventArgs = TryCast(e, IO.RenamedEventArgs)
		If r IsNot Nothing Then
			itm = (Files.Items.Find(r.OldFullPath, False))
			If itm.Length = 1 Then Files.Items.Remove(itm(0))
		End If
		Dim f As New FileSystemEventArgs(WatcherChangeTypes.Renamed, e.FullPath, e.Name)
		fsw_Changed(sender, f)
	End Sub

	'since the move action does not seem to raise any event other that create, we must manually delete the old name (if existed).
	Private Sub RemoveNonExistant()
		Dim i As Integer = 0
		Do Until i >= Files.Items.Count
			If IO.File.Exists(FtpInfo.Selected.LocalFolder + Files.Items(i).Text) Then
				i += 1
			Else
				Files.Items.RemoveAt(i)
			End If
		Loop
	End Sub

#End Region

	'http://www.codeguru.com/csharp/csharp/cs_internet/desktopapplications/article.php/c13163/
	Private Sub UploadDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sync.Click, DeleteFTP.Click, DeleteLocal.Click
		Dim btnName As String = CType(sender, Button).Name
		Dim delFtp As Boolean = btnName = "DeleteFTP"
		Dim delLocal As Boolean = btnName = "DeleteLocal"
		If btnName.StartsWith("Delete") Then
			btnName = btnName.Replace("Delete", "Delete ")
			If MsgBox("Sure you want to " + btnName, MsgBoxStyle.YesNo, "Confirm " + btnName) = MsgBoxResult.No Then Exit Sub
		End If



		For Each itm As ListViewItem In Files.Items
			If itm.Checked Then
				If delLocal Then

					Dim msg As String = "Deleting..."
					Try
						If File.Exists(itm.Tag) Then
							File.Delete(itm.Tag)
						Else
							msg = "File Delete - Doesnt Exist"
						End If
					Catch ex As Exception
						MessageBox.Show(ex.Message, "Local File Delete Error")
						msg = "File Delete Error - " + ex.ToString
					End Try
					FtpHelper.SetMessage(msg, itm)

				Else
					FtpHelper.SetMessage(FtpHelper.SyncFTP(itm.Text, delFtp), itm)
				End If

				If Not delFtp Then itm.Checked = False
				Application.DoEvents()
			End If
		Next
		If delLocal Then RemoveNonExistant()
	End Sub

#Region " Column Resizing "

	Private isResizing As Boolean

	Private Sub ActiveSync_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Dim c1 As ColumnHeader = Files.Columns(0)
		Dim c2 As ColumnHeader = Files.Columns(1)
		Dim c3 As ColumnHeader = Files.Columns(2)
		Dim w As Long = Files.Width - 30 - c3.Width, ow As Long = c1.Width + c2.Width
		Dim rat As Double = c1.Width / c2.Width
		isResizing = True
		c1.Width += (w - ow) * rat / (rat + 1)
		c2.Width += (w - ow) * 1 / (rat + 1)

		'InputPanel.Top = (splitter1.Height - InputPanel.Height) / 2
	End Sub

	Private Sub Files_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles Files.ColumnWidthChanged
		If e.ColumnIndex = 0 Then
			If isResizing Then
				isResizing = False
			Else
				Files.Columns(1).Width = Files.Width - 30 - Files.Columns(0).Width
			End If
		End If
	End Sub

#End Region

    Private Sub Pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pause.Click
        fsw.EnableRaisingEvents = Not fsw.EnableRaisingEvents
        Pause.Text = IIf(fsw.EnableRaisingEvents, "&Pause", "&Play")
    End Sub

    Private Sub Log_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Log.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            Log.SelectAll()
        ElseIf e.Control And e.KeyCode = Keys.Insert Then
            If FtpInfo.HasMultipleOptions Then FtpInfo.SelectOption()
            ChangeServer()
        ElseIf e.Control And e.KeyCode = Keys.Return Then
			FtpHelper.MakeWebRequest()
        End If
    End Sub

    Private Sub Files_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Files.KeyDown
        If e.KeyCode = Keys.F5 Then RemoveNonExistant()
        If e.Control And (e.KeyCode = Keys.A Or e.KeyCode = Keys.U) Then
            Dim checked As Boolean = e.KeyCode = Keys.A
            For Each itm As ListViewItem In Files.Items
                itm.Checked = checked
            Next
        End If
        If e.Control And e.KeyCode = Keys.Delete Then
            For i As Integer = Files.SelectedIndices.Count - 1 To 0 Step -1
                Files.Items.RemoveAt(Files.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub Files_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Files.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.All
    End Sub

    Private Sub Files_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Files.DragDrop
		For Each fil As String In e.Data.GetData(DataFormats.FileDrop)
			If fil.StartsWith(FtpInfo.Selected.LocalFolder, StringComparison.OrdinalIgnoreCase) = False Then Continue For

			Dim file As String = fil.Substring(FtpInfo.Selected.LocalFolder.Length)
			Dim item() As ListViewItem = Files.Items.Find(fil, False)

			If item.Length = 0 Then
				Dim itm = Files.Items.Add(fil, file, 0)
				itm.Tag = fil	'key doesnt seem to be accessible on item 

				FtpHelper.SetMessage("DragDrop", itm)
				itm.Checked = True
			ElseIf item.Length = 1 Then
				item(0).Checked = True
			End If
		Next
    End Sub

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub
End Class
