using System;
using System.Windows.Forms;

namespace Cselian.ScheduleCatcher
{
	public partial class Test : Form
	{
		public Test()
		{
			InitializeComponent();
			picImage.ImageLocation = "nothing.png";
			var img = System.Drawing.Image.FromFile(picImage.ImageLocation).Size;
			Width = img.Width + Width - picImage.Width;
			Height = img.Height + Height - picImage.Height;
		}

		private void btnSelected_Click(object sender, EventArgs e)
		{
			var isStandard = btnSelected.FlatStyle == FlatStyle.Standard;
			btnSelected.FlatStyle = isStandard ? FlatStyle.Flat : FlatStyle.Standard;
			picImage.ImageLocation = isStandard ? "something.png" : "nothing.png";
		}

		private void picImage_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Mouse Clicked");
		}
	}
}
