using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Cselian.Core;

namespace AmadeusWeb.SmartSiteUploader
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

            Info m = null;
            foreach (var item in MyRules)
            {
                if (item.Match(p, f, e))
                {
                    m = item;
                    break;
                }
            }

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
					new Info{ How = Type.FolderName, What = ".git" },
					//new Info { How = Type.Extension, What = ".txt" },
					new Info { How = Type.FolderName, What = "_files" },
					new Info { How = Type.FolderName, What = "protected\\runtime" },
					//new Info { How = Type.File, What = ".htaccess" }
				};

				StoreHelper.Save(Rules);
			}

			if (LastSelected != FtpInfo.Selected.Name)
			{
                MyRules = new List<Info>();
                foreach (var item in Rules)
                    if (string.IsNullOrEmpty(item.Workspace) || item.Workspace == FtpInfo.Selected.Name)
                        MyRules.Add(item);
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
