using System.IO;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	/// <summary>
	/// 
	/// </summary>
	public static class VidEngine
	{
		public static readonly string LegacyLibrary = "Time Library.ini";
		public static readonly string LogInvalidFiles = "InvalidFiles.log";
		public static readonly string PlaylistFolder;

		public static readonly AppSettings Settings;

		private static readonly string SettingsFile = "Settings.xml";

		private static Splash splash;

		static VidEngine()
		{
			////SettingsFile = new FileInfo((File.Exists(@"..\..\") ? @"..\..\" : string.Empty) + "Settings.xml");
			Settings = LoadSettings();

			var fol = new DirectoryInfo("Playlists");
			if (!fol.Exists)
			{
				fol.Create();
			}

			PlaylistFolder = fol.FullName + @"\";
		}

		public static Main MainInst { get; set; }

		public static bool ChangingFiles { get; set; }

		public static void SetLoadStatus(string msg, int sleep = 0, bool load = false)
		{
			if (splash == null && load == false)
			{
				return;
			}

			if (splash == null)
			{
				splash = new Splash();
				splash.Show();
				Application.DoEvents();
			}

			if (string.IsNullOrEmpty(msg))
			{
				splash.Close();
				return;
			}

			splash.SplashLabel = msg;
			if (sleep > 0)
			{
				System.Threading.Thread.Sleep(sleep);
			}
		}

		#region Settings

		public static void SaveSettings(AppSettings s = null)
		{
			IOHelper.Save(s ?? Settings, SettingsFile);
		}

		private static AppSettings LoadSettings()
		{
			var s = IOHelper.Load<AppSettings>(SettingsFile);
			if (s == null)
				SaveSettings(s = new AppSettings { FavoriteFolders = @"D:\Imran\M|d:\Imran\dmi", LVWDateTimeFormat = "dd MMM yyyy hh:mm:ss" });

			return s;
		}

		#endregion
	}
}
