using System.Linq;
using System.Windows.Forms;

namespace Cselian.FTPSync
{
	/// <summary>
	/// Helps with Winforms controls
	/// </summary>
	public static class UIHelper
	{
		public static string RelativeToLocalFolder(this string txt)
		{
			return txt.Substring(FtpInfo.Selected.LocalFolder.Length);
		}

		public static string FilePath(this ListViewItem itm)
		{
			return (string)itm.Tag;
		}

		public static int SumColumnWidths(this DataGridView dgv)
		{
			return dgv.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width);
		}
	}
}
