using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AmadeusWeb.SmartSiteUploader
{
	public class FtpInfo
	{
		public static readonly string ConfigFile = StoreHelper.DataFolder + "FTPUploader.ini";

		private static readonly string Default = @"Amadeus All=D:\AmadeusWeb\all\|ftp://ftp.amadeusweb.com/all/|amadeus|";

		#region "Static ctor / Properties"

		static FtpInfo()
		{
			Options = new List<FtpInfo>();
			ReadOptions();

			if (Program.SilentMode)
				return;
			Selected = null;
			if (HasMultipleOptions)
			{
				SelectOption();
			}
			else
			{
				if (File.Exists(ConfigFile) == false)
					File.WriteAllText(ConfigFile, Default + IOHelper.Encode("passwd"));

				IOHelper.RunInNotepad(ConfigFile);
			}
		}

		public FtpInfo(string line)
		{
			var nv = line.Split("=".ToCharArray(), 2, StringSplitOptions.None);
			Name = nv[0];
			var val = nv[1];

			var vals = val.Split('|');
			if (vals.Length > 0)
				LocalFolder = vals[0];
			if (vals.Length > 1)
				FtpFolder = vals[1];
			if (vals.Length > 2)
				Username = vals[2];
			if (vals.Length > 3)
				Password = IOHelper.Decode(vals[3]);
		}

		public static List<FtpInfo> Options { get; private set; }

		public static FtpInfo Selected { get; private set; }

		public static bool HasMultipleOptions
		{
			get { return Options.Count > 1; }
		}

		#endregion

		#region Instance Properties

		public string Name { get; private set; }

		public string FtpFolder { get; set; }

		public string Password { get; set; }

		public string Username { get; set; }

		public string LocalFolder { get; set; }

		#endregion

		#region Static Methods

		public static void ReadOptions()
		{
			string[] lines = null;
			if (File.Exists(ConfigFile))
			{
				lines = File.ReadAllLines(ConfigFile);
			}
			else
			{
				lines = new string[] { Default, Default.Replace("Amadeus Main", "Your Project") };
			}

			Options.Clear();
			foreach (var line in lines)
			{
				var item = new FtpInfo(line);
				Options.Add(item);
			}
		}

		public static List<FtpInfo> Clone()
		{
			return Clone(Options);
		}

		public static void Save(List<FtpInfo> list)
		{
			Options = Clone(list);
            var lines = new List<string>();
            foreach (var line in list)
                lines.Add(line.ToLine());
			File.WriteAllLines(ConfigFile, lines.ToArray());
		}

		// Consider making separate method as in IViewer
		public static void SelectOption()
		{
			var frm = new Select(Selected);
			if (frm.ShowDialog() == DialogResult.Cancel) return;
			Selected = frm.Selected;
		}

		public static void SetSelected(string name)
		{
			foreach (var opt in FtpInfo.Options)
			{
				if (opt.Name == name)
				{
					Selected = opt;
					break; // TODO: might not be correct. Was : Exit For
				}
			}
		}

		public bool Matches(string what)
		{
			return Name.IndexOf(what, StringComparison.OrdinalIgnoreCase) != -1;
		}

		public string GetKey(Names key)
		{
			var retval = GetValNow(key);
			var val = retval;

			// dont show a textbox for FTP user / password if the ftp is null
			var ftpFor = key == Names.FtpUsername | key == Names.FtpPassword ? " for " + FtpInfo.Selected.FtpFolder : string.Empty;
			val = Interaction.InputBox(key.ToString() + ftpFor, "App Settings", val);

			if (val != retval & string.IsNullOrEmpty(val) == false)
			{
				retval = val;
			}

			return retval;
		}

		#endregion

		#region "Instance Methods"

		public override bool Equals(object obj)
		{
			if (obj == null || obj.Equals(DBNull.Value)) return false;
			return Name.Equals(((FtpInfo)obj).Name);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}

		public string ToLine()
		{
			// Default=c:\\web|ftp://ftp.website.com/www/|user|
			return string.Format("{0}={1}|{2}|{3}|{4}", Name, LocalFolder, FtpFolder, Username, IOHelper.Encode(Password));
		}

		public override string ToString()
		{
			return string.Format("{0} ({1} on {2} @ {3})", Name, Username, FtpFolder, LocalFolder);
		}

		private static List<FtpInfo> Clone(List<FtpInfo> list)
		{
            var r = new List<FtpInfo>();
            foreach (var item in list)
                r.Add((FtpInfo)item.MemberwiseClone());
            return r;
		}

		private string GetValNow(Names name)
		{
			switch (name)
			{
				case Names.FtpFolder:
					return this.FtpFolder;
				case Names.FtpPassword:
					return this.Password;
				case Names.FtpUsername:
					return this.Username;
				case Names.LocalFolder:
					return this.LocalFolder;
				default:
					throw new NotSupportedException();
			}
		}

		#endregion
	}
}