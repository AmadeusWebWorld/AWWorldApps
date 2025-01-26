using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AmadeusWeb.IViewer
{
	public class ExtensionFilter
	{
		public const string MetaNone = "";

		public static readonly string[] TextExtensions = new string[] { "srt", "lrc", "txt" };

		public static bool IsText(string e)
		{
			return TextExtensions.Contains(e);
		}

		public string Text { get; private set; }

		private readonly bool _exclusive;

		private readonly List<string> _extensions;

		public ExtensionFilter(string extensions)
		{
			Text = extensions;

			if (extensions.Contains("|"))
			{
				extensions = extensions.Split('|')[0];
			}

			if (extensions.Length == 0)
			{
				return;
			}

			if (extensions.StartsWith("^"))
			{
				_exclusive = true;
				extensions = extensions.Substring(1);
			}

			_extensions = extensions.ToLower().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x.Trim()).ToList();
		}

		public bool Include(FileInfo fi)
		{
			if (_extensions == null) return true;
			var found = _extensions.Contains(fi.Extension.Replace(".", string.Empty).ToLower());
			return found != _exclusive;
		}
	}
}
