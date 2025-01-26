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
		public static void Main(string[] str)
		{
			if (str == null || str.Length == 0 || (str.Length == 1 && str[0] == "ym"))
			{
				// if not SilentMode, FtpInfo.ctor will call SelectOption
				if (str.Length == 1)
				{
					SilentMode = true;
					VCSMode = 2;
					FtpInfo.SetSelected(str[0]);
				}
				else if (FtpInfo.Selected == null && RunGrabber == false)
				{
					MessageBox.Show(FtpInfo.HasMultipleOptions ? "Nothing Selected. Exiting" : "Create some options in the open file first", Caption);
					return;
				}

				if (RunGrabber)
				{
					/*
					Application.Run(new Grabber());
					*/
					throw new NotImplementedException("Grabber no longer supported!");
				}
				else
				{
					if (VCSMode == 1)
						new Main().Show();
					if (VCSMode == 0)
						Application.Run(new Main());
					else
						Application.Run(new VCSUI());
				}
				return;
			}

			SilentMode = true;
			if (str.Length == 1 & str[0] == "demo")
			{
				str = new string[]
				{
					"Svn",
					"/req",
					"http://code.cselian.com/ip.php",
					"ip.txt",
					"ip.txt"
				};
			}

			var frm = CreateDialog();
			FtpHelper.SetMessage("Command Line Params: " + string.Join(" ", str));

			FtpInfo.SetSelected(str[0]);

			FtpHelper.Credentials.UserName = FtpInfo.Selected.Username;
			if (FtpInfo.Selected.Password == string.Empty)
				FtpInfo.Selected.Password = FtpInfo.Selected.GetKey(Names.FtpPassword);
			FtpHelper.Credentials.Password = FtpInfo.Selected.Password;

			FtpHelper.SetMessage(str[1] + " - " + FtpInfo.Selected.ToString(), null);
			for (int i = 1; i <= str.Length - 1; i++)
			{
				if (str[i] == "/req")
				{
					FtpHelper.SetMessage("Save Request: " + str[i + 1] + " to: " + str[i + 2], null);
					SaveRequestTo(str[i + 1], str[i + 2]);
					i += 2;
				}
				else
				{
					FtpHelper.SetMessage("Uploading: " + str[i]);
					FtpHelper.SetMessage(FtpHelper.SyncFTP(str[i]));
				}

				Application.DoEvents();
			}

			frm.Hide();
			FtpHelper.SetMessage("Done Command Line Close dialog to exit");
			frm.ShowDialog();
		}

		private static void SaveRequestTo(string address, string relPath)
		{
			System.IO.File.WriteAllText(FtpInfo.Selected.LocalFolder + relPath, FtpHelper.MakeWebRequest(address));
		}

		private static Form CreateDialog()
		{
			Form frm = new Form();
			frm.Height = 250;
			frm.Width = 550;
			frm.Text = "FTP Sync /Silent";
			frm.StartPosition = FormStartPosition.CenterScreen;
			frm.KeyPreview = true;

			FtpHelper.Log = new TextBox();
			FtpHelper.Log.Multiline = true;
			FtpHelper.Log.Dock = DockStyle.Fill;

			frm.Controls.Add(FtpHelper.Log);
			frm.Show();
			return frm;
		}
	}
}