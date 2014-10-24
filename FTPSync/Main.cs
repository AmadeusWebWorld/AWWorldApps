using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cselian.FTPSync
{
	public partial class Main : Form
	{
		private string LastAddedFrom;

		public Main()
		{
			InitializeComponent();
			Icon = Properties.Resources.syncIcon;
			Text = Program.Caption;
			Load += new System.EventHandler(Main_Load);
			Resize += new EventHandler(Main_Resize);
			Main_Resize(null, null);
		}

		private void Main_Load(object sender, System.EventArgs e)
		{
			Files.Items.Clear();

			FtpHelper.Log = Log;
			FtpHelper.Credentials.UserName = FtpInfo.Selected.Username;

			fsw.EnableRaisingEvents = false;
			ChangeServer();
		}

		#region " Credentials & Settings (ChangeServer) "

		private void ChangeServer()
		{
			Text = FtpInfo.Selected.Name + " - " + Program.Caption;

			bool ini = FtpInfo.Selected.Name != "Default";
			if (!ini)
				FtpInfo.Selected.LocalFolder = FtpInfo.Selected.GetKey(Names.LocalFolder);

			if (string.IsNullOrEmpty(FtpInfo.Selected.LocalFolder))
			{
				return;
			}

            FtpInfo.Selected.LocalFolder = IOHelper.EnsureEndsWith(FtpInfo.Selected.LocalFolder.Replace("/", "\\"), "\\");

			if (Directory.Exists(FtpInfo.Selected.LocalFolder))
			{
				fsw.Path = FtpInfo.Selected.LocalFolder;

				if (!fsw.EnableRaisingEvents)
				{
					fsw.EnableRaisingEvents = true;
					fsw.IncludeSubdirectories = true;
					fsw.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite;

					// Or IO.NotifyFilters.Size 'May not always change, makes 2 calls since LastWrite will anyway be raised
					fsw.Changed += fsw_Changed;
					fsw.Created += fsw_Changed;

					// NOTE: AddHandler fsw.Renamed, AddressOf fsw_Changed maybe it shtarts double-counting?
				}
			}

			FtpHelper.SetMessage("*** FileWatcher Initialised on " + FtpInfo.Selected.LocalFolder + DateTime.Now.ToString(" dd MMM yyyy"));

			if (!ini)
				FtpInfo.Selected.FtpFolder = FtpInfo.Selected.GetKey(Names.FtpFolder);

			if (!ini)
				FtpInfo.Selected.Username = FtpInfo.Selected.GetKey(Names.FtpUsername);
			FtpHelper.Credentials.UserName = FtpInfo.Selected.Username;

            FtpInfo.Selected.FtpFolder = IOHelper.EnsureEndsWith(FtpInfo.Selected.FtpFolder.Replace("\\", "/"), "/");

			SyncMnu.Enabled = !string.IsNullOrEmpty(FtpInfo.Selected.FtpFolder);

			if (!ini | FtpInfo.Selected.Password == string.Empty)
				FtpInfo.Selected.Password = FtpInfo.Selected.GetKey(Names.FtpPassword);
			FtpHelper.Credentials.Password = FtpInfo.Selected.Password;

			FtpHelper.SetMessage(
				string.Format(
					"FTP Credentials Set for '{0}' (User: '{1}' Pass: '{2}')",
					FtpInfo.Selected.FtpFolder,
					FtpHelper.Credentials.UserName,
					string.Empty.PadRight(FtpHelper.Credentials.Password.Length, '*')));
		}

		#endregion

		#region " Record Changes (fsw handles & setMessage)"

		private void fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
		{
			if (Exclusions.Exclude(e.FullPath))
				return;

			var itm = Files.Items.Find(e.FullPath, false);

			ListViewItem item = null;
			if (e.ChangeType == System.IO.WatcherChangeTypes.Deleted)
			{
				// If itm.Length = 1 Then Files.Items.Remove(itm(0)) 'remove since forced to remove nonexistant files anyway
			}
			else if (itm.Length == 0 | e.ChangeType == System.IO.WatcherChangeTypes.Renamed)
			{
				item = Files.Items.Add(e.FullPath, e.Name, 0);
				item.ImageKey = Core.FileIcon.CheckExtensionExists(e.FullPath, icons);
				item.Tag = e.FullPath; // key doesnt seem to be accessible on item :(
			}
			else if (itm.Length == 1)
			{
				item = itm[0];
			}

			if (item != null)
			{
				FtpHelper.SetMessage(e.ChangeType.ToString(), item, UIHelper.RelativeToLocalFolder(e.FullPath));
				item.Checked = true;
			}

			RemoveNonExistant();
		}

		private void fsw_Renamed(object sender, System.IO.RenamedEventArgs e)
		{
			var itm = Files.Items.Find(e.FullPath, false);
			var r = e as RenamedEventArgs;
			if (r != null)
			{
				itm = Files.Items.Find(r.OldFullPath, false);
				if (itm.Length == 1)
					Files.Items.Remove(itm[0]);
			}

			var f = new FileSystemEventArgs(WatcherChangeTypes.Renamed, e.FullPath, e.Name);
			fsw_Changed(sender, f);
		}

		// since the move action does not seem to raise any event other that create, we must manually delete the old name (if existed).
		private void RemoveNonExistant()
		{
			int i = 0;
			while (!(i >= Files.Items.Count))
			{
				if (File.Exists(FtpInfo.Selected.LocalFolder + Files.Items[i].Text))
				{
					i += 1;
				}
				else
				{
					Files.Items.RemoveAt(i);
				}
			}
		}

		#endregion

		#region Column Resizing

		private void Main_Resize(object sender, System.EventArgs e)
		{
			NameCol.Width = Files.Width - 30 - MsgCol.Width - SizeCol.Width;
		}

		private void Files_ColumnWidthChanged(object sender, System.Windows.Forms.ColumnWidthChangedEventArgs e)
		{
			if (e.ColumnIndex != 0)
			{
				NameCol.Width = Files.Width - 30 - MsgCol.Width - SizeCol.Width;
			}
		}

		#endregion

		#region Files and Log - Keydown and DragDrop

		private void Log_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control & e.KeyCode == Keys.A)
			{
				Log.SelectAll();
			}
			else if (e.Control & e.KeyCode == Keys.Return)
			{
				FtpHelper.MakeWebRequest();
			}
		}

		private void Files_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				RemoveNonExistant();
				return;
			}

			if (e.Control & (e.KeyCode == Keys.A | e.KeyCode == Keys.U))
			{
				var chk = e.KeyCode == Keys.A;
				foreach (ListViewItem itm in Files.Items)
					itm.Checked = chk;
				return;
			}

			if (e.Control & e.KeyCode == Keys.Delete)
			{
				for (int i = Files.SelectedIndices.Count - 1; i >= 0; i += -1)
					Files.Items.RemoveAt(Files.SelectedIndices[i]);
			}
		}

		private void Files_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
		}

		private void Files_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			foreach (string fil in (IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop))
			{
				if (fil.StartsWith(FtpInfo.Selected.LocalFolder, StringComparison.OrdinalIgnoreCase) == false)
					continue;

				var file = UIHelper.RelativeToLocalFolder(fil);
				var item = Files.Items.Find(fil, false);

				// if (Exclusions.Exclude(file)) continue; Drag drop is deliberate

				if (item.Length == 0)
				{
					var itm = Files.Items.Add(fil, file, 0);
					itm.Tag = fil; // key doesnt seem to be accessible on item 

					FtpHelper.SetMessage("DragDrop", itm, file);
					itm.Checked = true;
				}
				else if (item.Length == 1)
				{
					item[0].Checked = true;
				}
			}
		}

		#endregion

		#region Toolbar

		// http://www.codeguru.com/csharp/csharp/cs_internet/desktopapplications/article.php/c13163/
		private void SyncOrDelete_Click(object sender, System.EventArgs e)
		{
			var delFtp = DeleteFtpMnu.Equals(sender);
			var delLocal = DeleteLocalMnu.Equals(sender);
			if (SyncMnu.Equals(sender) == false)
			{
				var action = ((ToolStripMenuItem)sender).Text;
				if (Interaction.MsgBox("Sure you want to " + action, MsgBoxStyle.YesNo, "Confirm " + action) == MsgBoxResult.No)
					return;
			}

			foreach (ListViewItem itm in Files.Items)
			{
				if (itm.Checked)
				{
					if (delLocal)
					{
						var msg = "Deleting...";
						try
						{
							if (File.Exists(UIHelper.FilePath(itm)))
							{
								File.Delete(UIHelper.FilePath(itm));
							}
							else
							{
								msg = "File Delete - Doesnt Exist";
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Local File Delete Error");
							msg = "File Delete Error - " + ex.ToString();
						}

						FtpHelper.SetMessage(msg, itm, UIHelper.RelativeToLocalFolder(UIHelper.FilePath(itm)));
					}
					else
					{
						FtpHelper.SetMessage(FtpHelper.SyncFTP(itm.Text, delFtp), itm, UIHelper.RelativeToLocalFolder(UIHelper.FilePath(itm)));
					}

					if (!delFtp)
						itm.Checked = false;
					Application.DoEvents();
				}
			}

			System.Media.SystemSounds.Exclamation.Play();
			if (delLocal) RemoveNonExistant();
		}

		private void Pause_Click(object sender, System.EventArgs e)
		{
			fsw.EnableRaisingEvents = !fsw.EnableRaisingEvents;
			PauseMnu.Text = fsw.EnableRaisingEvents ? "&Pause Listening" : "&Listen";
			PauseMnu.Image = fsw.EnableRaisingEvents ? Properties.Resources.pause : Properties.Resources.listen;
		}

		private void AddMnu_Click(object sender, EventArgs e)
		{
			var fo = new OpenFileDialog { Multiselect = true };
			var setToLocal = LastAddedFrom == null ||
				LastAddedFrom.StartsWith(FtpInfo.Selected.LocalFolder, StringComparison.OrdinalIgnoreCase) == false;
			fo.InitialDirectory = setToLocal ? FtpInfo.Selected.LocalFolder : LastAddedFrom;

			if (fo.ShowDialog() == System.Windows.Forms.DialogResult.Cancel || fo.FileNames.Length == 0)
				return;

			foreach (var item in fo.FileNames)
			{
				var rel = item.Substring(FtpInfo.Selected.LocalFolder.Length);
				fsw_Changed(null, new FileSystemEventArgs(WatcherChangeTypes.Changed, FtpInfo.Selected.LocalFolder, rel));
			}

			LastAddedFrom = Path.GetDirectoryName(fo.FileNames[0]);
		}

		private void QueueMnu_Click(object sender, EventArgs e)
		{
			var ip = new InputPaths();
			if (ip.ShowDialog() == DialogResult.Cancel) return;

			var paths = ip.GetPaths();
			foreach (var item in paths)
			{
				fsw_Changed(null, new FileSystemEventArgs(WatcherChangeTypes.Changed, FtpInfo.Selected.LocalFolder, item));
			}
		}

		private void ClearMnu_Click(object sender, EventArgs e)
		{
			Files.Items.Clear();
		}

		private void ClearSelectedMnu_Click(object sender, EventArgs e)
		{
            foreach (ListViewItem item in Files.SelectedItems) Files.Items.Remove(item);
		}

		private void ClearUncheckedMnu_Click(object sender, EventArgs e)
		{
            foreach (ListViewItem item in Files.Items) if (item.Checked == false) Files.Items.Remove(item);
		}

		private void SelectMnu_Click(object sender, EventArgs e)
		{
			if (!FtpInfo.HasMultipleOptions) return;

			var old = FtpInfo.Selected;
			FtpInfo.SelectOption();
			if (object.ReferenceEquals(old, FtpInfo.Selected)) return;

			Log.Text = string.Empty;
			ChangeServer();
			ClearMnu.PerformClick();
		}

		private void GrabberMnu_Click(object sender, EventArgs e)
		{
			new Grabber().ShowDialog();
		}

		private void OpenLogMnu_Click(object sender, EventArgs e)
		{
			IOHelper.RunInNotepad(FtpInfo.Selected.Name + ".log");
		}

		#endregion

		#region Context Menu

		private void OpenContainingFolderMnu_Click(object sender, EventArgs e)
		{
			if (Files.SelectedItems.Count != 1) return;

			var fil = Path.Combine(FtpInfo.Selected.LocalFolder, Files.SelectedItems[0].Text);
			IOHelper.Run("explorer.exe", "/select," + fil);
		}

		private void CopyPathsMnu_Click(object sender, EventArgs e)
		{
			var list = new List<string>();
			var copyChecked = sender == CopyPathsOfCheckedMnu;
			var from = copyChecked ? (System.Collections.IEnumerable)Files.CheckedItems : Files.SelectedItems;
			foreach (ListViewItem item in from)
			{
				var fil = Path.Combine(FtpInfo.Selected.LocalFolder, item.Text);
			}

			Clipboard.SetText(string.Join(Environment.NewLine, list.ToArray()));
			MessageBox.Show(string.Format("Copied paths of {0} {1} items", list.Count, copyChecked ? "checked" : "selected"), Text);
		}

		#endregion
	}
}
