using System;
using System.Collections.Generic;

namespace Cselian.Core
{
	/// <summary>
	/// Stores last changed / loaded per Enum so that UI building can be optimized
	/// </summary>
	public class LoadTimer<T>
	{
		private Dictionary<T, DateTime> Times = new Dictionary<T, DateTime>();

		public LoadTimer()
		{
			var list = Enum.GetValues(typeof(T));
			foreach (var item in list)
			{
				Times.Add((T)item, DateTime.Now);
			}
		}

		public bool Gt(LoadTimer<T> compareTo, T what)
		{
			return Times[what] > compareTo.Times[what];
		}

		public void Set(T what)
		{
			Times[what] = DateTime.Now;
		}
	}
}
