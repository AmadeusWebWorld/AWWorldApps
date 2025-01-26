using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Cselian.Core;

namespace AmadeusWeb.WinXT
{
	public class MenuBuilder
	{
		private readonly ToolStripMenuItem itemsMnu, computerMnu, recentMnu;
		private readonly ToolStripSeparator sepItems, sepComp, sepRecent;
		private readonly List<string> Recent = new List<string>();
		private readonly string RecentFile = "Recent.txt";
		private LoadTimer<StoreType> lastChange, lastLoad;

		static MenuBuilder()
		{
			StoreHelper.RegisterAlias<DirItem>("Folders");
		}

		public MenuBuilder(ToolStripMenuItem items, ToolStripMenuItem computer, ToolStripMenuItem recent)
		{
			itemsMnu = items;
			computerMnu = computer;
			recentMnu = recent;

			sepItems = (ToolStripSeparator)items.DropDownItems[0];
			sepComp = (ToolStripSeparator)computer.DropDownItems[0];
			sepRecent = (ToolStripSeparator)recentMnu.DropDownItems[0];

			lastChange = new LoadTimer<StoreType>();
			lastLoad = new LoadTimer<StoreType>();

			ResetDrives();
			LoadRecent();
			RootFolder = StoreHelper.Read<DirItem>() ?? StoreHelper.Save(new DirItem { Text = "Root", Children = new List<DirItem>() });
		}

		public enum StoreType
		{
			Folders,
			Recent,
			Faves
		}

		public DirItem RootFolder { get; set; }

		public void OpenFolder(DirItem di)
		{
			var root = di.OpenAsRoot ? "/root, " : string.Empty;
			var psi = new ProcessStartInfo("explorer", string.Format("/e, {1}\"{0}\"", di.Path, root));
			psi.WindowStyle = ProcessWindowStyle.Maximized;
			Process.Start(psi);
		}

		public void ResetDrives()
		{
			ClearTillSep(computerMnu);

			foreach (var item in DriveInfo.GetDrives())
			{
				if (!item.IsReady) continue;
				var ix = computerMnu.DropDownItems.IndexOf(sepComp);
				computerMnu.DropDownItems.Insert(ix, new TSFolderItem(item.RootDirectory, true, FolderMenu_Click, null));
			}
		}

		public bool AddIfFolder(DirItem to, string fol, string text = null)
		{
			if (!Directory.Exists(fol))
			{
				return false;
			}

			var di = new DirItem(fol);
			if (text != null)
			{
				di.Text = text;
			}

			to.AddChild(di);
			lastChange.Set(StoreType.Folders);
			return true;
		}

		public void SaveRoot(DirItem root)
		{
			StoreHelper.Save(RootFolder = root);
			lastChange.Set(StoreType.Folders);
		}

		#region Recent

		public void ClearRecent()
		{
			if (File.Exists(RecentFile)) File.Delete(RecentFile);
			Recent.Clear();
			ClearTillSep(recentMnu);
		}

		public void AddRecent(string fol)
		{
			OnOpeningEF(new DirectoryInfo(fol));
		}

		public void SaveRecent()
		{
			if (File.Exists(RecentFile)) File.Delete(RecentFile);
			File.WriteAllLines(RecentFile, Recent.ToArray());
		}

		public DirItem[] GetRecent()
		{
			return Recent.Select(x => new DirItem(x)).ToArray();
		}

		#endregion

		public bool NeedsChange(StoreType what)
		{
			return lastChange.Gt(lastLoad, what);
		}

		public void Loaded(StoreType what)
		{
			lastLoad.Set(what);
		}

		#region Private

		private void ClearTillSep(ToolStripMenuItem mnu)
		{
			while (mnu.DropDownItems.Count > 0)
			{
				if (mnu.DropDownItems[0] is ToolStripSeparator) break;
				mnu.DropDownItems.RemoveAt(0);
			}
		}

		private void FolderMenu_Click(object sender, EventArgs e)
		{
			var di = ((TSFolderItem)sender).Dir;
			OnOpeningEF(di);
			OpenFolder(new DirItem { Path = di.FullName });
		}

		private void OnOpeningEF(DirectoryInfo di)
		{
			if (Recent.Contains(di.FullName) == false)
			{
				Recent.Add(di.FullName);
				var ix = recentMnu.DropDownItems.IndexOf(sepRecent);
				recentMnu.DropDownItems.Insert(ix, new TSFolderItem(di, false, FolderMenu_Click, Recent));
				SaveRecent();
				lastChange.Set(StoreType.Recent);
			}
		}

		private void LoadRecent()
		{
			if (File.Exists(RecentFile))
			{
				foreach (var item in File.ReadAllLines(RecentFile))
				{
					if (string.IsNullOrEmpty(item)) continue;
					OnOpeningEF(new DirectoryInfo(item));
				}
			}
		}

		#endregion

		private class TSFolderItem : ToolStripMenuItem
		{
			private EventHandler CBClick;

			public TSFolderItem(DirectoryInfo di, bool expandSubDirs, EventHandler click, List<string> recent)
			{
				Dir = di;
				Text = di.Name;
				CBClick = click;
				Click += click;
				if (expandSubDirs && di.GetDirectories().Length > 0)
				{
					DropDownItems.Add("to expand");
					DropDownOpening += new EventHandler(TSFolderItem_DropDownOpening);
				}
				else if (expandSubDirs == false)
				{
					ShortcutKeys = Keys.Alt | (Keys)(112 + (recent.IndexOf(di.FullName) % 12));
				}
			}

			public DirectoryInfo Dir { get; private set; }

			private void TSFolderItem_DropDownOpening(object sender, EventArgs e)
			{
				DropDownItems.Clear();
				foreach (var item in Dir.GetDirectories())
				{
					if (item.Attributes.HasBitflag(FileAttributes.System, FileAttributes.Hidden)) continue;
					DropDownItems.Add(new TSFolderItem(item, true, bubbleItem_Click, null));
				}

				DropDownOpening -= TSFolderItem_DropDownOpening;
			}

			private void bubbleItem_Click(object sender, EventArgs e)
			{
				CBClick(sender, e);
			}
		}
	}
}
