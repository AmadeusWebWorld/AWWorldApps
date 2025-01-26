using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AmadeusWeb
{
	/// <summary>
	/// Reads / Writes the various types of stores.
	/// </summary>
	public static class StoreHelper
	{
		private static readonly Dictionary<System.Type, string> Aliases = new Dictionary<System.Type, string>();
		private static readonly List<System.Type> InData = new List<System.Type>();

		private static string MyDataFolder;

		public static string DataFolder { get { return MyDataFolder ?? (MyDataFolder = GetDataFolder()); } }

		public static void RegisterAlias<T>(string name)
		{
			Aliases.Add(typeof(T), name);
		}

		public static void RegisterInData<T>()
		{
			InData.Add(typeof(T));
		}

        		public static T Read<T>()
		{
            return Read<T>(null);
        }

		public static T Read<T>(string splName)
		{
			var file = GetPath<T>(splName);
			if (!file.Exists)
			{
				return default(T);
			}

			var xml = GetSerializer<T>();
			var ip = file.OpenRead();
			var x = new XmlTextReader(ip);
			var r = xml.Deserialize(x);
			ip.Close();

			return (T)r;
		}

		public static T Save<T>(T obj)
		{
            return Save<T>(obj, null);
        }

		public static T Save<T>(T obj, string splName)
		{
			var xml = GetSerializer<T>();
			var file = GetPath<T>(splName);
			if (file.Exists)
			{
				file.Delete();
			}

			var op = file.OpenWrite();
			xml.Serialize(op, obj);
			op.Close();
			return obj;
		}

		public static string GetName<T>(string splName)
		{
			return GetPath<T>(splName).Name;
		}

		public static void Delete(string file)
		{
			if (File.Exists(file))
			{
				File.Delete(file);
			}
		}

		private static string GetDataFolder()
		{
			var isDev = System.Environment.CurrentDirectory.Contains(@"bin\Debug");
			var list = isDev ? new[] { @"..\..\Data\", @"..\..\..\Data\" } : new[] { @"Data\" };
			foreach (var item in list)
			{
				if (Directory.Exists(item))
				{
					return item;
				}
			}

			return string.Empty;
		}

		private static FileInfo GetPath<T>(string splName)
		{
			if (string.IsNullOrEmpty(splName) == false)
			{
				splName = "-" + splName;
			}

			string name;
			if (Aliases.TryGetValue(typeof(T), out name) == false)
			{
				name = typeof(T).Name;
				if (typeof(T).IsGenericType && name.StartsWith("List"))
				{
					name = typeof(T).GetGenericArguments()[0].Name + "s";
				}
			}

			var path = string.Empty;
			if (InData.Contains(typeof(T)))
			{
				path = DataFolder;
			}

			return new FileInfo(string.Format("{2}{0}{1}.xml", name, splName, path));
		}

		private static XmlSerializer GetSerializer<T>()
		{
			return new XmlSerializer(typeof(T));
		}
	}
}
