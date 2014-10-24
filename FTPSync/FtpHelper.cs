using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cselian.FTPSync
{
	public class FtpHelper
	{
		public static readonly NetworkCredential Credentials = new NetworkCredential { Domain = string.Empty };

		private const string DIRECTORYNOTEXISTSERROR = "The remote server returned an error: (553) File name not allowed."; //The remote server returned an error: (550) File unavailable (e.g., file not found, no access).";

		public static TextBox Log { get; set; }

		public static FtpWebRequest CreateFTPReq(string uri, string method)
		{
			//// Create FtpWebRequest object from the Uri provided
			var res = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));

			//// Provide the WebPermission Credentials
			res.Credentials = Credentials;

			//// By default KeepAlive is true, where the control connection is not closed after a command is executed.
			res.KeepAlive = false;

			if (method != null)
			{
				res.Method = method;
			}

			return res;
		}

		public static string SyncFTP(string relPath, bool delete = false)
		{
			string result = "No Action on file: " + relPath;

			var fileInf = new FileInfo(FtpInfo.Selected.LocalFolder + relPath);
			string uri = FtpInfo.Selected.FtpFolder + relPath.Replace("\\", "/");
		tryagain:

			FtpWebRequest reqFTP = null;

			if (delete)
			{
				reqFTP = CreateFTPReq(uri, WebRequestMethods.Ftp.DeleteFile);
				try
				{
					var response = (FtpWebResponse)reqFTP.GetResponse();
					result = "Delete Status: " + response.StatusDescription.Replace(Environment.NewLine, string.Empty);
					response.Close();
				}
				catch (Exception ex)
				{
					result = ShowError(ex, "Delete Error");
				}
			}
			else
			{
				//// Specify the command to be executed.
				reqFTP = CreateFTPReq(uri, WebRequestMethods.Ftp.UploadFile);

				//// Specify the data transfer type.
				reqFTP.UseBinary = true;

				//// Notify the server about the size of the uploaded file
				reqFTP.ContentLength = fileInf.Length;

				//// The buffer size is set to 2kb
				int buffLength = 2048;
				byte[] buff = new byte[buffLength + 1];
				int contentLen = 0;

				try
				{
					//// Opens a file stream (System.IO.FileStream) to read the file to be uploaded
					using (FileStream fs = fileInf.OpenRead())
					{
						//// Stream to which the file to be upload is written
						var strm = reqFTP.GetRequestStream();

						//// Read from the file stream 2kb at a time
						contentLen = fs.Read(buff, 0, buffLength);

						//// Till Stream content ends
						while (contentLen != 0)
						{
							//// Write Content from the file stream to the FTP Upload Stream
							strm.Write(buff, 0, contentLen);
							contentLen = fs.Read(buff, 0, buffLength);
							Application.DoEvents();
						}

						//// Close the file stream and the Request Stream
						strm.Close();
						fs.Close();
					}

					result = "Upload OK";
				}
				catch (Exception ex)
				{
					if (ex.Message == DIRECTORYNOTEXISTSERROR)
					{
						string fol = uri.Substring(0, uri.LastIndexOf("/"));
						CreateFTPFol(fol);
						SetMessage("Create Folder:" + fol);
						goto tryagain;
					}
					else
					{
						result = ShowError(ex, "Upload Error");
					}
				}
			}

			return result;
		}

		private static string ShowError(Exception ex, string where)
		{
			System.Media.SystemSounds.Hand.Play();
			MessageBox.Show(ex.Message, where);
			return where + " - " + ex.ToString();
		}

		public static string MakeWebRequest(string url = null, string writeTo = "Response.txt")
		{
			if (url == null)
				url = Interaction.InputBox("Enter the url to make the request", "Web Request", "http://mini.cselian.com/js/fckeditor/editor/filemanager/browser/default/connectors/php/connector.php?Command=GetFoldersAndFiles&Type=Image&CurrentFolder=%2F");
			var req = HttpWebRequest.Create(url);
			var res = new StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd();
			if (Program.SilentMode)
				return res;
			if (writeTo != null)
			{
				File.WriteAllText(writeTo, res);
				MessageBox.Show("Response written to : " + new FileInfo(writeTo).FullName);
			}
			return res;
		}

		public static void SetMessage(string msg, ListViewItem item = null, string forWho = null)
		{
			msg = string.Format("{0} - {1}", DateTime.Now.ToString("HH:mm:ss"), msg);
			if (item != null) UpdateItem(msg, item);

			if (forWho != null) msg += " for " + forWho;
			Log.AppendText(msg + Environment.NewLine);
			File.AppendAllText(FtpInfo.Selected.Name + ".log", DateTime.Now.ToString("dd MMM yyyy ") + msg + Environment.NewLine);
		}

		private static void CreateFTPFol(string fol)
		{
			FtpWebRequest reqFTP = CreateFTPReq(fol, WebRequestMethods.Ftp.MakeDirectory);
			try
			{
				using (FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse())
				{
					response.Close();
				}
			}
			catch (Exception ex)
			{
				if (ex.Message == DIRECTORYNOTEXISTSERROR)
				{
					CreateFTPFol(fol.Substring(0, fol.LastIndexOf("/")));
					FtpWebRequest mkdir = CreateFTPReq(fol, WebRequestMethods.Ftp.MakeDirectory);
					using (FtpWebResponse response = (FtpWebResponse)mkdir.GetResponse())
					{
						response.Close();
					}
				}
				else
				{
					SetMessage("Create Folder Error - " + ex.ToString());
				}
			}
		}

		private static void UpdateItem(string msg, ListViewItem item)
		{
			if (item != null)
			{
				if (item.SubItems.Count == 1)
					item.SubItems.Add(msg);
				else
					item.SubItems[1].Text = msg;

				string size = "Not Exists";
				var fileName = (string)item.Tag;
				if (File.Exists(fileName))
				{
					var fil = new FileInfo(fileName);
					double kb = fil.Length;
					size = IOHelper.GetFileSize(fil);
				}

				if (item.SubItems.Count == 2)
					item.SubItems.Add(size);
				else
					item.SubItems[2].Text = size;

				msg = string.Format("{0} - ({1}) - {2}", item.SubItems[1].Text, item.SubItems[0].Text, item.SubItems[2].Text);
			}
		}
	}
}