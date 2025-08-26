using System;
using System.Windows.Forms;

namespace AmadeusWeb.SmartSiteUploader
{
	public class Program
	{
		public readonly static string Caption = "AmadeusWeb.com's Smart Site Uploader (FTPSync)";

		public static bool SilentMode { get; private set; }

		public static bool RunGrabber { get; set; }

		public static int VCSMode { get; set; }

		[STAThread]
		public static void Main(string[] args)
		{
			if (FtpInfo.Options.Count > 0)
				FtpInfo.SetSelected(FtpInfo.Options[0].Name);

			if (VCSMode == 1)
				new Main().Show();
			if (VCSMode == 0)
				Application.Run(new Main());
			else
				Application.Run(new VCSUI());
		}
	}
}
