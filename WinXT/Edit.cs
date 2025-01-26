using System.Windows.Forms;

namespace AmadeusWeb.WinXT
{
	public partial class Edit : Form
	{
		public Edit(DirItem item)
		{
			InitializeComponent();
			Text += item.Text ?? "New Folder";
			txtName.Text = item.Text;
			txtPath.Text = item.Path;
			chkIndex.Enabled = chkRoot.Enabled = chkFavorite.Enabled = string.IsNullOrEmpty(item.Path) == false;
			chkFavorite.Checked = item.IsFavorite;
			chkIndex.Checked = item.IndexSubfolders;
			chkRoot.Checked = item.OpenAsRoot;
		}

		public void UpdateItem(DirItem item)
		{
			item.Text = txtName.Text;
			item.Path = txtPath.Text;
			item.IsFavorite = chkFavorite.Enabled && chkFavorite.Checked;
			item.IndexSubfolders = chkIndex.Enabled && chkIndex.Checked;
			item.OpenAsRoot = chkRoot.Enabled && chkRoot.Checked;
		}

		private void txtPath_TextChanged(object sender, System.EventArgs e)
		{
			chkFavorite.Enabled = chkIndex.Enabled = chkRoot.Enabled = string.IsNullOrEmpty(txtPath.Text) == false;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Edit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void btnPath_Click(object sender, System.EventArgs e)
		{
			var file = false;
			if (file)
			{
				var fil = new OpenFileDialog { FileName = txtPath.Text };
				if (fil.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtPath.Text = fil.FileName;
				}
			}
			else
			{
				var fol = new FolderBrowserDialog { SelectedPath = txtPath.Text };
				if (fol.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtPath.Text = fol.SelectedPath;
				}
			}
		}
	}
}
