using System.Windows.Forms;

namespace Cselian.Core
{
	/// <summary>
	/// 
	/// </summary>
	public static class FormsHelper
	{
		public static void DragMovesForm(this Control ctl, System.Action dragCompleted = null)
		{
			new Mover(ctl, dragCompleted);
		}

		public static T AddBoundColumn<T>(this DataGridView dgv, string name, bool bind = true)
			where T : DataGridViewColumn, new()
		{
			var col = new T
			{
				Name = name,
				HeaderText = name,
			};

			if (bind) col.DataPropertyName = name;

			dgv.Columns.Add(col);
			return col;
		}

		public static bool SelectedIsNotRootOrEmpty(this TreeView tvw)
		{
			var sel = tvw.SelectedNode;
			return sel != null && sel != tvw.Nodes[0];
		}

		public static void RemoveSelectedIfNotRoot(this TreeView tvw)
		{
			if (tvw.SelectedIsNotRootOrEmpty())
			{
				var sel = tvw.SelectedNode;
				var par = sel.Parent;
				par.Nodes.Remove(sel);
				tvw.SelectedNode = par;
			}
		}

		public static void PopupAtPointer(this ToolStripMenuItem mnu)
		{
			mnu.DropDown.OwnerItem = null;
			mnu.DropDown.Show(Control.MousePosition);
		}

		public static void SetDrawMode(this TabControl tabs)
		{
			tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
			tabs.SizeMode = TabSizeMode.Fixed;
			tabs.DrawItem += new DrawItemEventHandler(tabs_DrawItem);
		}

		private static void tabs_DrawItem(object sender, DrawItemEventArgs e)
		{
			var tabs = (TabControl)sender;
			var page = tabs.TabPages[e.Index];

			var paddedBounds = e.Bounds;
			int offsetY = (e.State == DrawItemState.Selected) ? -2 : 1;
			paddedBounds.Offset(1, offsetY);
			TextRenderer.DrawText(e.Graphics, page.Text, tabs.Font, paddedBounds, page.ForeColor);
		}

		private class Mover
		{
			private readonly Form Owner;
			private readonly System.Action dragCompleted;
			private bool mouseDown;
			private System.Drawing.Point startedAt;

			public Mover(Control movedBy, System.Action callback)
			{
				Owner = movedBy.FindForm();
				dragCompleted = callback;

				movedBy.MouseDown += movedBy_MouseDown;
				movedBy.MouseMove += movedBy_MouseMove;
				movedBy.MouseUp += movedBy_MouseUp;
			}

			private void movedBy_MouseDown(object sender, MouseEventArgs e)
			{
				mouseDown = true;
				startedAt = e.Location;
			}

			private void movedBy_MouseUp(object sender, MouseEventArgs e)
			{
				mouseDown = false;
				if (null != dragCompleted)
				{
					dragCompleted();
				}
			}

			private void movedBy_MouseMove(object sender, MouseEventArgs e)
			{
				if (mouseDown)
				{
					var loc = Owner.PointToScreen(e.Location);
					Owner.Left = loc.X - startedAt.X;
					Owner.Top = loc.Y - startedAt.Y;
				}
			}
		}
	}
}
