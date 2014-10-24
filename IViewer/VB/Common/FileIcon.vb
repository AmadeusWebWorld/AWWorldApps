Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing

Namespace Common 'vbAccelerator.Components.Shell
	''' <summary>
	''' Enables extraction of icons for any file type from
	''' the Shell.
	''' </summary>
	Public Class FileIcon
		Implements IDisposable

#Region "UnmanagedCode"
		Private Const MAX_PATH As Integer = 260

		<StructLayout(LayoutKind.Sequential)> _
		Private Structure SHFILEINFO
			Public hIcon As IntPtr
			Public iIcon As Integer
			Public dwAttributes As Integer
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)> _
			Public szDisplayName As String
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
			Public szTypeName As String
		End Structure

		<DllImport("shell32")> _
		Private Shared Function SHGetFileInfo(ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As UInteger, ByVal uFlags As UInteger) As Integer
		End Function

		<DllImport("user32.dll")> _
		Private Shared Function DestroyIcon(ByVal hIcon As IntPtr) As Integer
		End Function

		Private Const FORMAT_MESSAGE_ALLOCATE_BUFFER As Integer = 256
		Private Const FORMAT_MESSAGE_ARGUMENT_ARRAY As Integer = 8192
		Private Const FORMAT_MESSAGE_FROM_HMODULE As Integer = 2048
		Private Const FORMAT_MESSAGE_FROM_STRING As Integer = 1024
		Private Const FORMAT_MESSAGE_FROM_SYSTEM As Integer = 4096
		Private Const FORMAT_MESSAGE_IGNORE_INSERTS As Integer = 512
		Private Const FORMAT_MESSAGE_MAX_WIDTH_MASK As Integer = 255
		<DllImport("kernel32")> _
		Private Shared Function FormatMessage(ByVal dwFlags As Integer, ByVal lpSource As IntPtr, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByVal lpBuffer As String, ByVal nSize As UInteger, _
		ByVal argumentsLong As Integer) As Integer
		End Function

		<DllImport("kernel32")> _
		Private Shared Function GetLastError() As Integer
		End Function
#End Region

#Region "Member Variables"
		Private m_fileName As String
		Private m_displayName As String
		Private m_typeName As String
		Private m_flags As SHGetFileInfoConstants
		Private fileIcon As Icon
#End Region

