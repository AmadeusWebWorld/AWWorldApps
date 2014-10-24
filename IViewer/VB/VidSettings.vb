
Partial Public Class Vid

	Public Property Settings(ByVal itm As AppConstants) As String
		Get
			Return AppSettings.Item(itm)
		End Get
		Set(ByVal value As String)
			AppSettings.Item(itm) = value
		End Set
	End Property

	Public Property Settings(ByVal key As String) As String
		Get
			Return AppSettings.Item(key)
		End Get
		Set(ByVal value As String)
			AppSettings.Item(key) = value
		End Set
	End Property

	Private Sub StoreConfig(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
		For Each c As ColumnHeader In fils.Columns
			Settings("FilColWidth" & c.Text) = c.Width
		Next

		If IO.File.Exists("..\..\app.config") Then
			IO.File.Copy(AppSettings.ConfigFilePath, "..\..\app.config", True)
		End If
	End Sub

End Class
