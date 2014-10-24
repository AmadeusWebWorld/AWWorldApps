using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cselian.Utilities.WinXT
{
	/// <summary>
	/// Encapsulates the DirItem
	/// </summary>
	public class TvwItem : TreeNode
	{
		public TvwItem(DirItem d)
		{
			Dir = d;
			UpdateUI();
			AddChildren(d);
		}

		public DirItem Dir { get; private set; }

		public static DirItem GetRoot(TreeView tvw)
		{
			var r = new DirItem { Text = "Root" };
			AddNodes(r, tvw.Nodes[0].Nodes);
			return r;
		}

		public void AddChildren(DirItem d)
		{
			Nodes.Clear();
			if (d.HasChildren)
			{
				Nodes.AddRange(d.Children.Select(x => new TvwItem(x)).ToArray());
			}
		}

		public void UpdateUI()
		{
			Text = Dir.Text;
		}

		private static void AddNodes(DirItem dir, TreeNodeCollection nodes)
		{
			dir.Children = null;
			foreach (TvwItem item in nodes)
			{
				dir.AddChild(item.Dir);
				AddNodes(item.Dir, item.Nodes);
			}
		}
	}
}
