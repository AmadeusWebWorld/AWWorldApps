using System.Collections.Generic;

namespace Cselian.FTPSync
{
	/// <summary>
	/// Helper methods pertaining to collections of objects
	/// </summary>
	public static class ListHelper
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

		public static TV ValueOrDefault<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV defaultValue)
		{
			TV val;
			return dict.TryGetValue(key, out val) ? val : defaultValue;
		}
	}
}
