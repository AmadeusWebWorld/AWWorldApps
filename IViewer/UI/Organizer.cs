using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class Organizer : Form
	{
		private readonly string Folder;

		public Organizer()
			: this("D:\\Imran\\M")
		{
		}

		public Organizer(string fol)
		{
			InitializeComponent();

			lblFol.Text = fol;
			Folder = fol;
			btnRefresh_Click(null, null);
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			tvwItems.Nodes.Clear();
			Add(tvwItems.Nodes, Folder, new DirectoryInfo(Folder).GetDirectories(), 1);
			tvwItems.ExpandAll();
		}

		private void Add(TreeNodeCollection nodes, string fol, DirectoryInfo[] subDirs, int level)
		{
			var n = nodes.Add(fol);
			////If level > 2 Then Exit Sub

			var empties = new List<string>();

			foreach (var subFol in subDirs)
			{
				var dirs = subFol.GetDirectories();
				if (dirs.Length == 0 | fol == "Floyd" | fol == "Eagles")
				{
					empties.Add(subFol.Name);
					continue;
				}

				Add(n.Nodes, subFol.Name, dirs, level + 1);
			}

			if (empties.Count > 0)
			{
				var name = string.Join(" / ", empties.ToArray());
				n.Nodes.Insert(0, name);
			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			var node = tvwItems.Nodes[0];
			var sb = new StringBuilder(node.Text).AppendLine();
			var file = "organizer.txt";
			AddNodes(node.Nodes, sb, 1);
			IOHelper.Overwrite(file, sb.ToString());
			IOHelper.Run(file);
		}

		private void AddNodes(TreeNodeCollection nodes, StringBuilder sb, int level)
		{
			foreach (TreeNode item in nodes)
			{
				sb.AppendLine(string.Empty.PadRight(level, ' ').Replace(" ", "  ") + item.Text);
				AddNodes(item.Nodes, sb, level + 1);
			}
		}
	}
}
