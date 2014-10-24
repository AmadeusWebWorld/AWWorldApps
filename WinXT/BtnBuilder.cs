using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cselian.Utilities.WinXT
{
	/// <summary>
	/// Adds Buttons (or Labels) per Folder in the given Parent
	/// </summary>
	public class BtnBuilder
	{
		private readonly Control Pane;
		private readonly ToolTip Tip;
		private readonly MenuBuilder Menu;
		private int line, top, left;

		public BtnBuilder(Control parent, ToolTip tip, MenuBuilder menu)
		{
			Pane = parent;
			Tip = tip;
			Menu = menu;
		}

		public void Build()
		{
			Pane.Controls.Clear();
			if (Menu.RootFolder.HasChildren)
			{
				AddChildren(0, Menu.RootFolder.Children);
			}
			else
			{
				Pane.Controls.Add(new Label { Text = "NO Folders Configured yet" });
			}
		}

		private void AddChildren(int level, List<DirItem> list)
		{
			left = level * 40;
			var childless = WithChildren(list, false);
			var rowLeft = left;
			foreach (var item in childless)
			{
				var ctl = GetControl(item);
				ctl.Location = new System.Drawing.Point(rowLeft, top);
				Pane.Controls.Add(ctl);
				rowLeft += ctl.Width + 4;
			}

			if (childless.Length > 0)
			{
				AddLine();
			}

			var childful = WithChildren(list, true);
			foreach (var item in childful)
			{
				left = level * 40;
				var ctl = GetControl(item);
				ctl.Location = new System.Drawing.Point(left, top);
				Pane.Controls.Add(ctl);
				AddLine();

				if (item.HasChildren)
				{
					AddChildren(level + 1, item.Children);
				}
			}
		}

		private void AddLine()
		{
			line += 1;
			top += 25;
		}

		private DirItem[] WithChildren(List<DirItem> list, bool yes)
		{
			return list.Where(x => x.HasChildren == yes).ToArray();
		}

		private Control GetControl(DirItem item)
		{
			if (string.IsNullOrEmpty(item.Path))
			{
				return new Label
				{
					AutoSize = true,
					Text = item.Text
				};
			}

			var btn = new Button
			{
				AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
				AutoSize = true,
				Text = item.Text,
				Tag = item,
			};

			Tip.SetToolTip(btn, item.Path);
			btn.Click += new System.EventHandler(btn_Click);
			return btn;
		}

		private void btn_Click(object sender, System.EventArgs e)
		{
			var btn = (Button)sender;
			var item = (DirItem)btn.Tag;
			Menu.OpenFolder(item);
		}
	}
}
