Imports System.IO

Public Class FtpInfo

	Private Shared cred As FtpInfo, options As New List(Of FtpInfo)

	Public Shared ReadOnly Property Selected() As FtpInfo
		Get
			Return cred
		End Get
	End Property

	Private Const CONFIGFILE As String = "FTPSync.ini"
	Private Const [Default] = "Default=c:\web|ftp://ftp.website.com/www/|user|"

#Region "Options - Loading / Selecting"

	Shared Sub New()
		ReadOptions()

		If Program.SilentMode Then Exit Sub
		cred = Nothing
		If HasMultipleOptions Then SelectOption()
	End Sub

	Private Shared Sub ReadOptions()
		Dim lines() As String
		If File.Exists(CONFIGFILE) Then
			lines = File.ReadAllLines(CONFIGFILE)
		Else
			lines = New String() {[Default]}
		End If

		options.Clear()
		For Each line In lines
			Dim nv = line.Split("=", 2, StringSplitOptions.None)
			cred = New FtpInfo(nv(1))
			cred.Name = nv(0)
			options.Add(cred)
		Next
	End Sub

	Public Shared ReadOnly Property HasMultipleOptions() As Boolean
		Get
			Return options.Count > 1
		End Get
	End Property

	'Consider making separate method as in IViewer
	Public Shared Sub SelectOption()
		Dim frm As New Form()
		frm.Height = 150 : frm.Width = 450 : frm.Text = "Select FTP Connection / Folder" : frm.StartPosition = FormStartPosition.CenterScreen : frm.KeyPreview = True
		AddHandler frm.KeyDown, AddressOf frm_KeyDown
		Dim lst As New ListBox
		lst.Items.AddRange(options.ToArray)
		If cred Is Nothing Then lst.SelectedIndex = 0 Else lst.SelectedItem = cred
		lst.Dock = DockStyle.Fill
		frm.Controls.Add(lst)
		frm.ShowDialog()
		cred = CType(lst.SelectedItem, FtpInfo)
		'MessageBox.Show("Chosen " & Selected.ToString)
	End Sub

	Public Shared Sub SetSelected(ByVal name As String)
		For Each opt In FtpInfo.options
			If opt.Name = name Then cred = opt : Exit For
		Next
	End Sub

	Private Shared Sub frm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		If e.KeyCode = Keys.F5 Then
			ReadOptions()
			Dim lst As ListBox = CType(CType(sender, Form).Controls(0), ListBox)
			lst.Items.Clear()
			lst.Items.AddRange(options.ToArray)
			If cred Is Nothing Then lst.SelectedIndex = 0 Else lst.SelectedItem = cred
		End If
		If e.KeyCode = Keys.Return Then CType(sender, Form).Close()
	End Sub

#End Region

#Region "Properties / Instance Members"

	Private Sub New(ByVal val As String)
		Dim vals = val.Split("|")
		If vals.Length > 0 Then Value(Names.LocalFolder) = vals(0)
		If vals.Length > 1 Then Value(Names.FtpFolder) = vals(1)
		If vals.Length > 2 Then Value(Names.FtpUsername) = vals(2)
		If vals.Length > 3 Then Value(Names.FtpPassword) = vals(3)
	End Sub

	Public Name As String
	Dim _localFolder As String
	Dim _ftpFolder As String
	Dim _username As String
	Dim _password As String

	Public Property LocalFolder() As String
		Get
			Return _localFolder
		End Get
		Set(ByVal value As String)
			_localFolder = value
		End Set
	End Property

	Public Property FtpFolder() As String
		Get
			Return _ftpFolder
		End Get
		Set(ByVal value As String)
			_ftpFolder = value
		End Set
	End Property

	Public Property Username() As String
		Get
			Return _username
		End Get
		Set(ByVal value As String)
			_username = value
		End Set
	End Property

	Public Property Password() As String
		Get
			Return _password
		End Get
		Set(ByVal value As String)
			_password = value
		End Set
	End Property

	Public Property Value(ByVal name As Names)
		Get
			Select Case name
				Case Names.FtpFolder
					Return Me.FtpFolder
				Case Names.FtpPassword
					Return Me.Password
				Case Names.FtpUsername
					Return Me.Username
				Case Names.LocalFolder
					Return Me.LocalFolder
				Case Else
					Throw New NotSupportedException
			End Select
		End Get
		Set(ByVal value)
			Select Case name
				Case Names.FtpFolder
					Me.FtpFolder = value
				Case Names.FtpPassword
					Me.Password = value
				Case Names.FtpUsername
					Me.Username = value
				Case Names.LocalFolder
					Me.LocalFolder = value
				Case Else
					Throw New NotSupportedException
			End Select
		End Set
	End Property

	Public Overrides Function Equals(ByVal obj As Object) As Boolean
		Return Name.Equals(CType(obj, FtpInfo).Name)
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return Name.GetHashCode()
	End Function

	Public Overrides Function ToString() As String
		Return String.Format("{0} ({1} on {2} @ {3})", Name, Username, FtpFolder, LocalFolder)
	End Function

#End Region

	Public Shared Function GetKey(ByVal key As Names) As String
		GetKey = Selected.Value(key)
		Dim cVal As String = GetKey

		'If String.IsNullOrEmpty(cVal) Then
		'dont show a textbox for FTP user / password if the ftp is null
		Dim ftpFor As String = IIf(key = Names.FtpUsername Or key = Names.FtpPassword, " for " + FtpInfo.Selected.FtpFolder, String.Empty)
		cVal = InputBox(key.ToString + ftpFor, "App Settings", cVal)
		'End If

		If cVal <> GetKey And String.IsNullOrEmpty(cVal) = False Then
			GetKey = cVal
			'FtpInfo.Selected.Value(key) = 
			'config(Array.IndexOf(configNames, cKey)) = GetKey
			'If File.Exists(CONFIGFILE) Then File.Delete(CONFIGFILE)
			'File.WriteAllText(CONFIGFILE, String.Join("|", config))
		End If
	End Function


End Class
