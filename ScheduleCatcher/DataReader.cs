using System;
using System.Drawing;
using System.IO;

namespace Cselian.ScheduleCatcher
{
	/// <summary>
	/// Reads/Saves Coords and Colour out of text files
	/// </summary>
	public static class DataReader
	{
		private const string AreaTxt = "area.txt";
		private const string ColorTxt = "colour.txt";

		public static Tuple<Point, Size> GetArea()
		{
			if (!File.Exists(AreaTxt)) return null;
			var s = File.ReadAllText(AreaTxt).Split(',');
			return new Tuple<Point, Size>(new Point(int.Parse(s[0]), int.Parse(s[1])), new Size(int.Parse(s[2]), int.Parse(s[3])));
		}

		public static Color GetColor()
		{
			if (!File.Exists(ColorTxt)) return Color.Empty;
			var s = File.ReadAllText(ColorTxt).Split(',');
			return Color.FromArgb(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
		}

		public static void SaveArea(Point l, Size sz)
		{
			var s = string.Concat(l.X, ",", l.Y, ",", sz.Width, ",", sz.Height);
			File.WriteAllText(AreaTxt, s);
		}

		public static void SaveColor(Color c)
		{
			var s = string.Concat(c.R, ",", c.G, ",", c.B);
			File.WriteAllText(ColorTxt, s);
		}
	}
}
