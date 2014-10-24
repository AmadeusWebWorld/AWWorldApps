using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cselian.Core
{
	//vbAccelerator.Components.Shell
	/// <summary>
	/// Enables extraction of icons for any file type from
	/// the Shell.
	/// </summary>
	public class FileIcon : IDisposable
	{
		#region Extensions

		public static string CheckExtensionExists(string file, params ImageList[] lists)
		{
			var key = Path.GetExtension(file).ToLower();
			CheckExtensionExists(key, file, lists);
			return key;
		}

		public static void CheckExtensionExists(FileInfo fi, params ImageList[] lists)
		{
			CheckExtensionExists(fi.Extension.ToLower(), fi.FullName, lists);
		}

		public static void CheckFolExists(string fol, params ImageList[] lists)
		{
			CheckExtensionExists("folder", fol, lists);
		}

		private static void CheckExtensionExists(string key, string file, params ImageList[] lists)
		{
			if (lists[0].Images.ContainsKey(key)) return;

			var ic = new FileIcon(file, FileIcon.DefaultFlags | SHGetFileInfoConstants.SHGFI_LARGEICON);
			if (ic.ShellIcon == null) return;

			foreach (var list in lists)
			{
				list.Images.Add(key, ic.ShellIcon);
			}
		}

		#endregion

		#region "UnmanagedCode"

		private const int MAX_PATH = 260;

		[StructLayout(LayoutKind.Sequential)]
		private struct SHFILEINFO
		{
			public IntPtr hIcon;
			public int iIcon;
			public int dwAttributes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = FileIcon.MAX_PATH)]
			public string szDisplayName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}

		[DllImport("shell32")]
		private static extern int SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

		[DllImport("user32.dll")]
		private static extern int DestroyIcon(IntPtr hIcon);

		private const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;
		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;
		private const int FORMAT_MESSAGE_FROM_HMODULE = 2048;
		private const int FORMAT_MESSAGE_FROM_STRING = 1024;
		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;
		private const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 255;
		[DllImport("kernel32")]
		private static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, uint nSize, int argumentsLong);

		[DllImport("kernel32")]
		private static extern int GetLastError();
		#endregion

		#region "Member Variables"
		private string m_fileName;
		private string m_displayName;
		private string m_typeName;
		private SHGetFileInfoConstants m_flags;
		#endregion
		private Icon fileIcon;

		#region "Enumerations"
		/// <summary>
		/// Flags which control FileIcon behaviour
		/// </summary>
		[Flags()]
		public enum SHGetFileInfoConstants : int
		{
			/// <summary>
			/// Get icon. Combine with SHGFI_LARGEICON, SHGFI_SMALLICON,
			/// SHGFI_OPENICON, SHGFI_SHELLICONSIZE, SHGFI_LINKOVERLAY,
			/// SHGFI_SELECTED, SHGFI_ADDOVERLAYS to specify icon
			/// size.
			/// </summary>
			SHGFI_ICON = 256,
			/// <summary>
			/// Get the Display name of the file.
			/// </summary>
			SHGFI_DISPLAYNAME = 512,
			/// <summary>
			/// Get the TypeName of the file.
			/// </summary>
			SHGFI_TYPENAME = 1024,
			/// <summary>
			/// Get the attributes of the file.
			/// </summary>
			SHGFI_ATTRIBUTES = 2048,
			/// <summary>
			/// Get the icon location (not used in this class)
			/// </summary>
			SHGFI_ICONLOCATION = 4096,
			/// <summary>
			/// Get the exe type (not used in this class)
			/// </summary>
			SHGFI_EXETYPE = 8192,
			/// <summary>
			/// Get the index of the icon in the System Image List (use
			/// vbAccelerator SystemImageList class instead)
			/// </summary>
			SHGFI_SYSICONINDEX = 16384,
			/// <summary>
			/// Put a link overlay on icon 
			/// </summary>
			SHGFI_LINKOVERLAY = 32768,
			/// <summary>
			/// Show icon in selected state 
			/// </summary>
			SHGFI_SELECTED = 65536,
			/// <summary>
			/// Get only specified attributes (not supported in this class)
			/// </summary>
			SHGFI_ATTR_SPECIFIED = 131072,
			/// <summary>
			/// get large icon 
			/// </summary>
			SHGFI_LARGEICON = 0,
			/// <summary>
			/// get small icon 
			/// </summary>
			SHGFI_SMALLICON = 1,
			/// <summary>
			/// get open icon 
			/// </summary>
			SHGFI_OPENICON = 2,
			/// <summary>
			/// get shell size icon 
			/// </summary>
			SHGFI_SHELLICONSIZE = 4,
			//SHGFI_PIDL = 0x8, // pszPath is a pidl 
			/// <summary>
			/// Use passed dwFileAttribute
			/// </summary>
			SHGFI_USEFILEATTRIBUTES = 16,
			/// <summary>
			/// Apply the appropriate overlays
			/// </summary>
			SHGFI_ADDOVERLAYS = 32,
			/// <summary>
			/// Get the index of the overlay (not used in this class)
			/// </summary>
			SHGFI_OVERLAYINDEX = 64
		}
		#endregion

		#region "Implementation"
		/// <summary>
		/// Clears up any resources associated with the class
		/// </summary>
		public void Dispose()
		{
			if (fileIcon != null)
			{
				fileIcon.Dispose();
			}
		}

		/// <summary>
		/// Gets/sets the flags used to extract the icon
		/// </summary>
		public FileIcon.SHGetFileInfoConstants Flags
		{
			get { return m_flags; }
			set { m_flags = value; }
		}

		/// <summary>
		/// Gets/sets the filename to get the icon for
		/// </summary>
		public string FileName
		{
			get { return m_fileName; }
			set { m_fileName = value; }
		}

		/// <summary>
		/// Gets the icon for the chosen file
		/// </summary>
		public Icon ShellIcon
		{
			get { return fileIcon; }
		}

		/// <summary>
		/// Gets the display name for the selected file
		/// if the SHGFI_DISPLAYNAME flag was set.
		/// </summary>
		public string DisplayName
		{
			get { return m_displayName; }
		}

		/// <summary>
		/// Gets the type name for the selected file
		/// if the SHGFI_TYPENAME flag was set.
		/// </summary>
		public string TypeName
		{
			get { return m_typeName; }
		}

		/// <summary>
		/// Gets the information for the specified 
		/// file name and flags.
		/// </summary>
		public void GetInfo()
		{
			if (fileIcon != null)
			{
				fileIcon.Dispose();
			}
			fileIcon = null;
			m_typeName = "";
			m_displayName = "";

			var shfi = new SHFILEINFO();
			var shfiSize = Convert.ToUInt32(Marshal.SizeOf(shfi.GetType()));

			int ret = SHGetFileInfo(m_fileName, 0, ref shfi, shfiSize, Convert.ToUInt32((m_flags)));
			if (ret != 0)
			{
				if (shfi.hIcon != IntPtr.Zero)
				{
					// Now owned by the GDI+ object
					//DestroyIcon(shfi.hIcon);
					fileIcon = System.Drawing.Icon.FromHandle(shfi.hIcon);
				}

				m_typeName = shfi.szTypeName;
				m_displayName = shfi.szDisplayName;

			}
			else
			{
				var err = GetLastError();
				Console.WriteLine("Error {0}", err);
				var txtS = new string(Convert.ToChar(0), 256);
				var len = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS, IntPtr.Zero, err, 0, txtS, 256, 0);

				// throw exception

				Console.WriteLine("Len {0} text {1}", len, txtS);
			}
		}


		public const SHGetFileInfoConstants DefaultFlags = SHGetFileInfoConstants.SHGFI_ICON | SHGetFileInfoConstants.SHGFI_DISPLAYNAME | SHGetFileInfoConstants.SHGFI_TYPENAME | SHGetFileInfoConstants.SHGFI_ATTRIBUTES | SHGetFileInfoConstants.SHGFI_EXETYPE;
		/// <summary>
		/// Constructs a new, default instance of the FileIcon
		/// class. Specify the filename and call GetInfo()
		/// to retrieve an icon.
		/// </summary>
		public FileIcon()
		{
			m_flags = DefaultFlags;
		}
		/// <summary>
		/// Constructs a new instance of the FileIcon class
		/// and retrieves the icon, display name and type name
		/// for the specified file. 
		/// </summary>
		/// <param name="fileName">The filename to get the icon, 
		/// display name and type name for</param>
		public FileIcon(string fileName)
			: this()
		{
			this.m_fileName = fileName;
			GetInfo();
		}
		/// <summary>
		/// Constructs a new instance of the FileIcon class
		/// and retrieves the information specified in the 
		/// flags.
		/// </summary>
		/// <param name="fileName">The filename to get information
		/// for</param>
		/// <param name="flags">The flags to use when extracting the
		/// icon and other shell information.</param>
		public FileIcon(string fileName, FileIcon.SHGetFileInfoConstants flags)
		{
			this.m_fileName = fileName;
			this.m_flags = flags;
			GetInfo();
		}
		#endregion
	}
}
