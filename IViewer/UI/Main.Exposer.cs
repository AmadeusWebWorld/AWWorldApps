using WMPLib;
using System.Linq;
using System.Windows.Forms;

namespace Cselian.IViewer.UI
{
	/// <summary>
	/// 
	/// </summary>
	partial class Main : IInst, IMenu
	{
		public static IInst Inst { get; private set; }
		public static IMenu Menu { get; private set; }

		private Main(bool expose)
		{
			Inst = this;
			Menu = this;
		}

		#region Inst

		IWMPControls IInst.PlrControls
		{
			get { return Player.Ctlcontrols; }
		}

		ListView IInst.Filelist
		{
			get { return fils; }
		}

		ListView IInst.Playlist
		{
			get { return playlist; }
		}

		TreeView IInst.Fols
		{
			get { return fols; }
		}

		#endregion

		#region Menu

		ToolStripMenuItem[] IMenu.AllItems
		{
			get { return VidMenu.Items.Cast<ToolStripMenuItem>().ToArray(); }
		}

		MenuStrip IMenu.VidMenu
		{
			get { return VidMenu; }
		}

		ToolStripMenuItem IMenu.File
		{
			get { return MnuFile; }
		}

		ToolStripMenuItem IMenu.PlsNew
		{
			get { return PlsNewMnu; }
		}

		ToolStripMenuItem IMenu.PlsOpen
		{
			get { return PlsOpenMnu; }
		}

		ToolStripMenuItem IMenu.PlsSave
		{
			get { return PlsSaveMnu; }
		}

		ToolStripMenuItem IMenu.PlsSaveAs
		{
			get { return PlsSaveAsMnu; }
		}

		ToolStripMenuItem IMenu.FileExit
		{
			get { return FileExitMnu; }
		}

		ToolStripMenuItem IMenu.PlsFix
		{
			get { return PlsFixMnu; }
		}

		ToolStripMenuItem IMenu.PlsOpenFolder
		{
			get { return PlsOpenFolderMnu; }
		}

		ToolStripMenuItem IMenu.PlsRefresh
		{
			get { return PlsRefreshMnu; }
		}

		ToolStripSeparator IMenu.SepFile2
		{
			get { return SepFile2; }
		}

		#endregion
	}

	public interface IInst
	{
		IWMPControls PlrControls { get; }
		ListView Filelist { get; }
		ListView Playlist { get; }
		TreeView Fols { get; }
	}

	public interface IMenu
	{
		ToolStripMenuItem[] AllItems { get; }
		MenuStrip VidMenu { get; }
		ToolStripMenuItem File { get; }
		ToolStripMenuItem PlsNew { get; }
		ToolStripMenuItem PlsOpen { get; }
		ToolStripMenuItem PlsSave { get; }
		ToolStripMenuItem PlsSaveAs { get; }
		ToolStripMenuItem FileExit { get; }
		ToolStripMenuItem PlsFix { get; }
		ToolStripMenuItem PlsOpenFolder { get; }
		ToolStripMenuItem PlsRefresh { get; }
		ToolStripSeparator SepFile2 { get; }
	}
}
