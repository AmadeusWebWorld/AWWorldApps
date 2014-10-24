using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Cselian.Core.Data
{
	/// <summary>
	/// Since Font cannot be serialized.
	/// </summary>
	[Serializable]
	public class FontData
	{
		public FontData(Font font)
		{
			Name = font.Name;
			Size = font.Size;
			Bold = (font.Style & FontStyle.Bold) == FontStyle.Bold;
			Italic = (font.Style & FontStyle.Italic) == FontStyle.Italic;
			Underline = (font.Style & FontStyle.Underline) == FontStyle.Underline;
		}

		public FontData()
		{
		}

		[XmlAttribute]
		public string Name { get; set; }

		[XmlAttribute]
		public float Size { get; set; }

		[XmlAttribute]
		public bool Bold { get; set; }

		[XmlAttribute]
		public bool Italic { get; set; }

		[XmlAttribute]
		public bool Underline { get; set; }

		public Font ToFont()
		{
			var style = default(FontStyle);

			if (Bold)
			{
				style = style | FontStyle.Bold;
			}

			if (Italic)
			{
				style = style | FontStyle.Italic;
			}

			if (Underline)
			{
				style = style | FontStyle.Underline;
			}

			return new Font(Name, Size, style);
		}
	}
}
