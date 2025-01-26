using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AmadeusWeb.IViewer
{
	/// <summary>
	/// Some Assorted Helper Methods
	/// </summary>
	public static class SysHelper
	{
		/// <summary>
		/// Returns Item at the given position.
		/// If it was the last item removed (no item at oldIndex), it returns the last item of the list.
		/// if no items remain, returns default(T)
		/// </summary>
		public static T IndexOrDefault<T>(this IList<T> list, int oldIndex)
		{
			if (list.Count > oldIndex + 1)
			{
				return list[oldIndex];
			}
			else if (list.Count > 0)
			{
				return list[list.Count - 1];
			}

			return default(T);
		}

		public static T[] DownCast<T>(this IEnumerable list)
		{
			return list.Cast<T>().ToArray();
		}

		public static void OpenSearch(string text)
		{
			var txt = string.Format("[InternetShortcut]{0}URL=http://www.google.com/search?q={1}", Environment.NewLine, text);
			var link = "lastsearch.url";
			IOHelper.Overwrite(link, txt);
			IOHelper.Run(link);
		}
	}
}
