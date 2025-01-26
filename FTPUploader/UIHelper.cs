using System.Windows.Forms;

namespace AmadeusWeb.SmartSiteUploader
{
	/// <summary>
	/// Helps with Winforms controls
	/// </summary>
	public static class UIHelper
	{
		public static string RelativeToLocalFolder(string txt)
		{
			return txt.Substring(FtpInfo.Selected.LocalFolder.Length);
		}

		public static string FilePath(ListViewItem itm)
		{
			return (string)itm.Tag;
		}

		public static int SumColumnWidths(DataGridView dgv)
		{
            var width = 0;
            foreach (DataGridViewColumn item in dgv.Columns)
                width += item.Width;
			return width;
		}
	}
}
