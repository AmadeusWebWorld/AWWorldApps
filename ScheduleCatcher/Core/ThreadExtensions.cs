using System.Threading;
using System.Windows.Forms;

namespace Cselian.IvyUpdater
{
	/// <summary>
	/// 
	/// </summary>
	public static class ThreadExtensions
	{
		private static Thread UIThread;

		public static bool IsOnUIThread(this Control ctl)
		{
			if (UIThread == null)
			{
				UIThread = Thread.CurrentThread;
			}

			return Thread.CurrentThread == UIThread;
		}
	}
}
