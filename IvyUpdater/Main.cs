using System;
using System.IO;
using System.Windows.Forms;
using Cselian.Core;

namespace Cselian.IvyUpdater
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			this.IsOnUIThread();
			var settings = UpdateManager.ReadSettings();
			Text = UpdateManager.Caption;
			Icon = Properties.Resources.updater;
			var jpg = settings.ProgramName + ".jpg";
			picProduct.ImageLocation = new FileInfo(File.Exists(jpg) ? jpg : @"Resources\" + jpg).FullName;

			var checker = new ThreadHelper<UpdateSettings, bool>(CheckForUpdates, settings);
			SetProgress(false, "Checking for Updates");
			checker.Completed += checker_Completed;
			checker.Run();
		}

		private bool CheckForUpdates(UpdateSettings settings)
		{
			if (string.IsNullOrEmpty(settings.Url))
			{
				SetStatus("Update URL Must not be blank", MessageBoxIcon.Error);
				return false;
			}

			var file = StoreHelper.GetName<UpdateVersion>(settings.ProgramName);
			var url = settings.Url + file;
			SetStatus("Checking version at:" + Environment.NewLine + url);
			SetProgress(false);
			return HttpHelper.SaveTo(url, file);
		}

		private void checker_Completed(object sender, System.EventArgs e)
		{
			SetProgress(true);
			var checker = (ThreadHelper<UpdateSettings, bool>)sender;
			if (!checker.Result)
			{
				SetStatus("Checking Failed");
				return;
			}

			var current = StoreHelper.Read<UpdateVersion>();
			var server = StoreHelper.Read<UpdateVersion>(checker.Args.ProgramName);

			if (current.Version == server.Version)
			{
				SetStatus("Latest Version");
			}
			else if (current.Version > server.Version)
			{
				Program.LogMessage("You seem to have a higher version than the latest, Please contact us at: " + checker.Args.Support, MessageBoxIcon.Exclamation);
				SetStatus("Higher version. Contact Support");
			}
			else
			{
				SetStatus(string.Format("A new version {0} dated {1} is available", server.Version, server.Date.ToString("dd MMM yyyy")));
				SetNext(checker.Args, true);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			var settings = (UpdateSettings)btnNext.Tag;
			btnNext.Visible = false;
			var download = new ThreadHelper<UpdateSettings, bool>(DownloadUpdates, settings);
			download.Completed += download_Completed;
			SetProgress(false, "Downloading Updates");
			download.Run();
		}

		private bool DownloadUpdates(UpdateSettings settings)
		{
			var file = UpdateManager.GetZipName(settings);
			var url = settings.Url + file;
			StoreHelper.Delete(file);
			SetStatus("Downloading updates from:" + Environment.NewLine + url);
			return HttpHelper.SaveTo(url, file);
		}

		private void download_Completed(object sender, System.EventArgs e)
		{
			SetProgress(true);
			var dloader = (ThreadHelper<UpdateSettings, bool>)sender;
			if (!dloader.Result)
			{
				SetStatus("Downloading Failed");
				return;
			}

			var zip = UpdateManager.GetZipName(dloader.Args);
			Program.LogMessage("Please extract the zip file to this folder (Extract Here): " + Environment.NewLine + zip, MessageBoxIcon.Information);
			zip = new FileInfo(zip).FullName;
			Program.Run("explorer.exe", "/select," + zip);
		}

		private void SetProgress(bool ended, string message = null)
		{
			if (this.IsOnUIThread())
			{
				pbarWorking.Visible = !ended;
				if (!ended)
				{
					lblMessage.Text = message;
				}
			}
			else
			{
				Invoke(new MethodInvoker(delegate() { pbarWorking.Visible = !ended; }));
				if (!ended)
				{
					Invoke(new MethodInvoker(delegate() { lblMessage.Text = message; }));
				}
			}
		}

		private void SetStatus(string message, MessageBoxIcon? icon = null)
		{
			if (this.IsOnUIThread())
			{
				lblAction.Text = message;
			}
			else
			{
				Invoke(new MethodInvoker(delegate() { lblAction.Text = message; }));
			}

			Program.LogMessage(message, icon);
		}

		private void SetNext(UpdateSettings tag, bool visible)
		{
			btnNext.Tag = tag;
			if (this.IsOnUIThread())
			{
				btnNext.Visible = true;
			}
			else
			{
				//Invoke(new MethodInvoker(delegate() { ; }));
				Invoke(new MethodInvoker(delegate() { btnNext.Visible = true; }));
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
