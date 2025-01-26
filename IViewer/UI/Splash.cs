using System;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
			Load += new EventHandler(Splash_Load);
			KeyDown += new KeyEventHandler(Splash_KeyDown);
			MouseDown += new MouseEventHandler(Splash_MouseDown);
		}

		public string SplashLabel
		{
			get
			{
				return lblMsg.Text;
			}

			set
			{
				lblMsg.Text = value;
				Application.DoEvents();
			}
		}

		private void Splash_Load(object sender, EventArgs e)
		{
			var v = typeof(AppSettings).Assembly.GetName().Version;
			BackgroundImage = Properties.Resources.splash;
			lblMsg.Text = string.Format(lblMsg.Text, DateTime.Today.Year);

			var uv = UpdateManager.GetVersion();
			lblVersion.Text = string.Format("version: {0}.{1} build: {2} of {3}", v.Major, v.Minor, uv.Version, uv.Date.ToString("dd MMM yyyy"));
		}

		private void Splash_MouseDown(object sender, MouseEventArgs e)
		{
			Close();
		}

		private void Splash_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void link_Click(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Clipboard.SetText((sender as LinkLabel).Text);
			MessageBox.Show("Copied to clipboard", "IViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
