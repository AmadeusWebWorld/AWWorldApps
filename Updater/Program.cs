using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace AmadeusWeb.Updater
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// args = new string[] { "/set" };

			if (args.Length == 1)
			{
				var arg = args[0];
				if (arg == "/gen")
				{
					StoreHelper.Save(new UpdateVersion { Version = 515, Date = DateTime.Today });
					UpdateManager.ReadSettings(); // ensures that its there
				}
				else if (arg == "/set")
				{
					Application.Run(new ViewSettings());
				}
			}
			else
			{
				Application.Run(new Main());
			}
		}

		public static void LogMessage(string msg, MessageBoxIcon? icon = null)
		{
			if (icon.HasValue) MessageBox.Show(msg, UpdateManager.Caption, MessageBoxButtons.OK, icon.Value);

			msg = string.Format("{0} - {1}", DateTime.Now.ToString("HH:mm:ss"), msg);

			// Log.AppendText(msg + Environment.NewLine);
			File.AppendAllText("IvyUpdater.log", DateTime.Now.ToString("dd MMM yyyy ") + msg + Environment.NewLine);
		}

		public static void Run(string what, string with = null)
		{
			if (with == null)
				Process.Start(what);
			else
				Process.Start(what, with);
		}
	}
}
