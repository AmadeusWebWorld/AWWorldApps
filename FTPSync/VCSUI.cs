using System.Collections.Generic;
using System.Windows.Forms;

namespace Cselian.FTPSync
{
	public partial class VCSUI : Form
	{
		public VCSUI()
		{
			InitializeComponent();
			var fols = VCS.ReadRoot();
			if (fols != null)
				AddNodes(Fols.Nodes, fols);
		}

		private void AddNodes(TreeNodeCollection nodes, List<VCS.Fol> fols)
		{
			foreach (var item in fols)
			{
				var node = nodes.Add(item.ToString());
				if (item.Fols != null) AddNodes(node.Nodes, item.Fols);
				node.Expand();
			}
		}

		#region Root/Fol Menu

		private void MnuScan_Click(object sender, System.EventArgs e)
		{
			if (Menu.SourceControl == Fols)
			{
				var fols = VCS.ReadFols();
				Fols.Nodes.Clear();
				AddNodes(Fols.Nodes, fols);
				return;
			}


		}

		private void MnuUpdate_Click(object sender, System.EventArgs e)
		{

		}

		private void MnuPush_Click(object sender, System.EventArgs e)
		{

		}

		private void MnuDiff_Click(object sender, System.EventArgs e)
		{

		}
		
		#endregion

		#region File Menu

		private void MnuEdit_Click(object sender, System.EventArgs e)
		{

		}

		private void MnuFileDiff_Click(object sender, System.EventArgs e)
		{

		}

		private void MnuRevert_Click(object sender, System.EventArgs e)
		{

		}

		private void MnuCommit_Click(object sender, System.EventArgs e)
		{

		}

		#endregion
	}
}
