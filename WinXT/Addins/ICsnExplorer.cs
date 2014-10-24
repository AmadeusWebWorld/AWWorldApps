using System;
using System.IO;

namespace Cselian.Utilities.WinXT.Addins
{
	public interface ICsnExplorer
	{
		event EventHandler<XplFolderSelectEventArgs> FolderSelected;

		event EventHandler<XplFileSelectEventArgs> FileSelected;
	}

	public class XplFolderSelectEventArgs : EventArgs
	{
		public readonly DirectoryInfo Dir;

		public XplFolderSelectEventArgs(DirectoryInfo di)
		{
			Dir = di;
		}
	}

	public class XplFileSelectEventArgs : EventArgs
	{
		public readonly FileInfo File;

		public XplFileSelectEventArgs(FileInfo fi)
		{
			File = fi;
		}
	}
}
