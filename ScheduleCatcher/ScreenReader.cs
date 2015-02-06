using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cselian.ScheduleCatcher
{
	/// <summary>
	/// 
	/// </summary>
	public static class ScreenReader
	{
		private static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

		public static Point FindColorInArea(ReaderArgs a)
		{
			var x = a.Where.Item1.X + (a.Where.Item2.Width / 2);

			////for (int x = where.Item1.X; x < where.Item1.X + where.Item2.Width; x += 18)
			{
				for (int y = a.Where.Item1.Y; y < a.Where.Item1.Y + a.Where.Item2.Height; y += a.Step)
				{
					if (a.Cancelled) return Point.Empty;

					var yd = 0; // y delta
				dodelta:
					var pt = new Point(x, y + yd);
					if (a.Track) MouseSimulator.MoveTo(pt);
					var c = GetColorAt(pt);
					a.InvokeSetColor(c);
					a.InvokeSetPosition(pt);
					Application.DoEvents();
					System.Threading.Thread.Sleep(10);
					if (c == a.What)
					{
						if (yd == 0)
						{
							yd = 1;
							goto dodelta;
						}

						return pt;
					}

					/* within range was needed only because jpg stretching messed up the colors
					else if (c.WithinRange(what, 10))
					{
						return pt;
					}*/
				}
			}

			return Point.Empty;
		}

		private static bool WithinRange(this Color c1, Color c2, int range)
		{
			return c2.R - range < c1.R && c1.R < c2.R + range
				&& c2.G - range < c1.G && c1.G < c2.G + range
				&& c2.B - range < c1.B && c1.B < c2.B + range;
		}

		private static Color GetColorAt(Point location)
		{
			// http://www.codeproject.com/Articles/17335/Pure-C-NET-Desktop-Color-Picker-With-Magnifying-Gl
			var bmp = new Bitmap(1, 1);
			var g = Graphics.FromImage(bmp);
			g.CopyFromScreen(location, new Point(0, 0), bmp.Size);
			return bmp.GetPixel(0, 0);
		}

		public class ReaderArgs
		{
			public readonly Color What;
			public readonly bool Track;
			public readonly Tuple<Point, Size> Where;
			public readonly int Step;

			private readonly TextBox ColorAt;
			private readonly Label ScanningAt;

			public ReaderArgs(Color what, TextBox colorAt, Label scanningAt, bool track, Tuple<Point, Size> where, int step)
			{
				What = what;
				ColorAt = colorAt;
				ScanningAt = scanningAt;
				Track = track;
				Where = where;
				Step = step;
			}

			public bool Cancelled { get; set; }

			public void InvokeSetColor(Color c)
			{
				ColorAt.Invoke(new MethodInvoker(delegate() { ColorAt.BackColor = c; }));
			}

			public void InvokeSetPosition(Point p)
			{
				var loc = string.Format("@ {0}, {1}", p.X, p.Y);
				ScanningAt.Invoke(new MethodInvoker(delegate() { ScanningAt.Text = loc; }));
			}
		}
	}
}
