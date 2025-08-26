using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AmadeusWeb.SmartSiteUploader
{
    public class Exclusions // Cannot be static if want to sxe inner class
	{
		private static List<Info> Rules;

		public enum Type
		{
			File,
			FolderAnywhere,
			Extension,
		}

		static Exclusions()
		{
			StoreHelper.RegisterAlias<List<Info>>("Exclusions");
			CheckRules();
		}

		public static bool Exclude(string path)
		{
			var m = Rules.FirstOrDefault(x => x.Match(path));

            if (m != null && false) //skip this verbose logging
				FtpHelper.SetMessage(string.Format("excluded '{0}' matching rule {1} '{2}'", path, m.How, m.What));

			return m != null;
		}

		private static void CheckRules()
		{
			if ((Rules = Rules ?? StoreHelper.Read<List<Info>>()) == null)
			{
				Rules = new List<Info>
				{
					new Info{ How = Type.FolderAnywhere, What = ".git" },
					new Info { How = Type.FolderAnywhere, What = ".files" },
					new Info{ How = Type.File, What = ".git" },
				};

				StoreHelper.Save(Rules);
			}
		}

		public class Info
		{
			[XmlAttribute]
			public string What { get; set; }

			[XmlAttribute]
			public Type How { get; set; }

			public bool Match(string path)
			{
				switch (How)
				{
					case Type.FolderAnywhere:
						return path.Contains(What);
					case Type.File:
						return What == Path.GetFileName(path);
					case Type.Extension:
						return What == Path.GetExtension(path);
					default:
						throw new NotSupportedException();
				}
			}
		}
	}
}
