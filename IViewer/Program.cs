using System;
using System.Windows.Forms;
using Cselian.IvyUpdater;

namespace Cselian.IViewer
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (UpdateManager.MustCheckForUpdates())
				UpdateManager.CheckForUpdates();

			//Application.Run(new ViewSettings());
			Application.Run(new UI.Main());
		}
	}
}
