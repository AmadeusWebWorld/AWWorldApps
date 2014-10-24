using System.Collections.Generic;
using System.Windows.Forms;

namespace Cselian.Utilities.WinXT
{
	/// <summary>
	/// 
	/// </summary>
	public class Searcher
	{
		private readonly DirItem Root;

		public Searcher(DirItem root)
		{
			Root = root;
		}

		public List<DirItem> Results { get; private set; }

		public bool HasResults 
		{
			get { return Results != null && Results.Count > 0; } 
		}

		public void Find(string text, bool onlyText)
		{
			Results = new List<DirItem>();
			var c = new Criteria(text, onlyText);
			AddMatching(Root.Children, c, 1, string.Empty);
		}

		public void SetIn(DataGridView dgv)
		{
			dgv.AutoGenerateColumns = true;
			dgv.DataSource = Results;
			dgv.Columns.Remove("Dir");
			dgv.Columns.Remove("HasChildren");
			dgv.Columns.Remove("IndexSubfolders");
		}

		private void AddMatching(List<DirItem> list, Criteria c, int level, string locn)
		{
			foreach (var item in list)
			{
				if (c.Matches(item))
				{
					item.Level = level;
					item.Location = locn;
					Results.Add(item);
				}

				if (item.HasChildren)
				{
					AddMatching(item.Children, c, level + 1, locn + (locn.Length > 0 ? @" \ " : string.Empty) + item.Text);
				}
			}
		}

		public struct Criteria
		{
			private readonly string Text;
			private readonly bool OnlyText;

			public Criteria(string text, bool onlyText)
				: this()
			{
				Text = text;
				OnlyText = onlyText;
			}

			public bool Matches(DirItem itm)
			{
				return itm.Text.IndexOf(Text, System.StringComparison.OrdinalIgnoreCase) != -1
					|| (OnlyText != true && string.IsNullOrEmpty(itm.Path) == false && itm.Path.IndexOf(Text, System.StringComparison.OrdinalIgnoreCase) != -1);
			}
		}
	}
}
