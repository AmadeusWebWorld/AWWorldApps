Imports System.IO

Namespace Common
	Public Class LvwItem
		Inherits ListViewItem

		'http://support.microsoft.com/kb/319399
		Public Class Sorter
			Implements IComparer

			Public Const DATEINDEX As Integer = 3
			Public Const SIZEINDEX As Integer = 1

			Private comparer As New CaseInsensitiveComparer

			Public CompareCount As Long = 0	'for getting performance

#Region "Properties: SortColumn, Order"

			Private _columnIndex As Integer = 1
			Private _order As SortOrder = SortOrder.None

			Public Property SortColumn() As Integer
				Set(ByVal Value As Integer)
					_columnIndex = Value
				End Set

				Get
					Return _columnIndex
				End Get
			End Property

			Public Property Order() As SortOrder
				Set(ByVal Value As SortOrder)
					_order = Value
				End Set

				Get
					Return _order
				End Get
			End Property

#End Region

			Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
				Dim xItm As LvwItem = CType(x, LvwItem)
				Dim yItm As LvwItem = CType(y, LvwItem)

				If xItm.SubItems.Count <= _columnIndex Or yItm.SubItems.Count <= _columnIndex Then
					Return 0
				Else
					Dim compareResult As Integer = comparer.Compare(Convert(xItm), Convert(yItm))

					If _order = SortOrder.Ascending Then
						Return compareResult
					ElseIf _order = SortOrder.Descending Then
						Return -compareResult
					Else
						Return 0
					End If
				End If

			End Function

			Private Function Convert(ByVal itm As LvwItem) As Object
				If _columnIndex = DATEINDEX Then
					CompareCount += 1
					Return itm.FileDate
				ElseIf _columnIndex = SIZEINDEX Then
					Return itm.FileSize
				Else
					Return itm.SubItems(_columnIndex).Text
				End If
			End Function

		End Class

		Public Enum ItemType
			SingleFolder
			Mixed
		End Enum

		Public Overrides Function Clone() As Object
			Dim newItm As LvwItem = MyBase.Clone()
			newItm.Path = Path
			newItm.Folder = Folder
			newItm.FileSize = FileSize
			newItm.FileDate = FileDate
			Return newItm
		End Function

		Public Path As String
		Public Folder As String	'used only in search. search in playlist items not needed
		Public FileSize As Integer '
		Public FileDate As DateTime

		Public Sub New()

		End Sub

		Public Sub New(ByVal fi As FileInfo, Optional ByVal lvw As ListView = Nothing, Optional ByVal type As ItemType = ItemType.SingleFolder)
			'Dim fil As ListViewItem = Me.ListView.Items.Add(fi.FullName, fi.Name, "file")
			Me.Path = fi.FullName
			Me.Folder = fi.DirectoryName
			Me.Text = fi.Name
			Me.ImageKey = "file"
			Me.FileDate = fi.LastWriteTime
			If fi.Exists Then
				Me.SubItems.AddRange(New String() { _
				IOUtils.GetFileSize(fi.Length) _
				, fi.Extension _
				, fi.LastWriteTime.ToString(AppSettings.Item(AppConstants.LVWDateTimeFormat))})
				Me.FileSize = fi.Length
				If type = ItemType.Mixed Then Me.SubItems.Add(fi.DirectoryName())
			End If

			If lvw IsNot Nothing Then
				If Not lvw.SmallImageList.Images.ContainsKey(fi.Extension) Then

					Dim ic As New FileIcon(Me.Path, FileIcon.DefaultFlags Or FileIcon.SHGetFileInfoConstants.SHGFI_LARGEICON)
					If ic.ShellIcon IsNot Nothing Then
						lvw.SmallImageList.Images.Add(fi.Extension, ic.ShellIcon())
						lvw.LargeImageList.Images.Add(fi.Extension, ic.ShellIcon())
						Me.ImageKey = fi.Extension
					End If
				Else
					Me.ImageKey = fi.Extension
				End If
			End If

		End Sub

	End Class

End Namespace

