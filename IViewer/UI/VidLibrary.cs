using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	/// <summary>
	/// 
	/// </summary>
	public static class VidLibrary
	{
		static VidLibrary()
		{
			Refresh();
		}

		public static bool FileNotFound { get; private set; }

		public static LibItem[] AllFiles { get; private set; }

		public static void Refresh()
		{
			if (!File.Exists(VidEngine.LegacyLibrary))
			{
				FileNotFound = true;
				AllFiles = new LibItem[] { };
				return;
			}

			FileNotFound = false;
			var list = new List<LibItem>();
			foreach (string lin in File.ReadAllLines(VidEngine.LegacyLibrary))
			{
				if (!string.IsNullOrEmpty(lin))
				{
					list.Add(new LibItem(lin));
				}
			}

			// TODOC: list.Sort();
			AllFiles = list.ToArray();
		}

		public static bool Save()
		{
			var dlg = new UserInput(VidEngine.Settings.KnownFolders, null, true, "save to library");
			if (dlg.ShowDialog() != DialogResult.OK)
			{
				return false;
			}

			var fols = dlg.SelectedItems;
			var files = new List<LibItem>();

			foreach (var path in fols)
			{
				var fol = new DirectoryInfo(path);
				if (fol.Exists)
				{
					foreach (var f in fol.GetFiles("*.mp3", SearchOption.AllDirectories))
					{
						files.Add(new LibItem(f));
					}
				}
			}

			File.WriteAllLines(VidEngine.LegacyLibrary, LibItem.ToPaths(files));
			AllFiles = files.ToArray();
			MessageBox.Show(string.Format("Found {0} items in {1}", files.Count, string.Join(", ", fols)));
			return true;
		}

		public static LibItem[] LoadItems(this ListContext ctx)
		{
			if (ctx.List != null) return ctx.List;

			switch (ctx.Type)
			{
				case ListContext.Types.All:
					return AllFiles;
				case ListContext.Types.Folder:
					{
						var fol = new DirectoryInfo(ctx.Folder);
						if (!fol.Exists) return new LibItem[] { };

						var filter = string.IsNullOrEmpty(ctx.SubFilter) ? "*" : "*" + ctx.SubFilter + "*";
						var files = fol.GetFiles(filter, SearchOption.TopDirectoryOnly);

						if (ctx.Filter != null) files = files.Where(x => ctx.Filter.Include(x)).ToArray();

						return LibItem.FromList(files);
					}
				case ListContext.Types.Flat:
					return Flatten(ctx.Folder);
				case ListContext.Types.Search:
					return Search(ctx.SearchMode, ctx.SearchText);
				case ListContext.Types.Group:
					return new LibItem[] { };
				default:
					throw new System.NotImplementedException("Unknown List Context Type" + ctx.Type.ToString());
			}
		}

		public static LibItem[] Search(SearchMode mode, string text)
		{
			return AllFiles.Where(x => Match(x, mode, text)).ToArray();
		}

		public static LibItem[] Flatten(string folder)
		{
			return AllFiles.Where(x => x.Folder.StartsWith(folder)).ToArray();
		}

		private static bool Match(LibItem item, SearchMode mode, string text)
		{
			var what = StringOf(item, mode);
			if (mode == SearchMode.ExactFileName) return what == text;
			return what.IndexOf(text, System.StringComparison.InvariantCultureIgnoreCase) != -1;
		}

		private static string StringOf(LibItem itm, SearchMode mode)
		{
			switch (mode)
			{
				case SearchMode.FileName:
				case SearchMode.ExactFileName:
					return itm.Name;
				case SearchMode.FullPath:
					return itm.FullPath;
				case SearchMode.Folder:
					return itm.Folder;
				default:
					throw new System.NotSupportedException("Unknown SearchMode " + mode.ToString());
			}
		}
	}
}
