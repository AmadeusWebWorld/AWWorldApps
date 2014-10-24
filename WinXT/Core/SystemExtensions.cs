using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Cselian.Core
{
	public static class SystemExtensions
	{
		public static bool HasBitflag(this FileAttributes enumVal, params FileAttributes[] enumToMatch)
		{
			foreach (var item in enumToMatch)
			{
				if ((enumVal & item) == item) return true;
			}

			return false;
		}

		public static void Run(string what, string with = null)
		{
			if (with == null)
				Process.Start(what);
			else
				Process.Start(what, with);
		}

		public static string GetLinkTarget(string shortcutFile)
		{
			var content = ReadContents(shortcutFile);

			// TODO: Better way
			var start = content.LastIndexOf(@"D:\");
			var txt = content.Substring(start);
			txt = txt.Substring(0, txt.IndexOf('`'));
			return txt;
		}

		private static string ReadContents(string shortcutFile)
		{
			var bytes = File.ReadAllBytes(shortcutFile).Where(x => x >= 32).ToArray();
			return string.Join(string.Empty, Encoding.ASCII.GetChars(bytes).Select(x => x.ToString()).ToArray());
		}
	}
}
