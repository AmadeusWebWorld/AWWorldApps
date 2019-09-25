using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Cselian.IViewer
{
	public class ExtensionFilter
	{
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
			var found = _extensions.Contains(fi.Extension.Replace(".", string.Empty).ToLower());
			return found != _exclusive;
		}
	}
}
