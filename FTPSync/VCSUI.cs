using System.Collections.Generic;
using System.Windows.Forms;

namespace Cselian.FTPSync
{
	public partial class VCSUI : Form
	{
		public VCSUI()
		{
			InitializeComponent();
			RefreshFols(VCS.ReadRoot());
		}

		#region Fol Loading / Selection Changed

		private void RefreshFols(List<VCS.Fol> fols)
		{
			Fols.Nodes.Clear();
			if (fols == null) return;
			AddNodes(Fols.Nodes, fols);
		}

		private void AddNodes(TreeNodeCollection nodes, List<VCS.Fol> fols)
		{
			foreach (var item in fols)
			{
				var node = nodes.Add(item.ToString());
				node.Tag = item;
				if (item.Fols != null) AddNodes(node.Nodes, item.Fols);
				node.Expand();
			}
		}

		private void Fols_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var fol = (VCS.Fol)Fols.SelectedNode.Tag;
			if (fol.Fils != null)
				RefreshFiles(fol.Fils);
		}

		#endregion

		#region Root/Fol Menu

		private void MnuScan_Click(object sender, System.EventArgs e)
		{
			if (Menu.SourceControl == Fols && Fols.SelectedNode == Fols.Nodes[0])
			{
				RefreshFols(VCS.ReadFols());
				return;
			}

			var fol = (VCS.Fol)Fols.SelectedNode.Tag;
			if (fol.Fols != null)
			{
				MessageBox.Show("Please select a folder with files");
				return;
			}

			VCS.RefreshFiles(fol);
			RefreshFiles(fol.Fils);
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

		#region File Load

		private void RefreshFiles(List<VCS.Fil> fils)
		{
			if (fils == null) return;
			Files.DataSource = fils;
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
