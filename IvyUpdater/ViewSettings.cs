using System.Windows.Forms;

namespace Cselian.IvyUpdater
{
	public partial class ViewSettings : Form
	{
		UpdateSettings Model;

		public ViewSettings()
		{
			InitializeComponent();

			Model = StoreHelper.Read<UpdateSettings>();
			Text += Model.ProgramName;
			Icon = Properties.Resources.updater;
			SetReadonly();
			SetEditable();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			ReadEditable();
			StoreHelper.Save(Model);
		}

		private void SetReadonly()
		{
			new UIBinder(true)
				.Bind(txtProgram, Model.ProgramName)
				.Bind(txtUrl, Model.Url)
				.Bind(txtSupport, Model.Support)
				.Bind(txtNext, Model.NextUpdateAt)
				.Bind(txtLast, Model.LastUpdateAt)
				.Bind(txtLastCheck, Model.LastCheckedAt)
				.Bind(txtLastRemind, Model.LastRemindedAt)
				;
		}

		private void SetEditable()
		{
			var b = new UIBinder(false)
				.Bind(cboFrequency, Model.Frequency)
				.Bind(chkNever, Model.NeverCheck)
				.Bind(cboRemind, Model.RemindAfter.HasValue ? Model.RemindAfter.Value.Unit : default(DayUnit))
				.Bind(txtRemind, (Model.RemindAfter.HasValue ? Model.RemindAfter.Value.Value : 0).ToString());
		}

		private UIBinder ReadEditable()
		{
			Model.Frequency = UIBinder.Read<UpdateFrequency>(cboFrequency);
			Model.NeverCheck = UIBinder.Read(chkNever);
			var binder = new UIBinder(false);
			//var i = binder.ReadInt(txtRemind, Model.)
			//Model.RemindAfter = 
			return binder;
		}
	}
}
