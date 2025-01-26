using System.Collections.Generic;
using System.IO;

namespace AmadeusWeb.SmartSiteUploader
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
			public List<Fil> Fils { get; set; }

			public string IndexFile { get; private set; }
			public string MyIndexFile { get; private set; }

			public Fol(DirectoryInfo di)
			{
				Name = di.Name;
				SetFol(di.FullName);
				Fols = ReadFol(di);
				if (Fols == null)
				{
					Size = IOHelper.GetFolSize(di, Indexes);
					Fils = ReadFiles(this);
				}
			}

			public Fol(string parentFol, string line)
			{
				var bits = line.Split('=');
				Name = bits[0].TrimStart();
				SetFol(Path.Combine(parentFol, Name));

				if (File.Exists(MyIndexFile))
					Fils = ReadFiles(this, MyIndexFile);
				else if (File.Exists(IndexFile))
					Fils = ReadFiles(this, IndexFile);
				
				if (bits.Length == 1)
					Size = IOHelper.GetFolSize(new DirectoryInfo(FolPath));
				else
					Size = bits[1];
			}

			private void SetFol(string fol)
			{
				FolPath = fol;
				IndexFile = Path.Combine(fol, Indexes[0]);
				MyIndexFile = Path.Combine(fol, Indexes[1]);
			}

			public override string ToString()
			{
				return Name + (Fols == null ? " [" + Size + "]"  : string.Empty);
			}
		}

		#region Fols

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
				if (f.Name == "_revisions") continue;
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
					f = fols.Peek();
					_parent = new DirectoryInfo(_parent).Parent.FullName;
					_indent--;
				}
				f.Fols.Add(new Fol(_parent, fol));
			}
			else if (indent > _indent)
			{
				_indent = indent;
				_parent = Path.Combine(_parent, f.Fols[f.Fols.Count - 1].Name);
				var n = new Fol(_parent, fol);
				if (f.Fols[f.Fols.Count - 1].Fols == null) f.Fols[f.Fols.Count - 1].Fols = new List<Fol>();
				f.Fols[f.Fols.Count - 1].Fols.Add(n);
				fols.Push(f.Fols[f.Fols.Count - 1]);
			}
		}

		#endregion

		public class Fil
		{
			public string FullPath { get; private set; }
			public string Name { get; private set; }
			public string Mine { get; private set; }

			public bool Editing { get; private set; }

			public Fil(FileInfo fi)
			{
				FullPath = fi.FullName;
				Name = fi.Name;
				Mine = Path.ChangeExtension(FullPath, ".mine" + fi.Extension);
				Editing = File.Exists(Mine);
			}

			public Fil(string path, string name) : this(new FileInfo(Path.Combine(path, name)))
			{
			}

			public override string ToString()
			{
				return Name + (Editing ? "*" : string.Empty);
			}
		}

		#region Fils

		public static void RefreshFiles(Fol fol)
		{
			fol.Fils = ReadFiles(fol);
		}

		private static List<string> Indexes = new List<string> { "_index.txt", "_index.mine.txt" };

		private static List<Fil> ReadFiles(Fol fol)
		{
			var files = new List<Fil>();
			var di = new DirectoryInfo(fol.FolPath);
			foreach (var fil in di.GetFiles())
			{
				if (fil.Name.ToLower().Contains(".mine.")) continue;
				if (Indexes.Contains(fil.Name)) continue;
				files.Add(new Fil(fil));
			}

			WriteFils(fol, files);
			return files;
		}

		private static List<Fil> ReadFiles(Fol fol, string indexFile)
		{
			var files = new List<Fil>();
			var lines = File.ReadAllLines(indexFile);
			foreach (var file in lines)
			{
				files.Add(new Fil(fol.FolPath, file));
			}
			return files;
		}

		private static void WriteFils(Fol fol, List<Fil> fils)
		{
			var lines = new List<string>();

			foreach (var f in fils)
			{
				lines.Add(f.Name);
			}

			var root = Path.Combine(fol.FolPath, Indexes[0]);
			if (!File.Exists(root))
			{
				File.WriteAllLines(root, lines.ToArray());
			}
			else
			{
				var mine = Path.Combine(fol.FolPath, Indexes[1]);
				File.WriteAllLines(mine, lines.ToArray());
				IOHelper.DiffOrDelete(root, mine);
			}
		}

		#endregion
	}
}
