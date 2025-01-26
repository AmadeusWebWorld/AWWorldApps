using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class DataManager : Form
	{
		private string ExcludeFile, RemoveFile, CleanFile;

		public DataManager()
		{
			InitializeComponent();
		}

		private void txtRaw_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				txtExclude.Text += txtRaw.SelectedText + Environment.NewLine;
			}
			if (e.KeyCode == Keys.F3)
			{
				txtRemove.Text += txtRaw.SelectedText + Environment.NewLine;
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			var file = new OpenFileDialog();
			file.ShowDialog();
			if (string.IsNullOrEmpty(file.FileName)) return;

			CleanFile = Path.ChangeExtension(file.FileName, ".clean.txt");

			var fol = Path.GetDirectoryName(file.FileName);
			ExcludeFile = Path.Combine(fol, "exclude.txt");
			if (File.Exists(ExcludeFile)) txtExclude.Text = File.ReadAllText(ExcludeFile);

			RemoveFile = Path.Combine(fol, "remove.txt");
			if (File.Exists(RemoveFile)) txtRemove.Text = File.ReadAllText(RemoveFile);

			txtRaw.Text = File.ReadAllText(file.FileName);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var exclude = txtExclude.Lines;
			var remove = txtRemove.Lines;
			var lines = txtRaw.Lines;
			var clean = new List<string>();
			foreach (var line in lines)
			{
				if (exclude.Any(x => !string.IsNullOrEmpty(x) && line.StartsWith(x, StringComparison.OrdinalIgnoreCase)))
					continue;

				var r = remove.FirstOrDefault(x => !string.IsNullOrEmpty(x) && line.StartsWith(x));
				clean.Add(string.IsNullOrEmpty(r) ? line : line.Replace(r, string.Empty));
			}

			clean.Sort();
			txtClean.Text = string.Join(Environment.NewLine, clean);

			File.WriteAllText(ExcludeFile, txtExclude.Text);
			File.WriteAllText(RemoveFile, txtRemove.Text);
			File.WriteAllText(CleanFile, txtClean.Text);
		}
	}
}
