using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Cselian.Core;

namespace Cselian.FTPSync
{
	/// <summary>
	/// 
	/// </summary>
	public class Exclusions // Cannot be static if want to sxe inner class
	{
		private static List<Info> Rules;
		private static List<Info> MyRules;
		private static string LastSelected;

		public enum Type
		{
			File,
			Folder,
			FolderName,
			Extension,
		}

		static Exclusions()
		{
			StoreHelper.RegisterAlias<List<Info>>("Exclusions");
		}

		public static bool Exclude(string path)
		{
			CheckRules();

			var p = path.ToLower();
			var f = Path.GetFileName(path);
			var e = Path.GetExtension(path);

			var m = MyRules.FirstOrDefault(x => x.Match(p, f, e));
			if (m != null)
			{
				FtpHelper.SetMessage(string.Format("excluded '{0}' matching rule {1} '{2}'", path, m.How, m.What));
			}

			return m != null;
		}

		private static void CheckRules()
		{
			if ((Rules = Rules ?? StoreHelper.Read<List<Info>>()) == null)
			{
				Rules = new List<Info>
				{
					new Info{ How = Type.FolderName, What = ".svn" },
					//new Info { How = Type.Extension, What = ".txt" },
					new Info { How = Type.FolderName, What = "_files" },
					new Info { How = Type.FolderName, What = "protected\\runtime" },
					new Info { How = Type.File, What = ".htaccess" }
				};

				StoreHelper.Save(Rules);
			}

			if (LastSelected != FtpInfo.Selected.Name)
			{
				MyRules = Rules.Where(x => string.IsNullOrEmpty(x.Workspace) || x.Workspace == FtpInfo.Selected.Name).ToList();
				LastSelected = FtpInfo.Selected.Name;
			}
		}

		public class Info
		{
			[XmlAttribute]
			public string What { get; set; }

			[XmlAttribute]
			public Type How { get; set; }

			[XmlAttribute]
			public string Workspace { get; set; }

			public bool Match(string path, string file, string extension)
			{
				switch (How)
				{
					case Type.File:
						return What == file;
					case Type.Folder:
						return path.StartsWith(What + "\\");
					case Type.FolderName:
						return path.StartsWith(What + "\\") || path.Contains("\\" + What + "\\");
					case Type.Extension:
						return What == extension;
					default:
						throw new NotSupportedException();
				}
			}
		}
	}
}
