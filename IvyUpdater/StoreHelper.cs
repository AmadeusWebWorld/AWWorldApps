using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Cselian.IvyUpdater
{
	/// <summary>
	/// Reads / Writes the various types of stores.
	/// </summary>
	public static class StoreHelper
	{
		public static T Read<T>(string splName = null)
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

		public static void Save<T>(T obj, string splName = null)
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

		private static FileInfo GetPath<T>(string splName)
		{
			if (string.IsNullOrEmpty(splName) == false)
			{
				splName = "-" + splName;
			}

			return new FileInfo(string.Format("{0}{1}.xml", typeof(T).Name, splName));
		}

		private static XmlSerializer GetSerializer<T>()
		{
			return new XmlSerializer(typeof(T));
		}
	}
}
