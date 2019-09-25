using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cselian.IViewer
{
	/// <summary>
	/// Represents the context used to show files
	/// Used to track history and to refine searches
	/// </summary>
	public class ListContext
	{
		public ListContext()
		{
		}

		public ListContext(Types t)
		{
			Type = t;
			Children = new List<ListContext>();
		}

		public enum Types
		{
			All,
			Folder,
			Search,
			Flat,
			Group
		}

		#region Properties

		// Common
		[XmlIgnore]
		public LibItem[] List { get; set; }

		[XmlAttribute]
		public Types Type { get; set; }

		[XmlAttribute]
		public string Text { get; set; }

		public List<ListContext> Children { get; set; }

		// Folder / Flat
		[XmlAttribute]
		public string Folder { get; set; }

		[XmlAttribute]
		public string SubFilter { get; set; }

		// For Search
		[XmlAttribute]
		public string SearchText { get; set; }

		[XmlAttribute]
		public SearchMode SearchMode { get; set; }

		public ExtensionFilter Filter { get; set; }

		#endregion

		#region Methods

		public bool ReplaceLast(List<ListContext> history)
		{
			if (history.Count == 0) return false;
			var last = history[0];
			if (Type != last.Type || Type == Types.All) return false;

			if (Type == Types.Search)
				return SearchMode == last.SearchMode && SearchText.StartsWith(last.SearchText);
			else 
				return Folder == last.Folder && SubFilter.StartsWith(last.SubFilter);
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override string ToString()
		{
			if (Text != null) return Text;

			string suffix = null;
			switch (Type)
			{
				case Types.Folder:
				case Types.Flat:
					suffix = " on " + Folder;
					if (!string.IsNullOrEmpty(SubFilter)) suffix += " with " + SubFilter;
					break;
				case Types.Search:
					suffix = " for " + SearchText + " matching " + SearchMode;
					break;
			}

			var size = List != null ? " - " + List.Length : string.Empty;
			Text = Type + suffix + size;
			return Text;
		}

		#endregion
	}
}