#Region "Enumerations"
		''' <summary>
		''' Flags which control FileIcon behaviour
		''' </summary>
		<Flags()> _
		Public Enum SHGetFileInfoConstants As Integer
			''' <summary>
			''' Get icon. Combine with SHGFI_LARGEICON, SHGFI_SMALLICON,
			''' SHGFI_OPENICON, SHGFI_SHELLICONSIZE, SHGFI_LINKOVERLAY,
			''' SHGFI_SELECTED, SHGFI_ADDOVERLAYS to specify icon
			''' size.
			''' </summary>
			SHGFI_ICON = 256
			''' <summary>
			''' Get the Display name of the file.
			''' </summary>
			SHGFI_DISPLAYNAME = 512
			''' <summary>
			''' Get the TypeName of the file.
			''' </summary>
			SHGFI_TYPENAME = 1024
			''' <summary>
			''' Get the attributes of the file.
			''' </summary>
			SHGFI_ATTRIBUTES = 2048
			''' <summary>
			''' Get the icon location (not used in this class)
			''' </summary>
			SHGFI_ICONLOCATION = 4096
			''' <summary>
			''' Get the exe type (not used in this class)
			''' </summary>
			SHGFI_EXETYPE = 8192
			''' <summary>
			''' Get the index of the icon in the System Image List (use
			''' vbAccelerator SystemImageList class instead)
			''' </summary>
			SHGFI_SYSICONINDEX = 16384
			''' <summary>
			''' Put a link overlay on icon 
			''' </summary>
			SHGFI_LINKOVERLAY = 32768
			''' <summary>
			''' Show icon in selected state 
			''' </summary>
			SHGFI_SELECTED = 65536
			''' <summary>
			''' Get only specified attributes (not supported in this class)
			''' </summary>
			SHGFI_ATTR_SPECIFIED = 131072
			''' <summary>
			''' get large icon 
			''' </summary>
			SHGFI_LARGEICON = 0
			''' <summary>
			''' get small icon 
			''' </summary>
			SHGFI_SMALLICON = 1
			''' <summary>
			''' get open icon 
			''' </summary>
			SHGFI_OPENICON = 2
			''' <summary>
			''' get shell size icon 
			''' </summary>
			SHGFI_SHELLICONSIZE = 4
			'SHGFI_PIDL = 0x8, // pszPath is a pidl 
			''' <summary>
			''' Use passed dwFileAttribute
			''' </summary>
			SHGFI_USEFILEATTRIBUTES = 16
			''' <summary>
			''' Apply the appropriate overlays
			''' </summary>
			SHGFI_ADDOVERLAYS = 32
			''' <summary>
			''' Get the index of the overlay (not used in this class)
			''' </summary>
			SHGFI_OVERLAYINDEX = 64
		End Enum
#End Region

#Region "Implementation"
		''' <summary>
		''' Clears up any resources associated with the class
		''' </summary>
		Public Sub Dispose() Implements System.IDisposable.Dispose
			If fileIcon IsNot Nothing Then
				fileIcon.Dispose()
			End If
		End Sub

		''' <summary>
		''' Gets/sets the flags used to extract the icon
		''' </summary>
		Public Property Flags() As FileIcon.SHGetFileInfoConstants
			Get
				Return m_flags
			End Get
			Set(ByVal value As FileIcon.SHGetFileInfoConstants)
				m_flags = value
			End Set
		End Property

		''' <summary>
		''' Gets/sets the filename to get the icon for
		''' </summary>
		Public Property FileName() As String
			Get
				Return m_fileName
			End Get
			Set(ByVal value As String)
				m_fileName = value
			End Set
		End Property

		''' <summary>
		''' Gets the icon for the chosen file
		''' </summary>
		Public ReadOnly Property ShellIcon() As Icon
			Get
				Return fileIcon
			End Get
		End Property

		''' <summary>
		''' Gets the display name for the selected file
		''' if the SHGFI_DISPLAYNAME flag was set.
		''' </summary>
		Public ReadOnly Property DisplayName() As String
			Get
				Return m_displayName
			End Get
		End Property

		''' <summary>
		''' Gets the type name for the selected file
		''' if the SHGFI_TYPENAME flag was set.
		''' </summary>
		Public ReadOnly Property TypeName() As String
			Get
				Return m_typeName
			End Get
		End Property

		''' <summary>
		''' Gets the information for the specified 
		''' file name and flags.
		''' </summary>
		Public Sub GetInfo()
			If fileIcon IsNot Nothing Then
				fileIcon.Dispose()
			End If
			fileIcon = Nothing
			m_typeName = ""
			m_displayName = ""

			Dim shfi As New SHFILEINFO()
			Dim shfiSize As UInteger = CInt(Marshal.SizeOf(shfi.[GetType]()))

			Dim ret As Integer = SHGetFileInfo(m_fileName, 0, shfi, shfiSize, CInt((m_flags)))
			If ret <> 0 Then
				If shfi.hIcon <> IntPtr.Zero Then
					' Now owned by the GDI+ object
					'DestroyIcon(shfi.hIcon);
					fileIcon = System.Drawing.Icon.FromHandle(shfi.hIcon)
				End If
				m_typeName = shfi.szTypeName
				m_displayName = shfi.szDisplayName
			Else

				Dim err As Integer = GetLastError()
				Console.WriteLine("Error {0}", err)
				Dim txtS As New String(Chr(0), 256)
				Dim len As Integer = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM Or FORMAT_MESSAGE_IGNORE_INSERTS, IntPtr.Zero, err, 0, txtS, 256, _
				0)

				' throw exception

				Console.WriteLine("Len {0} text {1}", len, txtS)
			End If
		End Sub

		Public Const DefaultFlags As SHGetFileInfoConstants = SHGetFileInfoConstants.SHGFI_ICON Or SHGetFileInfoConstants.SHGFI_DISPLAYNAME Or SHGetFileInfoConstants.SHGFI_TYPENAME Or SHGetFileInfoConstants.SHGFI_ATTRIBUTES Or SHGetFileInfoConstants.SHGFI_EXETYPE

		''' <summary>
		''' Constructs a new, default instance of the FileIcon
		''' class. Specify the filename and call GetInfo()
		''' to retrieve an icon.
		''' </summary>
		Public Sub New()
			m_flags = DefaultFlags
		End Sub
		''' <summary>
		''' Constructs a new instance of the FileIcon class
		''' and retrieves the icon, display name and type name
		''' for the specified file. 
		''' </summary>
		''' <param name="fileName">The filename to get the icon, 
		''' display name and type name for</param>
		Public Sub New(ByVal fileName As String)
			Me.New()
			Me.m_fileName = fileName
			GetInfo()
		End Sub
		''' <summary>
		''' Constructs a new instance of the FileIcon class
		''' and retrieves the information specified in the 
		''' flags.
		''' </summary>
		''' <param name="fileName">The filename to get information
		''' for</param>
		''' <param name="flags">The flags to use when extracting the
		''' icon and other shell information.</param>
		Public Sub New(ByVal fileName As String, ByVal flags As FileIcon.SHGetFileInfoConstants)
			Me.m_fileName = fileName
			Me.m_flags = flags
			GetInfo()
		End Sub
#End Region

	End Class

End Namespace