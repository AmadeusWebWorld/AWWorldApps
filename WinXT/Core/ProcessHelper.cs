using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cselian.Core
{
	/// <summary>
	/// Handles Closing of Open Forms on ProcessExit and check for existing process
	/// </summary>
	public class ProcessHelper
	{
		private static List<Form> Forms = new List<Form>();

		static ProcessHelper()
		{
			// http://stackoverflow.com/questions/11291352/shutdown-event-for-console-application-c-sharp
			AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
		}

		public static T Register<T>(T frm) where T : Form
		{
			Forms.Add(frm);
			frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
			return frm;
		}

		public static bool IsAnotherProcessRunning()
		{
			return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;
		}

		public static bool IsAnotherProcessRunningDepr(bool focusOther = true)
		{
			var cur = Process.GetCurrentProcess();
			var other = Process.GetProcessesByName(cur.ProcessName).FirstOrDefault(x => x.Id != cur.Id);
			if (other != null && focusOther)
			{
				SetForegroundWindow(other.MainWindowHandle);
			}

			return other != null;
		}

		public static void Shutdown()
		{
			/*
			var ui = new IViewer.UI.UserInput(new[] { "sleep", "shutdown" }, new[] { "sleep" }, false, "sleep");
			ui.ShowDialog();
			if (ui.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				var standby = ui.SelectedItem == "sleep";

				// http://www.c-sharpcorner.com/UploadFile/thiagu304/desktopfunctions02112007140806PM/desktopfunctions.aspx
				if (standby)
					Application.SetSuspendState(PowerState.Suspend, true, true);
				else
					ExitWindowsEx(1, 0);
			}
			*/
		}

		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(System.IntPtr handle);

		[DllImport("user32.dll")]
		private static extern int ExitWindowsEx(int uFlags, int dwReason);

		private static void frm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Forms.Remove((Form)sender);
		}

		private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
			foreach (var frm in Forms)
			{
				frm.Close();
			}
		}
	}
}
