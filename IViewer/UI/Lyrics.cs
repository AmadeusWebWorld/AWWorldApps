using System;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class Lyrics : UserControl
	{
		private LyricInfo LyrInfo;

		public Lyrics()
		{
			InitializeComponent();
			Items.MouseDoubleClick += Items_MouseDoubleClick;
			Items.KeyDown += Items_KeyDown;
			MoveToNowMnu.Click += MoveToNowMnu_Click;
			MoveFwdByPt1Mnu.Click += MoveByMnu_Click;
			MoveBackByPt1Mnu.Click += MoveByMnu_Click;
			MoveFwdByPt5Mnu.Click += MoveByMnu_Click;
			MoveBackByPt5Mnu.Click += MoveByMnu_Click;

			rdoLoopEvery.CheckedChanged += rdoLoop_CheckedChanged;
			rdoLoopGroup.CheckedChanged += rdoLoop_CheckedChanged;
			rdoLoopSelection.CheckedChanged += rdoLoop_CheckedChanged;
			txtLoopTimes.TextChanged += txtLoopTimes_TextChanged;
		}

		public void ShowFor(LyricInfo lyr)
		{
			LyrInfo = lyr;
			Items.DataSource = lyr.Lines;
			Items.DisplayMember = "DisplayText";
			ParentForm.Focus();
		}

		public void ShowItem(LyricInfo.Line item)
		{
			if (CheckIfLooping(item))
			{
				return;
			}

			Items.SelectedItem = item;
		}

		private void Items_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			JumpToLine();
		}

		private void Items_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				JumpToLine();
			}
			else if (e.KeyCode == Keys.I & e.Control)
			{
				IncludeRestMnu.PerformClick();
			}
			else if (e.KeyCode == Keys.Insert)
			{
				MoveToNowMnu.PerformClick();
			}
			else if (e.KeyValue == 219 | e.KeyValue == 221)
			{
				var neg = e.KeyValue == 221 ? 1 : -1;
				var stp = e.Control ? 5 : 1;
				var by = 0.1 * neg * stp;
				MoveBy(by);
			}
		}

		private void JumpToLine()
		{
			var itm = (LyricInfo.Line)Items.SelectedItem;
			Main.Inst.PlrControls.currentPosition = itm.Start;
		}

		private void MoveToNowMnu_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Moving to " + Main.Inst.PlrControls.currentPosition);
		}

		private void MoveByMnu_Click(object sender, System.EventArgs e)
		{
			var name = ((ToolStripMenuItem)sender).Name.Replace("Mnu", string.Empty);
			var back = name.Contains("Back");
			name = name.Substring(name.IndexOf("By") + 2);
			var by = double.Parse(name.Replace("Pt", ".")) * (back ? -1 : 1);

			MoveBy(by);
		}

		private void MoveBy(double by)
		{
			MessageBox.Show("Moving by " + by);
		}

		#region "Loop"

		private int LoopedTimes;

		private int WantedTimes;

		private void rdoLoop_CheckedChanged(object sender, System.EventArgs e)
		{
			if (!((RadioButton)sender).Checked)
			{
				return;
			}

			Items.SelectionMode = object.ReferenceEquals(sender, rdoLoopSelection) ? SelectionMode.MultiExtended : SelectionMode.One;
		}

		/// <summary>
		/// Returns true if loop action was done and a different item was set
		/// </summary>
		private bool CheckIfLooping(LyricInfo.Line nxt)
		{
			bool functionReturnValue = false;
			if (!chkLoop.Checked | Items.SelectedItem == null)
			{
				goto clearAndFalse;
			}

			var cur = (LyricInfo.Line)Items.SelectedItem;
			int ix = Array.IndexOf(LyrInfo.Lines, cur);
			if (ix == LyrInfo.Lines.Length - 1)
			{
				goto clearAndFalse;
			}

			if (LyrInfo.Lines[ix + 1].GetHashCode() != nxt.GetHashCode())
			{
				return false;
			}

			// user jumped so all bets are off. 'TODO: Check if this is right
			var nextLine = default(LyricInfo.Line);
			if (rdoLoopEvery.Checked)
			{
				// TODO: implement
			}
			else if (rdoLoopGroup.Checked)
			{
				if (nxt.Group == cur.Group)
				{
					return false;
				}

				LoopedTimes += 1;
				if (WantedTimes == 0 | LoopedTimes < WantedTimes)
				{
					nextLine = LyrInfo.FindFirst(cur.Group);
					goto setNext;
				}
			}
			else if (rdoLoopSelection.Checked)
			{
				// TODO: implement
			}

			if (WantedTimes != 0 && LoopedTimes >= WantedTimes)
			{
				LoopedTimes = 0;
			}

			return functionReturnValue;
		setNext:
			// clear before moving out
			lblLoopNth.Text = string.Format("{0} of", LoopedTimes);
			lblLoopNth.Visible = true;
			Items.SelectedItem = nextLine;
			JumpToLine();
			return true;
		clearAndFalse:

			LoopedTimes = 0;
			lblLoopNth.Visible = false;
			return false;
			return functionReturnValue;
		}

		private void txtLoopTimes_TextChanged(object sender, System.EventArgs e)
		{
			WantedTimes = txtLoopTimes.Text.Length > 0 ? int.Parse(txtLoopTimes.Text) : 0;
		}

		#endregion
	}
}
