using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cselian.FTPSync
{
	public partial class Select : Form
	{
		private List<FtpInfo> List;
		private FtpInfo lastSelected; // weird problem in SelectedCells changing on close (via Return key)
		private bool filtering;

		public Select(FtpInfo sel)
		{
			InitializeComponent();
			Icon = Properties.Resources.syncIcon;
			dgvItems.AutoGenerateColumns = true;
			RefreshOptions();
			SetSelected(sel);

			GrabberMnu.Visible = Sep3.Visible = sel == null;
			dgvItems.ColumnWidthChanged += dgvItems_ColumnWidthChanged;
		}

		public FtpInfo Selected
		{
			get { return lastSelected ?? (dgvItems.SelectedCells.Count > 0 ? List[dgvItems.SelectedCells[0].RowIndex] : null); }
		}

		private void Select_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				RefreshMnu.PerformClick();
			}
			else if (e.KeyCode == Keys.Return)
			{
				SelectMnu.PerformClick();
			}
			else if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void dgvItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			SelectMnu.PerformClick();
		}

		private void dgvItems_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			if (filtering) return;
			var colwid = dgvItems.SumColumnWidths() + 30;
			if (dgvItems.Width == colwid)
				return;

			Width += colwid - dgvItems.Width;
		}

		private void RefreshOptions()
		{
			var sel = Selected;
			dgvItems.DataSource = List = FtpInfo.Clone();
			SetSelected(sel);
			Height = dgvItems.Rows.GetRowsHeight(DataGridViewElementStates.None) + 50 + Height - dgvItems.Height;
			txtFind.Focus();
		}

		private void SetSelected(FtpInfo sel)
		{
			var ix = List.IndexOf(sel);
			if (ix == -1) ix = 0;
			if (dgvItems.Rows.Count < ix) return;
			dgvItems.Rows[ix].Cells[0].Selected = true;
		}

		private void txtFind_TextChanged(object sender, System.EventArgs e)
		{
			var all = txtFind.Text.Length == 0;
			dgvItems.CurrentCell = null;
			bool first = true;
			filtering = true;
			foreach (DataGridViewRow item in dgvItems.Rows)
			{
				item.Visible = all || ((FtpInfo)item.DataBoundItem).Matches(txtFind.Text);
				if (first && item.Visible)
				{
					item.Cells[0].Selected = true;
					first = false;
				}
			}
			filtering = false;
		}

		private void txtFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				dgvItems.Select();
			}
		}

		#region Mnu

		private void SelectMnu_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
			lastSelected = Selected;
			Close();
		}

		private void RefreshMnu_Click(object sender, System.EventArgs e)
		{
			FtpInfo.ReadOptions();
			RefreshOptions();
		}

		private void OpenMnu_Click(object sender, System.EventArgs e)
		{
			IOHelper.RunInNotepad(FtpInfo.ConfigFile);
		}

		private void CopyMnu_Click(object sender, System.EventArgs e)
		{
			if (Selected == null) return;

			var info = Interaction.InputBox("Enter new FTP Details", Program.Caption, "Copy of " + Selected.ToLine());
			if (string.IsNullOrEmpty(info)) return;
			var item = new FtpInfo(info);
			List.Add(item);

			var sel = dgvItems.SelectedRows.Count > 0 ? dgvItems.SelectedRows[0].Index : 0;
			dgvItems.DataSource = null;
			dgvItems.DataSource = List;
			if (dgvItems.Rows.Count >= sel) dgvItems.Rows[sel].Selected = true;
		}

		private void SaveMnu_Click(object sender, System.EventArgs e)
		{
			FtpInfo.Save(List);
		}

		private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (!ShowPwdMnu.Checked && dgvItems.Columns[e.ColumnIndex].Name == "Password" && string.IsNullOrEmpty((string)e.Value) == false)
				e.Value = new string('*', e.Value.ToString().Length);
		}

		private void ShowPwdMnu_CheckStateChanged(object sender, System.EventArgs e)
		{
			dgvItems.InvalidateColumn(2);
		}

		private void GrabberMnu_Click(object sender, System.EventArgs e)
		{
			Program.RunGrabber = true;
			Close();
		}

		#endregion

		private void dgvItems_KeyDown(object sender, KeyEventArgs e)
		{
			char key;
			if (dgvItems.CurrentCell.ColumnIndex == 0 && char.IsLetterOrDigit(key = System.Convert.ToChar(e.KeyValue)))
			{
				txtFind.Text = key.ToString();
				txtFind.Focus();
			}
		}
	}
}
