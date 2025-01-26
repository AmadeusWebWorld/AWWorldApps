using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AmadeusWeb.IViewer
{
	public  class LibItem
	{
		public LibItem(string path)
		{
			FullPath = path;
			Name = Path.GetFileName(path);
			Folder = Path.GetDirectoryName(path);
			Extension = Path.GetExtension(Name).Replace(".", string.Empty);
		}

		public LibItem(FileInfo fi)
		{
			SetFI(fi);
			FullPath = fi.FullName;
			Folder = fi.DirectoryName;
			Name = fi.Name;
			Extension = fi.Extension.Replace(".", string.Empty);
		}

		#region Properties

		public string Name { get; private set; }

		public string FullPath { get; private set; }

		/// <summary>
		/// used only in search. search in playlist items not needed
		/// </summary>
		public string Folder { get; private set; }

		public FileInfo Info { get; private set; }

		public string Extension { get; private set; }

		public string Meta { get; private set; }

		public long FileSize { get; private set; }

		public DateTime FileDate { get; private set; }

		#endregion

		public static LibItem[] FromList(FileInfo[] list)
		{
			return list.Select(x => new LibItem(x)).ToArray();
		}

		public static string[] ToPaths(IList<LibItem> list)
		{
			return list.Select(x => x.FullPath).ToArray();
		}

		public void CheckInfo()
		{
			if (Info == null)
			{
				Info = new FileInfo(FullPath);
			}
		}

		private List<string> metas = new List<string>();

		public void CheckMeta()
		{
			metas.Clear();
			var exts = new string[] { "srt", "lrc", "txt", "pdf", "img" };
			foreach (var ext in exts)
			{
				var fil = Path.ChangeExtension(FullPath, ext);
				if (File.Exists(fil))
				{
					metas.Add(ext);
				}
			}
			Meta = metas.Count == 0 ? ExtensionFilter.MetaNone : string.Join(", ", metas);
		}

		public void CreateTxtMeta()
		{
			var fil = Path.ChangeExtension(FullPath, "txt");
			File.WriteAllText(fil, string.Empty);
			CheckMeta();
		}

		public void SaveTxtMeta(System.Windows.Forms.TextBox txt)
		{
			var fil = Path.ChangeExtension(FullPath, "txt");
			File.WriteAllText(fil, txt.Text);
			txt.BackColor = System.Drawing.SystemColors.Window;
		}

		public void SetTxt(System.Windows.Forms.TextBox txt)
		{
			txt.Visible = false;
			foreach (var ext in ExtensionFilter.TextExtensions)
			{
				var fil = Path.ChangeExtension(FullPath, "." + ext);
				if (File.Exists(fil))
				{
					txt.Visible = true;
					txt.Text = File.ReadAllText(fil);
					txt.BackColor = System.Drawing.SystemColors.Window;
				}
			}
		}

		private void SetFI(FileInfo fi)
		{
			Info = fi;
			FileDate = fi.LastWriteTime;
			FileSize = fi.Length;
		}

		// http://support.microsoft.com/kb/319399
		public class Sorter : IComparer
		{
			public const int DATEINDEX = 3;

			public const int SIZEINDEX = 1;

			private CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

			#region "Properties: SortColumn, Order"

			public int SortColumn { get; set; }

			public bool OrderDesc { get; set; }

			#endregion

			public int Compare(object xo, object yo)
			{
				var x = (LibItem)xo;
				var y = (LibItem)yo;

				int compareResult = comparer.Compare(Convert(x), Convert(y));

				return compareResult * (OrderDesc ? -1 : 1);
			}

			private IComparable Convert(LibItem itm)
			{
				switch (SortColumn)
				{
					case SIZEINDEX:
						return itm.FileSize;
					case 2:
						return itm.Info.Extension;
					case DATEINDEX:
						return itm.FileDate;
					case 4:
						return itm.Folder;
					default:
						return itm.Name;
				}
			}
		}
	}
}
