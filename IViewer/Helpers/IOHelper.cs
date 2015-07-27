using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Cselian.IViewer
{
	/// <summary>
	/// Extensions for the IO Namespace
	/// </summary>
	public static class IOHelper
	{
		public static void RunText(string file)
		{
			var fil = Path.Combine(Environment.CurrentDirectory.Replace("bin\\Debug", string.Empty), file + ".txt");
			Run(fil);
		}

		public static void Run(string what, string with = null)
		{
			if (with == null)
				Process.Start(what);
			else
				Process.Start(what, with);
		}

		public static void SortDirectories(this DirectoryInfo[] fols)
		{
			Array.Sort(fols, new DIComparer());
		}

		/// <summary>
		/// Gets the File Size in a readable form
		/// </summary>
		public static string GetFileSize(this FileInfo fi)
		{
			var bytes = (decimal)fi.Length;
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

			return string.Format("{0:F2} b", bytes);
		}

		public static void Overwrite(string file, string contents)
		{
			if (File.Exists(file)) File.Delete(file);
			File.WriteAllText(file, contents);
		}

		public static T Load<T>(string file)
		{
			if (!File.Exists(file)) return default(T);

			var xml = new XmlSerializer(typeof(T));
			var ip = File.OpenRead(file);
			var x = new XmlTextReader(ip);
			var r = xml.Deserialize(x);
			ip.Close();
			return (T)r;
		}

		public static void Save<T>(T what, string file)
		{
			var xml = new XmlSerializer(typeof(T));
			var w = new XmlTextWriter(file, System.Text.Encoding.Default);
			xml.Serialize(w, what);
			w.Close();
		}

		private class DIComparer : IComparer<DirectoryInfo>
		{
			public int Compare(DirectoryInfo x, DirectoryInfo y)
			{
				return x.FullName.CompareTo(y.FullName);
			}
		}
	}
}
