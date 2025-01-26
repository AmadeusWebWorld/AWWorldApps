using AmadeusWeb.Updater;
using System;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer
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
