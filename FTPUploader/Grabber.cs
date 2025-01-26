using System;
using System.IO;
using System.Windows.Forms;

namespace Cselian.FTPSync
{
	public partial class Grabber : Form
	{
		private string ProjectFolder;

		public Grabber()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.Filter = "Text Files|*.txt";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

			txtProject.Text = ofd.FileName;
			ProjectFolder = Path.GetDirectoryName(txtProject.Text);
			while (lvwPages.Items.Count > 1)
				lvwPages.Items.RemoveAt(1);

			var fmt = lvwPages.Items[0];
			var urlFmt = UrlOf(fmt);
			var nameFmt = NameOf(fmt);
			var descFmt = DescOf(fmt);

			var lines = File.ReadAllLines(ofd.FileName);
			foreach (var line in lines)
			{
				if (line.StartsWith("#")) continue;
				var bits = line.Split('	');
				var itm = lvwPages.Items.Add(string.Format(urlFmt, bits));
				var name = string.Format(nameFmt, bits);
				var status = (itm.Checked = !File.Exists(FileName(name))) ? string.Empty : "Exists";
				itm.SubItems.AddRange(new[] { name, string.Format(descFmt, bits), status });
			}
		}

		private void btnGrab_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvwPages.CheckedItems)
			{
				if (item.Index == 0) continue;
				var name = NameOf(item);
				var url = UrlOf(item);
				try
				{
					WriteFile(name, FtpHelper.MakeWebRequest(url, null));
					SetStatus(item, "Downloaded");
					item.Checked = false;
					Application.DoEvents();
				}
				catch (Exception ex)
				{
					SetStatus(item, ex.Message);
					item.Checked = true;
				}
			}
		}

		private void btnBuildNav_Click(object sender, EventArgs e)
		{
			var sb = new System.Text.StringBuilder();
			foreach (ListViewItem item in lvwPages.Items)
			{
				if (item.Index == 0) continue;
				var name = NameOf(item);
				var file = FileName(name, true);
				sb.AppendFormat("<a href='{0}'>{1}</a> {2}<br />", file, name, DescOf(item)).AppendLine();
			}

			var tpl = File.ReadAllText(FileName("nav-tpl"));
			tpl = tpl.Replace("[LINKS]", sb.ToString());
			WriteFile("nav", tpl);
		}


		private void btnReplace_Click(object sender, EventArgs e)
		{
			Tools.App.GenDataFolder = ProjectFolder;
			var dlg = new Tools.MultiReplace();
			var list = new System.Collections.Generic.List<string>();
			foreach (ListViewItem item in lvwPages.Items)
			{
				if (item.Index == 0) continue;
				list.Add(FileName(NameOf(item), true));
			}

			dlg.Tag = list;
			dlg.ShowDialog();
		}

		#region Helpers

		private void WriteFile(string name, string content)
		{
			if (File.Exists(name)) File.Delete(name);
			File.WriteAllText(FileName(name), content);
		}

		private static string UrlOf(ListViewItem itm)
		{
			return itm.Text;
		}

		private string NameOf(ListViewItem itm)
		{
			return itm.SubItems[colName.Index].Text;
		}

		private string DescOf(ListViewItem itm)
		{
			return itm.SubItems[colDesc.Index].Text;
		}

		private void SetStatus(ListViewItem itm, string status)
		{
			itm.SubItems[colStatus.Index].Text = status;
		}

		private string FileName(string name, bool noPath = false)
		{
			name += ".html";
			return noPath ? name : Path.Combine(ProjectFolder, name);
		}

		#endregion
	}
}
