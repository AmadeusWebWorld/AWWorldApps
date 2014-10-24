using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Cselian.FTPSync
{
	/// <summary>
	/// 
	/// </summary>
	public static class IOHelper
	{
		public static string Encode(string txt)
		{
			var bytes = ASCIIEncoding.ASCII.GetBytes(txt);
			return Convert.ToBase64String(bytes);
		}

		public static string Decode(string txt)
		{
			var bytes = Convert.FromBase64String(txt);
			return ASCIIEncoding.ASCII.GetString(bytes);
		}

		public static void Run(string what, string with = null)
		{
			if (with == null)
				Process.Start(what);
			else
				Process.Start(what, with);
		}

		public static void RunInNotepad(string what)
		{
			Run("notepad.exe", what);
		}

		public static string EnsureEndsWith(string text, string what = "/")
		{
			return text + (text.EndsWith(what) ? string.Empty : what);
		}

		/// <summary>
		/// Gets the File Size in a readable form
		/// </summary>
		public static string GetFileSize(FileInfo fi)
		{
			var bytes = fi.Length;
			if (bytes > 1024 * 1024 * 1024)
			{
				return string.Format("{0:F2} GB", bytes / 1024 / 1024 / 1024);
			}

			if (bytes > 1024 * 1024)
			{
				return string.Format("{0:F2} MB", bytes / 1024 / 1024);
			}

			if (bytes > 1024)
			{
				return string.Format("{0:F2} KB", bytes / 1024);
			}

			return string.Format("{0:F2}  b", bytes);
		}
	}
}
