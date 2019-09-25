using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Cselian.IViewer.UI
{
	/// <summary>
	/// 
	/// </summary>
	public static class VidListView
	{
		private static bool isFileListMixed;

		public static bool IsFileListMixed
		{
			get
			{
				return isFileListMixed;
			}

			set
			{
				if (isFileListMixed != value)
				{
					if (value)
					{
						Main.Inst.Filelist.Columns.Add("Folder", "Folder").Width = VidEngine.Settings.FilColWidthFolder;
					}
					else
					{
						Main.Inst.Filelist.Columns.RemoveByKey("Folder");
					}

					isFileListMixed = value;
				}
			}
		}

		public static int FlatFolderStringLength { get; set; }

		public static bool ChangingFiles { get; set; }

		public static LibItem LibItem(this ListViewItem from)
		{
			return (LibItem)from.Tag;
		}

		public static ListViewItem HavingLibItem(this ListView lvw, LibItem what)
		{
			return lvw.Items.Cast<ListViewItem>().Single(x => what.Equals(x.Tag));
		}

		public static Tuple<ListViewItem, LibItem> LibItemTuple(this ListViewItem from)
		{
			return new Tuple<ListViewItem,LibItem>(from, (LibItem)from.Tag);
		}

		public static void AddAllIntoList(this LibItem[] list, ListView lvw, ListContext.Types mode)
		{
			VidEngine.ChangingFiles = true;
			foreach (var item in list)
				item.AddIntoList(lvw, mode);

			VidEngine.ChangingFiles = false;
		}

		public static void RemoveFromList(this LibItem what, ListView lvw)
		{
			ListViewItem found = null;
			foreach (ListViewItem item in lvw.Items)
			{
				if (item.LibItem().FullPath == what.FullPath)
				{
					found = item;
					break;
				}
			}

			if (found != null)
			{
				lvw.Items.Remove(found);
			}
		}

		public static void AddIntoList(this LibItem li, ListView lvw, ListContext.Types mode = ListContext.Types.Search)
		{
			var item = new ListViewItem
			{
				Text = li.Name,
				ImageKey = "file",
				Tag = li
			};

			li.CheckInfo();
			li.CheckMeta();

			if (!li.Info.Exists)
			{
				lvw.Items.Add(item);
				return;
			}

			UpdateLvwItem(item, li, lvw, mode);

			lvw.Items.Add(item);
		}

		public static void UpdateLvwItem(this ListViewItem item, LibItem li, ListView lvw, ListContext.Types mode = ListContext.Types.Search)
		{
			item.SubItems.AddRange(new string[]
			{
				li.Info.GetFileSize(),
				li.Info.Extension,
				li.Meta,
				li.Info.LastWriteTime.ToString(UI.VidEngine.Settings.LVWDateTimeFormat)
			});

			if (mode != ListContext.Types.Folder)
			{
				var fol = li.Info.DirectoryName;
				if (mode == ListContext.Types.Flat) fol = "." + fol.Substring(FlatFolderStringLength);
				item.SubItems.Add(fol);
				if (lvw.Name == "playlist") item.SubItems.Add(""); //played
			}

			Core.FileIcon.CheckExtensionExists(li.Info, lvw.SmallImageList, lvw.LargeImageList);

			item.ImageKey = li.Info.Extension;
			item.ImageKey = li.Info.Extension;
		}

		public const int MetaIndex = 3;
		public const int PlayedIndex = 5;

		public static void InitLvw(ListView lvw, bool playlist)
		{
			lvw.Columns.Clear();

			lvw.Columns.Add("Name");
			lvw.Columns[0].Width = VidEngine.Settings.FilColWidthName;

			lvw.Columns.Add("Size");
			lvw.Columns[1].Width = VidEngine.Settings.FilColWidthSize;
			lvw.Columns[1].TextAlign = HorizontalAlignment.Right;

			lvw.Columns.Add("Ext");
			lvw.Columns[2].Width = VidEngine.Settings.FilColWidthExt;

			lvw.Columns.Add("Meta");
			lvw.Columns[MetaIndex].Width = 60;

			lvw.Columns.Add("Modified");
			lvw.Columns[4].Width = VidEngine.Settings.FilColWidthModified;

			lvw.Columns.Add("Played");
			lvw.Columns[PlayedIndex].Width = 60;

			if (playlist)
			{
				lvw.Columns.Add("Folder");
				lvw.Columns[6].Width = VidEngine.Settings.FilColWidthFolder;
			}
			else
			{
				// TODO: sorter for playlist
				lvw.ListViewItemSorter = new Sorter(lvw);
			}
		}

		public static bool HasBroken(this ListView lvw)
		{
			return lvw.Items.Cast<ListViewItem>().Any(x => x.ImageKey == "file");
		}

		public static LibItem[] GetBroken(this ListView lvw)
		{
			return lvw.Items.Cast<ListViewItem>().Where(x => x.ImageKey == "file").Select(x => x.LibItem()).ToArray();
		}

		private class Sorter : IComparer
		{
			private LibItem.Sorter LibItemSorter;

			public Sorter(ListView lvw)
			{
				LibItemSorter = new LibItem.Sorter();
				lvw.ColumnClick += new ColumnClickEventHandler(lvw_ColumnClick);
			}

			public int Compare(object xo, object yo)
			{
				var x = ((ListViewItem)xo).LibItem();
				var y = ((ListViewItem)yo).LibItem();

				return LibItemSorter.Compare(x, y);
			}

			private void lvw_ColumnClick(object sender, ColumnClickEventArgs e)
			{
				// Determine if the clicked column is already the column that is being sorted.
				if (e.Column == LibItemSorter.SortColumn)
				{
					// Reverse the current sort direction for this column.
					LibItemSorter.OrderDesc = !LibItemSorter.OrderDesc; // Asc, Desc are 1,2
				}
				else
				{
					// Set the column number that is to be sorted; default to ascending.
					LibItemSorter.SortColumn = e.Column;
					LibItemSorter.OrderDesc = false;
				}

				((ListView)sender).Sort();
			}
		}
	}
}
