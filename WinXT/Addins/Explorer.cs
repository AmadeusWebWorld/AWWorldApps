using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cselian.Utilities.WinXT.Addins
{
	public partial class Explorer : UserControl, ICsnExplorer
	{
		public event EventHandler<XplFolderSelectEventArgs> FolderSelected;

		public event EventHandler<XplFileSelectEventArgs> FileSelected;

		public Explorer(Control parent)
		{
			parent.SuspendLayout();

			InitializeComponent();
			XplCtl.BeforeExpand += TNFolderItem.TNFolderItem_BeforeExpand;
			XplCtl.AfterSelect += new TreeViewEventHandler(XplCtl_AfterSelect);
			FileCtl.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(FileCtl_ItemSelectionChanged);
			FilterCtl.TextChanged += new EventHandler(TxtCtl_TextChanged);
			ExtnCtl.TextChanged += new EventHandler(TxtCtl_TextChanged);
			ResetDrives();

			parent.Controls.Add(this);
			Dock = DockStyle.Fill;
			parent.ResumeLayout();
		}

		void TxtCtl_TextChanged(object sender, EventArgs e)
		{
			if (di != null) LoadFolder();
		}

		void FileCtl_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected == false) return;
			var i = e.Item as TNFileItem;
			if (FileSelected!= null)
				FileSelected(this, new XplFileSelectEventArgs(i.fi));
		}

		void XplCtl_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var n = e.Node as TNFolderItem;
			if (FolderSelected != null)
				FolderSelected(this, new XplFolderSelectEventArgs(n.di));
			di = n.di;
			LoadFolder();
		}

		private void ResetDrives()
		{
			XplCtl.Nodes.Clear();
			foreach (var item in DriveInfo.GetDrives())
			{
				if (!item.IsReady) continue;
				XplCtl.Nodes.Add(new TNFolderItem(item.RootDirectory, true, item.Name));
			}
		}

		private DirectoryInfo di;

		private void LoadFolder()
		{
			var filter = string.IsNullOrEmpty(FilterCtl.Text) == false;
			FileCtl.Items.Clear();
			foreach (var item in di.GetFiles(ExtnCtl.Text != string.Empty ? "*." + ExtnCtl.Text : "*.*"))
			{
				if (filter && item.Name.IndexOf(FilterCtl.Text, StringComparison.OrdinalIgnoreCase) == -1) continue;
				FileCtl.Items.Add(new TNFileItem(item));
			}
		}

		private class TNFolderItem : TreeNode
		{
			public readonly DirectoryInfo di;

			public TNFolderItem(DirectoryInfo di, bool expandSubDirs, string driveName)
			{
				this.di = di;
				Text = driveName != null ? string.Format("{0} ({1})", di.Name, driveName) : di.Name;
				var sys = new List<string> { "PerfLogs" };
				if (!sys.Contains(di.Name) && expandSubDirs && di.GetDirectories().Length > 0)
				{
					Nodes.Add("to expand");
				}
			}

			internal static void TNFolderItem_BeforeExpand(object sender, TreeViewCancelEventArgs e)
			{
				var n = e.Node as TNFolderItem;
				n.Nodes.Clear();
				foreach (var item in n.di.GetDirectories())
				{
					if (item.Attributes.HasBitflag(FileAttributes.System, FileAttributes.Hidden)) continue;
					n.Nodes.Add(new TNFolderItem(item, true, null));
				}
			}
		}

		private class TNFileItem : ListViewItem
		{
			public readonly FileInfo fi;

			public TNFileItem(FileInfo fi)
			{
				this.fi = fi;
				Text = fi.Name;
			}
		}
	}
}
