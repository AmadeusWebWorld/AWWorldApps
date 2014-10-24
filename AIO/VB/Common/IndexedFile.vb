Imports System.Data.SqlClient
Imports System.IO

Public Class IndexedFile


	Private _file As String = ""

	Public Property File() As String
		Get
			Return _file
		End Get
		Set(ByVal value As String)
			_file = value
		End Set
	End Property


	Private _path As String = ""

	Public Property Path() As String
		Get
			Return _path
		End Get
		Set(ByVal value As String)
			_path = value
		End Set
	End Property


	Private _extension As String = ""

	Public Property Extension() As String
		Get
			Return _extension
		End Get
		Set(ByVal value As String)
			_extension = value
		End Set
	End Property


	Private _dateModified As DateTime = ""

	Public Property DateModified() As DateTime
		Get
			Return _dateModified
		End Get
		Set(ByVal value As DateTime)
			_dateModified = value
		End Set
	End Property


	Private _attrs As String = ""

	Public Property Attrs() As String
		Get
			Return _attrs
		End Get
		Set(ByVal value As String)
			_attrs = value
		End Set
	End Property

	Public Function GetSubItems() As String()
		Dim s() As String = {Me.Path, Me.Extension, Me.DateModified, Me.Attrs}
		Return s
	End Function



End Class

Friend Class IndexedFileBuilder

	Public Shared ConnStr As String = System.Configuration.ConfigurationManager.ConnectionStrings("Apps").ConnectionString

	Public Shared Function Load(ByVal where As String)
		Dim result As List(Of IndexedFile)
		Using con As New SqlConnection(connstr)
			con.Open()
			Dim cmd As New SqlCommand("select * from files " + where, con)
			cmd.CommandType = CommandType.Text
			Dim dr As SqlDataReader = cmd.ExecuteReader()
			result = CreateList(dr)
		End Using
		Return result
	End Function

	Public Shared Function InsertString(ByVal fi As FileInfo) As String
		Dim str As String = "INSERT INTO Files ([File], [Path], Extension, DateModified, Attrs) VALUES ('{0}','{1}','{2}','{3}','{4}')"
		Return String.Format(str, fi.Name, fi.FullName, fi.Extension, fi.LastWriteTime, fi.Attributes())
	End Function

	Private Shared Function CreateList(ByVal dr As SqlDataReader) As List(Of IndexedFile)
		Dim result As New List(Of IndexedFile)
		Dim fileOrd As Integer = dr.GetOrdinal("file")
		Dim pathOrd As Integer = dr.GetOrdinal("path")
		Dim extensionOrd As Integer = dr.GetOrdinal("extension")
		Dim dateModifiedOrd As Integer = dr.GetOrdinal("dateModified")
		Dim attrsOrd As Integer = dr.GetOrdinal("attrs")

		While dr.Read
			Dim i As New IndexedFile
			If dr.IsDBNull(fileOrd) = False Then i.File = dr.GetString(fileOrd)
			If dr.IsDBNull(pathOrd) = False Then i.Path = dr.GetString(pathOrd)
			If dr.IsDBNull(extensionOrd) = False Then i.Extension = dr.GetString(extensionOrd)
			If dr.IsDBNull(dateModifiedOrd) = False Then i.DateModified = dr.GetDateTime(dateModifiedOrd)
			If dr.IsDBNull(attrsOrd) = False Then i.Attrs = dr.GetString(attrsOrd)
			result.Add(i)
		End While

		Return result
	End Function


End Class