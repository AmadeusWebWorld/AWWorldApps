using System;
using System.Windows.Forms;
using Cselian.Core;

namespace Cselian.Utilities.WinXT
{
	public class Program
	{
		[STAThread]
		public static void Main()
		{
			// TODO: Add a temp cleaner that uses Exclusions
			if (ProcessHelper.IsAnotherProcessRunning())
			{
				MessageBox.Show("Another instance is running already. Hit Win + W to give it Focus", "Win XT");
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (IvyUpdater.UpdateManager.MustCheckForUpdates())
				IvyUpdater.UpdateManager.CheckForUpdates();

			Application.Run(ProcessHelper.Register(new Main()));
		}
	}
}
