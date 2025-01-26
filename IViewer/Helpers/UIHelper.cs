using System.Windows.Forms;

namespace AmadeusWeb.IViewer
{
	/// <summary>
	/// 
	/// </summary>
	public static class UIHelper
	{
		public static void AlignToRight(this Control ctl)
		{
			ctl.Left = ctl.Parent.Width - ctl.Width - 10;
		}

		/// <summary>
		/// Set Text (if nothing, will turn invisible) and then align to right
		/// </summary>
		public static void SetAndAlign(this Label lbl, string str = null)
		{
			if (str == null)
			{
				lbl.Visible = false;
				return;
			}

			lbl.Visible = true;
			lbl.Text = str;
			AlignToRight(lbl);
		}

		public static void PopupAtPointer(this ToolStripMenuItem mnu)
		{
			mnu.DropDown.OwnerItem = null;
			mnu.DropDown.Show(Control.MousePosition);
		}
	}
}
