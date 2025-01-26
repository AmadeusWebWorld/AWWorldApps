using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AmadeusWeb.Updater
{
	/// <summary>
	/// 
	/// </summary>
	public static class HttpHelper
	{
		/// <summary>
		/// Saves a Url to the given location
		/// </summary>
		/// <param name="url">The URL to save from</param>
		/// <param name="file">The file to save to</param>
		/// <returns>False if an error occurs</returns>
		public static bool SaveTo(string url, string file)
		{
			try
			{
				var content = MakeWebRequest(url);
				File.WriteAllText(file, content);
				return true;
			}
			catch (Exception ex)
			{
				var msg = string.Format("Exception occurred when saving {1} viz:{0}{2}", Environment.NewLine, url, ex.ToString());
				Program.LogMessage(msg, MessageBoxIcon.Error);
				return false;
			}
		}

		private static string MakeWebRequest(string url = null)
		{
			//if (url == null) url = Interaction.InputBox("Enter the url to make the request", "Web Request", "http://mini.cselian.com/js/fckeditor/editor/filemanager/browser/default/connectors/php/connector.php?Command=GetFoldersAndFiles&Type=Image&CurrentFolder=%2F");
			var req = HttpWebRequest.Create(url);
			var res = new StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd();
			return res;
		}
	}
}
