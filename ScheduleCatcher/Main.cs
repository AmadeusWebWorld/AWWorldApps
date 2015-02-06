using System;
using System.Drawing;
using System.Windows.Forms;
using Cselian.Core;

namespace Cselian.ScheduleCatcher
{
	public partial class Main : Form
	{
		private const string StartMsg = "&Start Scanning";
		private const string StopMsg = "&Stop";
		private System.Drawing.Color LookFor;
		private Tuple<Point, Size> LookIn;
		private ThreadHelper<ScreenReader.ReaderArgs, Point> Finder;

		public Main()
		{
			InitializeComponent();

			LookIn = DataReader.GetArea();
			if (LookIn == null) btnArea_Click(null, null); else ReadArea();

			LookFor = DataReader.GetColor();
			if (LookFor == Color.Empty) btnColor_Click(null, null); else ReadColor();
			SetMessage("launched");
			btnStartStop.Text = StartMsg;
		}

		#region Settings
		
		private void btnArea_Click(object sender, System.EventArgs e)
		{
			if (new Area().ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				LookIn = DataReader.GetArea();
				ReadArea();
			}
		}

		private void ReadArea()
		{
			txtX.Text = LookIn.Item1.X.ToString();
			txtY.Text = LookIn.Item1.Y.ToString();
			txtHeight.Text = LookIn.Item2.Height.ToString();
			txtWidth.Text = LookIn.Item2.Width.ToString();
		}

		private void btnColor_Click(object sender, System.EventArgs e)
		{
			var cd = new ColorDialog();
			cd.Color = LookFor;
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				DataReader.SaveColor(LookFor = cd.Color);
				ReadColor();
			}
		}

		private void ReadColor()
		{
			txtColor.Text = string.Concat(LookFor.R, ",", LookFor.G, ",", LookFor.B);
			txtCol.BackColor = LookFor;
		}

		#endregion

		private void btnTest_Click(object sender, EventArgs e)
		{
			new Test().Show();
		}

		private void btnStartStop_Click(object sender, System.EventArgs e)
		{
			var start = btnStartStop.Text == StartMsg;
			btnStartStop.Text = start ? StopMsg : StartMsg;

			if (!start && Finder != null)
			{
				Finder.Abort();
				Finder.Args.Cancelled = true;
				Finder = null;
				SetMessage("stopped");
			}
			else
			{
				var args = new ScreenReader.ReaderArgs(LookFor, txtMouseCol, lblWhere, chkTrack.Checked, LookIn, int.Parse(txtStep.Text));
				Finder = new ThreadHelper<ScreenReader.ReaderArgs, Point>(ScreenReader.FindColorInArea, args);
				Finder.Completed += new EventHandler(LoopFinder);
				Finder.Run();
				SetMessage("started");
			}
		}

		private void LoopFinder(object sender, EventArgs e)
		{
			var m = Finder.Result;
			if (m != Point.Empty)
			{
				btnStartStop.PerformClick();
				MouseSimulator.MoveTo(m);
				MouseSimulator.Click(MouseButton.Left);
				SetMessage("found");
			}
			else
			{
				Finder.Run();
			}
		}

		private void SetMessage(string msg)
		{
			lblMsg.Text = msg + " at " + DateTime.Now.ToLongTimeString();
		}
	}
}
