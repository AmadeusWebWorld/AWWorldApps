using System.Collections.Generic;
using System.IO;

namespace Cselian.FTPSync
{
	public static class VCS
	{
		//public static bool ShowFolSize { get; set; }

		public class Fol
		{
			public string Name { get; private set; }
			public string FolPath { get; private set; }
			public string Size { get; private set; }
			public List<Fol> Fols { get; set; }

			public Fol(DirectoryInfo di)
			{
				Name = di.Name;
				FolPath = di.FullName;
				Fols = ReadFol(di);
				if (Fols == null)
					Size = IOHelper.GetFolSize(di);
			}

			public Fol(string parentFol, string line)
			{
				var bits = line.Split('=');
				Name = bits[0].TrimStart();
				FolPath = Path.Combine(parentFol, Name);
				if (bits.Length == 1)
					Size = IOHelper.GetFolSize(new DirectoryInfo(FolPath));
				else
					Size = bits[1];
			}

			public override string ToString()
			{
				return Name + (Fols == null ? " [" + Size + "]"  : string.Empty);
			}
		}

		public static List<Fol> ReadRoot()
		{
			var root = Path.Combine(FtpInfo.Selected.LocalFolder, "_root.txt");
			if (File.Exists(root))
				return ReadFols(File.ReadAllLines(root));
			else
				return ReadFols();
		}

		public static List<Fol> ReadFols()
		{
			var fols = ReadFol(new DirectoryInfo(FtpInfo.Selected.LocalFolder));
			WriteFols(fols);
			return fols;
		}

		private static List<Fol> ReadFol(DirectoryInfo fol)
		{
			var list = new List<Fol>();
			foreach (var f in fol.GetDirectories())
			{
				list.Add(new Fol(f));
			}
			return list.Count > 0 ? list : null;
		}

		private static void WriteFols(List<Fol> fols)
		{
			var lines = new List<string>();
			WriteFols(lines, fols, 0);
			var root = Path.Combine(FtpInfo.Selected.LocalFolder, "_root.txt");
			if (!File.Exists(root))
			{
				File.WriteAllLines(root, lines.ToArray());
			}
			else
			{
				var mine = Path.Combine(FtpInfo.Selected.LocalFolder, "_root.mine.txt");
				File.WriteAllLines(mine, lines.ToArray());
				IOHelper.DiffOrDelete(root, mine);
			}
		}

		private static void WriteFols(List<string> lines, List<Fol> fols, int indent)
		{
			if (fols == null) return;
			var prefix = string.Empty.PadRight(indent).Replace(" ", "\t");
			foreach (var fol in fols)
			{
				lines.Add(prefix + fol.Name + (fol.Size != null ? "=" + fol.Size : null));
				WriteFols(lines, fol.Fols, indent + 1);
			}
		}

		private static int _indent;
		private static string _parent;
		private static Fol _root;
		private static Stack<Fol> fols = new Stack<Fol>();

		private static List<Fol> ReadFols(string[] lines)
		{
			_indent = 0;
			_parent = FtpInfo.Selected.LocalFolder;
			fols.Push(_root = new Fol(_parent, ""));
			foreach (var fol in lines)
				ReadFol(fol);
			return _root.Fols;
		}

		private static void ReadFol(string fol)
		{
			var f = fols.Peek();
			if (f.Fols == null) f.Fols = new List<Fol>();
			var indent = fol.Length - fol.Replace("\t", string.Empty).Length;
			if (indent == _indent)
			{
				f.Fols.Add(new Fol(_parent, fol));
			}
			else if (indent < _indent)
			{
				while (indent < _indent)
				{
					f = fols.Pop();
					_parent = new DirectoryInfo(_parent).Parent.FullName;
					_indent--;
				}
				f.Fols.Add(new Fol(_parent, fol));
			}
			else if (indent > _indent)
			{
				_indent = indent;
				var n = new Fol(_parent, fol);
				f.Fols.Add(n);
				_parent = Path.Combine(_parent, n.Name);
				fols.Push(n);
			}
		}
	}
}
