using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AmadeusWeb.Updater
{
	/// <summary>
	/// Binds / Unbinds stuff
	/// </summary>
	public class UIBinder
	{
		private readonly bool IsReadonly;

		public UIBinder(bool isReadonly)
		{
			IsReadonly = isReadonly;
		}

		public List<Tuple<Control, string>> Errors { get; set; }

		#region Read (Static)

		public static bool Read(CheckBox chk)
		{
			return chk.Checked;
		}

		public static T Read<T>(ComboBox cbo)
		{
			return (T)cbo.SelectedItem;
		}

		#endregion

		#region Bind

		public UIBinder Bind(CheckBox chk, bool val)
		{
			chk.Checked = val;
			if (IsReadonly)
			{
				chk.Enabled = false;
			}
			
			return this;
		}

		public UIBinder Bind<T>(ComboBox cbo, T val)
		{
			cbo.DropDownStyle = ComboBoxStyle.DropDownList;
			cbo.DataSource = Enum.GetValues(typeof(T));
			cbo.SelectedItem = val;
			if (IsReadonly)
			{
				cbo.Enabled = false;
			}

			return this;
		}

		public UIBinder Bind(TextBox txt, string val)
		{
			txt.Text = val;
			Readonly(txt);

			return this;
		}

		public UIBinder Bind(TextBox txt, DateTime? val)
		{
			if (val.HasValue)
			{
				txt.Text = val.Value.ToString("dd MMM yyyy");
			}

			Readonly(txt);
			return this;
		}

		#endregion

		#region Read (can have Errors)

		public int ReadInt(TextBox txt, int deflt)
		{
			var i = 0;
			if (txt.Text.Length == 0 || int.TryParse(txt.Text, out i))
			{
				return i;
			}
			else
			{
				AddError(txt, "Not a valid Integer");
				return deflt;
			}
		}

		#endregion

		private void Readonly(TextBox txt)
		{
			if (IsReadonly)
			{
				txt.ReadOnly = true;
				txt.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void AddError(Control c, string message)
		{
			if (Errors == null)
			{
				Errors = new List<Tuple<Control, string>>();
			}

			Errors.Add(new Tuple<Control, string>(c, message));
		}
	}
}
