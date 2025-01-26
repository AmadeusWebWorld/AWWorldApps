using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AmadeusWeb.IViewer.UI
{
	public partial class UserInput : Form
	{
		public UserInput(string[] options, string[] selected, bool multiple, string purpose)
		{
			InitializeComponent();

			Text = "Select a Favorite to " + purpose;
			lstItems.Items.AddRange(options);
			if (multiple)
			{
				lstItems.SelectionMode = SelectionMode.MultiExtended;
			}

			if (selected != null)
			{
				foreach (var sel in selected)
				{
					lstItems.SelectedItems.Add(sel);
				}
			}
		}

		public object SelectedItem
		{
			get { return lstItems.SelectedItem; }
		}

		public string[] SelectedItems
		{
			get
			{
				var items = new List<string>();
				foreach (string itm in lstItems.SelectedItems)
				{
					items.Add(itm);
				}

				return items.ToArray();
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
