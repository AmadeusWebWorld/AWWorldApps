using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cselian.Core;
using Cselian.Core.Data;

namespace AmadeusWeb.WinXT
{
	public partial class Clocky : Form
	{
		#region Vars + ShouldRun
		
		private readonly DataGridViewComboBoxColumn ZoneCol;
		private readonly DataGridViewColumn TimeCol;
		private readonly DataGridViewColumn DstCol;
		private readonly DataGridViewButtonColumn ActionCol;
		private ClockyInfo My;
		private int lastMinute;
		private bool ActionIsMoveUp;
		private ComboBox ZoneEd;

		static Clocky()
		{
			StoreHelper.RegisterInData<List<Clock>>();
		}

		public Clocky()
		{
			InitializeComponent();

			var list = StoreHelper.Read<List<Clock>>() ?? new List<Clock> { new Clock { Name = "Local", Zone = TimeZoneHelper.Local } };
			dgvClocks.DataSource = new BindingList<Clock>(list);

			TimeCol = dgvClocks.Columns[1];
			dgvClocks.Columns.Remove("ZoneId");
			dgvClocks.Columns.Remove("Zone");
			DstCol = dgvClocks.Columns[2];
			DstCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			ZoneCol = dgvClocks.AddBoundColumn<DataGridViewComboBoxColumn>("Zone");

			ActionCol = dgvClocks.AddBoundColumn<DataGridViewButtonColumn>("Action", false);
			ActionCol.Visible = false;
			ActionCol.UseColumnTextForButtonValue = true;
			chkMove_CheckedChanged(null, null);

			ZoneCol.DataSource = TimeZoneHelper.Zones;
			dgvClocks.AutoGenerateColumns = false;

			var loc = StoreHelper.Read<Point>("Location");
			My = StoreHelper.Read<ClockyInfo>() ?? new ClockyInfo { Margin = new Point(15, 15) };
			My.Running = true;
			LoadVisual();
			StoreHelper.Save(My);

			var screen = Screen.FromControl(this).WorkingArea;
			Location = !loc.Equals(Point.Empty) ? loc : new Point(screen.Width - Width - My.Margin.X, My.Margin.Y);
			this.DragMovesForm(form_Moved);

			lblEdit_Click(null, null);
			dgvClocks.ColumnWidthChanged += dgvClocks_ColumnWidthChanged;
			dgvClocks.CellValueNeeded += new DataGridViewCellValueEventHandler(dgvClocks_CellValueNeeded);
			dgvClocks.DataError += new DataGridViewDataErrorEventHandler(dgvClocks_DataError);
		}

		private bool Editing
		{
			get { return !TimeZoneHelper.SimplifyInfo; }
			set { TimeZoneHelper.SimplifyInfo = !value; }
		}

		public static bool ShouldRun()
		{
			var my = StoreHelper.Read<ClockyInfo>();
			return my != null ? my.Running : false;
		}

		#endregion

		#region Grid

		private void dgvClocks_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			// TODO: Why this error?
		}

