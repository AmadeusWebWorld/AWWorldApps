using System.Windows.Forms;

namespace Cselian.Core
{
	/// <summary>
	/// Handle NotifyIcon and hiding exit unless clicking from Systray etc
	/// </summary>
	public static class NicHelper
	{
		private static Form Form;
		private static ToolStripMenuItem Menu;
		private static bool ExitingApp;
		private static MovablePython.Hotkey HK;
		private static MovablePython.Hotkey HK2;

		public static void RegisterNic(this Form frm, ToolStripMenuItem mnu, NotifyIcon nic)
		{
			Form = frm;
			Menu = mnu;

			var exit = Menu.DropDownItems[Menu.DropDownItems.Count - 1];
			exit.Click += exit_Click;

			nic.Icon = frm.Icon;
			nic.Visible = true;
			nic.MouseDown += nic_MouseDown;
			nic.MouseDoubleClick += nic_MouseDoubleClick;

			var hk = new MovablePython.Hotkey { KeyCode = Keys.W, Windows = true };
			hk.Pressed += new System.ComponentModel.HandledEventHandler(hk_Pressed);
			hk.Register(Form);
			HK = hk;
			hk = new MovablePython.Hotkey { KeyCode = Keys.S, Windows = true };
			hk.Pressed += new System.ComponentModel.HandledEventHandler(hk2_Pressed);
			hk.Register(Form);
			HK2 = hk;

			frm.Resize += frm_Resize;
			frm.FormClosing += frm_FormClosing;
			frm.FormClosed += frm_FormClosed;
		}

		private static void exit_Click(object sender, System.EventArgs e)
		{
			ExitingApp = true;
			Form.Close();
		}

		private static void hk_Pressed(object sender, System.ComponentModel.HandledEventArgs e)
		{
			Form.Show();
			Form.Focus();
		}

		private static void hk2_Pressed(object sender, System.ComponentModel.HandledEventArgs e)
		{
			ProcessHelper.Shutdown();
		}

		private static void frm_FormClosed(object sender, FormClosedEventArgs e)
		{
			HK.Unregister();
		}

		private static void frm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!ExitingApp)
			{
				e.Cancel = true;
				Form.Hide();
			}
		}

		private static void frm_Resize(object sender, System.EventArgs e)
		{
			if (Form.WindowState == FormWindowState.Minimized)
			{
				Form.Hide();
			}
		}

		private static void nic_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Form.Show();
			Form.Activate();
		}

		private static void nic_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Menu.PopupAtPointer();
			}
		}
	}
}
