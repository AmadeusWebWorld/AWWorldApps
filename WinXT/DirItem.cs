using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Cselian.Utilities.WinXT
{
	/// <summary>
	/// The Folder shortcut saved (with children)
	/// </summary>
	public class DirItem
	{
		public DirItem()
		{
		}

		public DirItem(string dir) : this(new DirectoryInfo(dir))
		{
		}

		public DirItem(DirectoryInfo di)
		{
			Text = di.Name;
			Path = di.FullName;
		}

		#region Properties

		// Common
		[XmlAttribute]
		public string Text { get; set; }

		[XmlAttribute]
		public string Path { get; set; }

		[XmlIgnore]
		public string Location { get; set; }

		[XmlIgnore]
		public int Level { get; set; }

		[XmlIgnore]
		public DirectoryInfo Dir { get; set; }

		public List<DirItem> Children { get; set; }

		[XmlAttribute("fave")]
		public bool IsFavorite { get; set; }

		[XmlAttribute("root")]
		public bool OpenAsRoot { get; set; }

		[XmlAttribute("subfol")]
		public bool IndexSubfolders { get; set; }

		public bool HasChildren
		{
			get { return Children != null && Children.Count > 0; }
		}

		#endregion

		#region Methods

		public void AddChild(DirItem c)
		{
			(Children ?? (Children = new List<DirItem>())).Add(c);
		}

		public bool ShouldSerializePath()
		{
			return string.IsNullOrEmpty(Path) == false;
		}

		public bool ShouldSerializeIsFavorite()
		{
			return IsFavorite;
		}

		public bool ShouldSerializeOpenAsRoot()
		{
			return OpenAsRoot;
		}

		public bool ShouldSerializeIndexSubfolders()
		{
			return IndexSubfolders;
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
			if (string.IsNullOrEmpty(Text))
				return Path;
			else if (string.IsNullOrEmpty(Path))
				return Text;

			return string.Concat(Text, " (", Path, ")");
		}

		#endregion
	}
}