		private void dgvClocks_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (e.ColumnIndex == ZoneCol.Index)
			{
				e.Value = string.Empty;
			}
		}

		private void dgvClocks_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			if (dgvClocks.CurrentCell.OwningColumn is DataGridViewComboBoxColumn)
			{
				var editingControl = (DataGridViewComboBoxEditingControl)dgvClocks.EditingControl;
				e.Value = editingControl.SelectedItem;
				e.ParsingApplied = true;
			}
		}

		private void dgvClocks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			// Now lets save
			var blist = (BindingList<Clock>)dgvClocks.DataSource;
			var list = blist.Cast<Clock>().ToList();
			StoreHelper.Save(list);
		}

		private void dgvClocks_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			var tot = dgvClocks.Columns[0].Width + 30;
			if (ZoneCol.Visible) tot += ZoneCol.Width;
			if (TimeCol.Visible) tot += TimeCol.Width;
			if (ActionCol.Visible) tot += ActionCol.Width;
			tot += DstCol.Width;
			var screenWidth = Screen.FromControl(this).WorkingArea.Width;
			Width = tot;
			Left = screenWidth - Width - My.Margin.X;
		}

		private void dgvClocks_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == ActionCol.Index)
			{
				var list = (BindingList<Clock>)dgvClocks.DataSource;
				var ix = dgvClocks.SelectedCells[0].RowIndex;
				if (ActionIsMoveUp)
				{
					if (ix == 0) return;
					var it = list[ix];
					list.RemoveAt(ix);
					list.Insert(ix - 1, it);
				}
				else
				{
					list.RemoveAt(ix);
				}

				dgvClocks.Invalidate();
				dgvClocks_CellValueChanged(null, null);
			}
		}

		private void dgvClocks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (dgvClocks.EditingControl is ComboBox)
			{
				if (ZoneEd != null && ZoneEd.Equals(dgvClocks.EditingControl)) return;
				ZoneEd = (ComboBox)dgvClocks.EditingControl;
				ZoneEd.SelectedIndexChanged += new EventHandler(ZoneEd_SelectedIndexChanged);
			}
		}

		private void ZoneEd_SelectedIndexChanged(object sender, EventArgs e)
		{
			var clock = (Clock)dgvClocks.Rows[dgvClocks.CurrentCell.RowIndex].DataBoundItem;
			if (clock == null) return;
			clock.Zone = (TimeZoneInfo)ZoneEd.SelectedItem;
			dgvClocks.InvalidateRow(dgvClocks.CurrentCell.RowIndex);
		}

		#endregion

		#region Edit / AutoSize
		
		private void lblEdit_Click(object sender, EventArgs e)
		{
			Editing = !Editing;
			lblEdit.BackColor = Editing ? Color.FromArgb(204, 255, 204) : lblClose.BackColor;

			chkMove.Visible = chkDstRules.Visible = dgvClocks.AllowUserToDeleteRows = dgvClocks.AllowUserToAddRows = ActionCol.Visible = ZoneCol.Visible = Editing;
			TimeZoneHelper.ShowRule = Editing && chkDstRules.Checked;

			DstCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvClocks.InvalidateColumn(DstCol.Index);
			DstCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			AutosizeGrid(!Editing);
		}

		private void chkDstRules_CheckedChanged(object sender, EventArgs e)
		{
			TimeZoneHelper.ShowRule = Editing && chkDstRules.Checked;
			dgvClocks.InvalidateColumn(DstCol.Index);
			AutosizeGrid(!Editing);
		}

		private void chkMove_CheckedChanged(object sender, EventArgs e)
		{
			ActionIsMoveUp = chkMove.Checked;
			ActionCol.Text = ActionIsMoveUp ? "up" : "del";
			dgvClocks.InvalidateColumn(ActionCol.Index);
		}

		private void AutosizeGrid(bool heightAlso)
		{
			dgvClocks_ColumnWidthChanged(null, null);
			if (heightAlso)
			{
				Height = 30 + (dgvClocks.Rows.Count + 2) * dgvClocks.Rows[0].Height;
			}
		}

		private void LoadVisual()
		{
			if (My.Font != null) dgvClocks.Font = My.Font.ToFont();
			if (!string.IsNullOrEmpty(My.Color)) dgvClocks.ForeColor = ColorExtensions.FromHex(My.Color);
			if (!string.IsNullOrEmpty(My.BackColor)) dgvClocks.DefaultCellStyle.BackColor = ColorExtensions.FromHex(My.BackColor);
			if (!string.IsNullOrEmpty(My.WindowBackColor)) BackColor = lblDate.BackColor = lblCaption.BackColor = dgvClocks.BackgroundColor = ColorExtensions.FromHex(My.WindowBackColor);
		}

		#endregion

		#region Context Menu
		
		private void FontMnu_Click(object sender, EventArgs e)
		{
			var dlg = new FontDialog { Font = dgvClocks.Font };

			var dr = dlg.ShowDialog();
			if (dr == System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			My.Font = new FontData(dlg.Font);
			dgvClocks.Font = dlg.Font;

			AutosizeGrid(true);
			StoreHelper.Save(My);
		}

		private void ColorMnu_Click(object sender, EventArgs e)
		{
			var dlg = new ColorDialog { Color = dgvClocks.ForeColor, AnyColor = true };

			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			My.Color = ColorExtensions.ToHex(dlg.Color);
			dgvClocks.ForeColor = dlg.Color;

			StoreHelper.Save(My);
		}

		private void BackColorMnu_Click(object sender, EventArgs e)
		{
			var dlg = new ColorDialog { Color = dgvClocks.BackgroundColor };

			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			My.BackColor = ColorExtensions.ToHex(dlg.Color);
			dgvClocks.DefaultCellStyle.BackColor = dlg.Color;

			StoreHelper.Save(My);
		}

		private void WinBgdMnu_Click(object sender, EventArgs e)
		{
			var dlg = new ColorDialog { Color = dgvClocks.BackgroundColor };

			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			My.WindowBackColor = ColorExtensions.ToHex(dlg.Color);
			BackColor = lblDate.BackColor = lblCaption.BackColor = dgvClocks.BackgroundColor = dlg.Color;

			StoreHelper.Save(My);
		}

		private void EditClocksMnu_Click(object sender, EventArgs e)
		{
			SystemExtensions.Run("notepad.exe", "Clocks.xml");
		}

		private void RefreshClocksMnu_Click(object sender, EventArgs e)
		{
			var list = StoreHelper.Read<List<Clock>>();
			if (list != null)
			{
				dgvClocks.DataSource = new BindingList<Clock>(list);
			}
		}

		#endregion

		#region Caption, Close, Resize
		
		private void lblCaption_Click(object sender, EventArgs e)
		{
			new Splash().ShowDialog();
		}

		private void lblClose_Click(object sender, EventArgs e)
		{
			My.Running = false;
			StoreHelper.Save(My);
			Close();
		}

		private void form_Moved()
		{
			var screen = Screen.FromControl(this).WorkingArea;
			My.Margin = new Point { X = screen.Width - Left - Width, Y = Top };
			StoreHelper.Save(My);
		}

		private void Clocky_Resize(object sender, EventArgs e)
		{
			// lbl resize also wired here
			lblDate.Left = (ClientSize.Width - lblDate.Width) / 2;
		}

		private void Ticker_Tick(object sender, EventArgs e)
		{
			if (lastMinute != DateTime.Now.Minute)
			{
				lastMinute = DateTime.Now.Minute;
				dgvClocks.InvalidateColumn(TimeCol.Index);
				dgvClocks.InvalidateColumn(DstCol.Index);
				lblDate.Text = DateFormatter.LongDate(DateTime.Now);
			}
		}

		#endregion

		public class ClockyInfo
		{
			public bool Running { get; set; }

			public Point Margin { get; set; }

			public FontData Font { get; set; }

			public string Color { get; set; }

			public string BackColor { get; set; }

			public string WindowBackColor { get; set; }
		}
	}
}
