using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Cselian.Core;
using Microsoft.Win32;

namespace AmadeusWeb.WinXT
{
	public partial class TweakUI : Form
	{
		private DataGridViewButtonColumn ActionCol;
		private int LastRow = -1;

		public TweakUI()
		{
			InitializeComponent();

			dgvOptions.AutoGenerateColumns = false;
			dgvOptions.DataSource = BuildList();

			dgvOptions.AddBoundColumn<DataGridViewTextBoxColumn>("Name");
			ActionCol = dgvOptions.AddBoundColumn<DataGridViewButtonColumn>("Action", true);
			dgvOptions.Rows[0].Cells[0].Selected = true;
			SetRow();
		}

		private void dgvOptions_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == ActionCol.Index)
			{
				var itm = GetSelected();
				itm.Item1.DoAction();
				dgvOptions.InvalidateRow(itm.Item2);
				txtMsg.Text = itm.Item1.Message;
			}
			else if (e.RowIndex != LastRow)
			{
				SetRow();
			}
		}

		private void SetRow()
		{
			var itm = GetSelected();
			txtMsg.Text = itm.Item1.Message;
			txtMore.Text = itm.Item1.MoreInfo;
			LastRow = itm.Item2;
		}

		private Tuple<Item, int> GetSelected()
		{
			var ix = dgvOptions.SelectedCells[0].RowIndex;
			var item = (Item)dgvOptions.Rows[ix].DataBoundItem;
			return new Tuple<Item, int>(item, ix);
		}

		private List<Item> BuildList()
		{
			var list = new List<Item>
			{
				new Win7ExplorerNwkRemoval(),
			};

			return list;
		}

		#region Item Classes

		public class Win7ExplorerNwkRemoval : RegistryItem
		{
			private int On = -1341915036; //b0040064 / -1341915036
			private int Off = -1332477852; //b0940064 / -1332477852

			public Win7ExplorerNwkRemoval() :
				base(@"HKEY_CLASSES_ROOT\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\ShellFolder\Attributes", RegistryValueKind.DWord)
			{
				Name = "Win7 Explorer Network Removal";
				MoreInfo = "http://www.askvg.com/how-to-remove-network-from-windows-7-explorers-navigation-pane/";
			}

			public override void DoAction()
			{
				var turnOn = ToBeTurnedOn();
				Message = "Set " + (turnOn ? "b0040064" : "b0940064");
				SetValue(turnOn ? On : Off);
				Turn(!turnOn);
			}

			protected override void OnInit()
			{
				var val = (int)GetValue();
				Turn(val == Off);
			}
		}

		public abstract class RegistryItem : Item
		{
			protected readonly string KeyName;
			private readonly RegistryKey Key;
			private readonly RegistryValueKind Kind;

			public RegistryItem(string key, RegistryValueKind kind)
			{
				Kind = kind;
				var fol = Path.GetDirectoryName(key);
				KeyName = Path.GetFileName(key);
				if (fol.StartsWith(@"HKEY_CLASSES_ROOT\"))
				{
					fol = fol.Substring(@"HKEY_CLASSES_ROOT\".Length);
					Key = Registry.ClassesRoot.OpenSubKey(fol, true);
				}
				else
				{
					throw new System.NotSupportedException();
				}
				
				OnInit();
			}

			protected void SetValue(object value)
			{
				Key.SetValue(KeyName, value, Kind);
			}

			protected object GetValue()
			{
				return Key.GetValue(KeyName, Kind);
			}
		}

		public abstract class Item
		{
			public string Name { get; protected set; }

			public string Action { get; protected set; }

			public string Message { get; protected set; }

			public string MoreInfo { get; protected set; }

			public abstract void DoAction();

			protected abstract void OnInit();

			protected bool ToBeTurnedOn()
			{
				return Action == "Turn On";
			}

			protected void Turn(bool on)
			{
				Action = on ? "Turn On" : "Turn Off";
			}
		}
		
		#endregion
	}
}
