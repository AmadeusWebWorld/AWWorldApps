using System;
using System.Drawing;
using System.Globalization;

namespace Cselian.Core.Data
{
	/// <summary>
	/// Extension methods for Converting a Color to Hex etc
	/// </summary>
	public static class ColorExtensions
	{
		public static string ToHex(this Color col)
		{
			return ToHex(col.R, col.G, col.B);
		}

		public static string ToHex(byte r, byte g, byte b)
		{
			return string.Concat("#", r.ToString("X2"), g.ToString("X2"), b.ToString("X2"));
		}

		public static int ToHexInt(this Color col)
		{
			var val = Convert.ToInt32(col.R);
			val += Convert.ToInt32(col.G) * 256;
			val += Convert.ToInt32(col.B) * 256 * 256;
			return val;
		}

		public static Color FromByte(byte r, byte g, byte b)
		{
			return Color.FromArgb(
				Convert.ToInt32(r),
				Convert.ToInt32(g),
				Convert.ToInt32(b));
		}

		public static T FromRgb<T>(this Color col, Func<byte, byte, byte, T> func)
		{
			return func(col.R, col.G, col.B);
		}

		public static Color FromHex(string hex)
		{
			if (hex == null || (hex.Length != 7 && hex.Length != 4) || hex.StartsWith("#") == false)
			{
				throw new ArgumentException("Must use a hex number like #cdcdcd or #666");
			}

			var rgb = new int[3];
			if (hex.Length == 4)
			{
				rgb[0] = HexToInt(hex.Substring(1, 1));
				rgb[1] = HexToInt(hex.Substring(2, 1));
				rgb[2] = HexToInt(hex.Substring(3, 1));
			}
			else
			{
				rgb[0] = HexToInt(hex.Substring(1, 2));
				rgb[1] = HexToInt(hex.Substring(3, 2));
				rgb[2] = HexToInt(hex.Substring(5, 2));
			}

			return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
		}

		private static int HexToInt(string hex)
		{
			return int.Parse(hex, NumberStyles.HexNumber);
		}
	}
}
