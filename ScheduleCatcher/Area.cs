using System.Drawing;
using System.Windows.Forms;

namespace Cselian.ScheduleCatcher
{
	public partial class Area : Form
	{
		public Area()
		{
			InitializeComponent();
			Opacity = 0.50;
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			var a = DataReader.GetArea();
			if (a != null)
			{
				var picStart = picRegion.PointToScreen(Point.Empty);
				Location = new Point(a.Item1.X + Location.X - picStart.X , a.Item1.Y + Location.Y - picStart.Y);
				Size = new Size(a.Item2.Width + Size.Width - picRegion.Width, a.Item2.Height + Size.Height - picRegion.Height);
			}
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			// base.OnPaintBackground(e);
			e.Graphics.Clear(Color.White);
		}

		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			var picStart = picRegion.PointToScreen(Point.Empty);
			DataReader.SaveArea(picStart, picRegion.Size);
			Close();
		}
	}
}
