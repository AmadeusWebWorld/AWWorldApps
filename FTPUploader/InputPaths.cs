using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AmadeusWeb.SmartSiteUploader
{
	public partial class InputPaths : Form
	{
		public InputPaths()
		{
			InitializeComponent();
			lblMsg.Text += FtpInfo.Selected.LocalFolder;
		}

		public string[] GetPaths()
		{
			var list = new List<string>();

			var lines = txtPaths.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			foreach (var item in lines)
			{
				var rel = item.Replace("/", @"\");
				if (item.StartsWith(FtpInfo.Selected.LocalFolder, StringComparison.OrdinalIgnoreCase)) rel = rel.Substring(FtpInfo.Selected.LocalFolder.Length);
				if (rel.StartsWith(@"\")) rel = rel.Substring(1);
				var file = FtpInfo.Selected.LocalFolder + rel; // why isnt combine working?
				if (File.Exists(file))
				{
					list.Add(rel);
				}
			}

			return list.ToArray();
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void txtPaths_TextChanged(object sender, System.EventArgs e)
		{
			btnOk.Enabled = GetPaths().Length > 0;
		}
	}
}
