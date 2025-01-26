using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class Suggestions : Form
	{
		public Suggestions(LibItem[] items)
		{
			InitializeComponent();

			foreach (var item in items)
			{
				var node = tvwItems.Nodes.Add(item.FullPath);
				node.Tag = item;
				var none = true;
				var matches = VidLibrary.Search(SearchMode.ExactFileName, item.Name);
				foreach (var match in matches)
				{
					var m = node.Nodes.Add(match.FullPath);
					m.Tag = match;
					if (none && matches.Length == 1)
					{
						m.Checked = true;
						none = false;
					}
				}

				var nf = node.Nodes.Add("Dont Fix");
				if (none)
				{
					nf.Checked = true;
					none = false;
				}
			}

			tvwItems.ExpandAll();
		}

		public List<Tuple<LibItem, LibItem>> GetSuggestions()
		{
			var r = new List<Tuple<LibItem, LibItem>>();
			foreach (TreeNode item in tvwItems.Nodes)
			{
				var sel = item.Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Checked);
				if (sel != null && sel.Text != "Dont Fix")
				{
					r.Add(new Tuple<LibItem, LibItem>((LibItem)item.Tag, (LibItem)sel.Tag));
				}
			}

			return r;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void tvwItems_BeforeCheck(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Parent == null)
			{
				e.Cancel = true; // cant check parents
				return;
			}

			// uncheck other siblings
			foreach (TreeNode item in e.Node.Parent.Nodes)
			{
				if (item.Checked && item != e.Node)
				{
					item.Checked = false;
				}
			}
		}
	}
}
