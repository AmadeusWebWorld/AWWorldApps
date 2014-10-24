using System;
using System.IO;
using System.Windows.Forms;

namespace Cselian.Utilities.WinXT.Addins
{
	public partial class ExNViewer : UserControl
	{
		public ExNViewer(Control parent)
		{
			parent.SuspendLayout();

			InitializeComponent();
			ICsnExplorer ex = new Explorer(SplitCtl.Panel1);
			ex.FileSelected += new EventHandler<XplFileSelectEventArgs>(ex_FileSelected);

			parent.Controls.Add(this);
			Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			Width = parent.Width; 
			Height = parent.Height - 40; 
			Top = 40;
			parent.ResumeLayout();
		}

		private void ex_FileSelected(object sender, XplFileSelectEventArgs e)
		{
			TxtCtl.Text = File.ReadAllText(e.File.FullName);
		}
	}
}
