using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

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


		private static string DiffApp = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"3p\TortoiseGitMerge.exe");

		public static void DiffOrDelete(string root, string mine)
		{
			if (File.ReadAllText(root) == File.ReadAllText(mine))
			{
				MessageBox.Show("Files are same, deleting mine");
				File.Delete(mine);
				return;
			}

			Run(DiffApp, root + " " + mine);
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
			return GetFileSize(fi.Length);
		}

		public static string GetFileSize(long bytes)
		{
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

		public static string GetFolSize(DirectoryInfo di, List<string> exclude = null)
		{
			if (di.Exists == false) return "m";
			long size = 0;
			foreach (var item in di.GetFiles())
			{
				if (exclude != null && exclude.Contains(item.Name.ToLower())) continue;
				if (item.Name.StartsWith("_")) continue;
				size += item.Length;
			}
			return GetFileSize(size);
		}
	}
}
