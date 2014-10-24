using System;
using System.Collections.Generic;
using System.IO;

namespace Cselian.IViewer
{
	public class LyricInfo
	{
		public LyricInfo(string f)
		{
			var list = new List<Line>();
			var grp = 1;
			var lines = File.ReadAllLines(f);

			foreach (string l in lines)
			{
				if (string.IsNullOrEmpty(l))
				{
					grp += 1;
					continue;
				}

				var i = new Line(grp, l);
				if (!HasTimeMarkers && i.Start != default(double))
				{
					HasTimeMarkers = true;
				}

				list.Add(i);
			}

			Lines = list.ToArray();
		}

		public Line[] Lines { get; private set; }

		public bool HasTimeMarkers { get; private set; }

		#region Static

		public static bool Exists(string p)
		{
			return File.Exists(FileOf(p));
		}

		public static LyricInfo Load(string p)
		{
			return new LyricInfo(FileOf(p));
		}

		#endregion

		public Line Find(double where)
		{
			Line ret = null;
			foreach (var l in Lines)
			{
				if (l.Start > where)
				{
					return ret;
				}

				ret = l;
			}

			return null;
		}

		public Line FindFirst(int group)
		{
			foreach (var l in Lines)
			{
				if (l.Group == group)
				{
					return l;
				}
			}

			return null;
		}

		public bool Within(Line item, double where)
		{
			if (item == null)
			{
				return false;
			}

			if (where < item.Start)
			{
				return false;
			}

			var ix = Array.IndexOf(Lines, item);
			if (ix == Lines.Length - 1)
			{
				return true;
			}

			Line nxt = Lines[ix + 1];
			return nxt.Start > @where;
		}

		private static string FileOf(string p)
		{
			return p.Replace(Path.GetExtension(p), ".lrc");
		}

		private static double TimeOf(string v)
		{
			////00:04.13
			var hms = v.Split(":".ToCharArray());
			var h = 0;
			if (hms.Length > 2)
			{
				h = int.Parse(hms[0]) * 3600;
			}

			var secs = double.Parse(hms[hms.Length - 1]);
			secs += (int.Parse(hms[hms.Length - 2]) * 60) + h;
			return secs;
		}

		public class Line
		{
			private string startString;

			public Line(int g, string line)
			{
				Group = g;
				if (line.StartsWith("[") & line.Contains("]"))
				{
					var bits = line.Substring(1, line.Length - 1).Split("]".ToCharArray(), 2);
					startString = bits[0];
					Start = TimeOf(bits[0]);
					Text = bits[1];
				}
				else
				{
					Text = line;
				}
			}

			public int Group { get; private set; }

			public string DisplayText
			{
				get { return string.Format("[{0}  {2}] {1}", startString, Text, Group); }
			}

			public double Start { get; private set; }

			public string Text { get; private set; }

			public void MoveStart(double val)
			{
				Start = val;
			}

			public void MoveBy(double val)
			{
				Start = Start + val;
			}
		}
	}
}