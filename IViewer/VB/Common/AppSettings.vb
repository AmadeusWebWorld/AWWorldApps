Imports System.Configuration
Imports System.Reflection
Imports System.Xml 'For the ConfigSettings
Imports Microsoft.VisualBasic.ApplicationServices 'For AssemblyInfo (Version) 'For AssemblyInfo (Version)

Namespace Common

	Public Enum AppConstants
		FolOrientation
		FolHorzDistance	'Folder Horizontal Distance
		FolVertDistance
		PlsOrientation
		PlsHorzDistance	'Playlist Horizontal Distance
		PlsVertDistance
		SelectorType
		FavoriteFolders
		LVWDateTimeFormat
		FilColWidthName
		FilColWidthExt
		FilColWidthSize
		FilColWidthModified
		FilColWidthFolder
		FolVisibility
	End Enum

	Public Class AppSettings

		Public Shared ReadOnly LegacyLibrary As String = "Time Library.ini"
		Public Shared ReadOnly LogInvalidFiles As String = "InvalidFiles.log"

		Private Shared vals As New Specialized.NameValueCollection

		Shared Sub New()
			For Each key As String In ConfigurationManager.AppSettings.AllKeys
				vals(key) = ConfigurationManager.AppSettings(key)
			Next
		End Sub

		Public Shared Property Favorites() As String()
			Get
				Return Item(AppConstants.FavoriteFolders).Split("|")
			End Get
			Set(ByVal value As String())
				Item(AppConstants.FavoriteFolders) = String.Join("|", value)
			End Set
		End Property

		Public Shared Property Item(ByVal itm As AppConstants) As String
			Get
				Return Item(itm.ToString)
			End Get
			Set(ByVal value As String)
				Item(itm.ToString) = value
			End Set
		End Property

		Public Shared Property Item(ByVal key As String) As String
			Get
				Return vals(key)
			End Get
			Set(ByVal value As String)
				If vals(key) <> value Then
					WriteSetting(key, value)
					vals(key) = value
				End If
			End Set
		End Property

		Public Shared Function GetVersion() As Version
			Dim a = GetType(AppSettings).Assembly
			Dim ver = New AssemblyInfo(a).Version
			Return ver

			'Dim dt As DateTime
			'Dim revision = Item("LastBuildRevision")

			'If Date.TryParse(AppSettings.Item("LastBuildDate"), dt) Then
			'	Dim f As New IO.FileInfo(a.Location)
			'	If f.LastWriteTime > dt Then
			'		AppSettings.Item("LastBuildDate") = f.LastWriteTime
			'		revision += 1
			'		AppSettings.Item("LastBuildRevision") = revision
			'	End If
			'End If

			'Return ver
		End Function

#Region "ConfigSettings"

		Private Shared Sub WriteSetting(ByVal key As String, ByVal value As String)
			' load config document for current assembly
			Dim doc As XmlDocument = loadConfigDocument()

			' retrieve appSettings node
			Dim node As XmlNode = doc.SelectSingleNode("//appSettings")

			If node Is Nothing Then
				Throw New InvalidOperationException("appSettings section not found in config file.")
			End If

			Try
				' select the 'add' element that contains the key
				Dim elem As XmlElement = DirectCast(node.SelectSingleNode(String.Format("//add[@key='{0}']", key)), XmlElement)

				If elem IsNot Nothing Then
					' add value for key
					elem.SetAttribute("value", value)
				Else
					' key was not found so create the 'add' element 
					' and set it's key/value attributes 
					elem = doc.CreateElement("add")
					elem.SetAttribute("key", key)
					elem.SetAttribute("value", value)
					node.AppendChild(elem)
				End If
				doc.Save(ConfigFilePath)
			Catch
				Throw
			End Try
		End Sub

		Private Shared Function loadConfigDocument() As XmlDocument
			Dim doc As XmlDocument = Nothing
			Try
				doc = New XmlDocument()
				doc.Load(ConfigFilePath)
				Return doc
			Catch e As System.IO.FileNotFoundException
				Throw New Exception("No configuration file found.", e)
			End Try
		End Function

		Private Shared _configFilePath As String = Assembly.GetExecutingAssembly().Location + ".config"

		Public Shared ReadOnly Property ConfigFilePath() As String
			Get
				Return _configFilePath
			End Get
		End Property

#End Region

	End Class

End Namespace