using System;
using System.Collections.Generic;
using System.Linq;

namespace Cselian.Core
{
	/// <summary>
	/// 
	/// </summary>
	public class Clock
	{
		[System.Xml.Serialization.XmlAttribute]
		public string Name { get; set; }

		[System.Xml.Serialization.XmlIgnore]
		public TimeZoneInfo Zone { get; set; }

		[System.Xml.Serialization.XmlAttribute]
		public string ZoneId
		{
			get { return Zone != null ? Zone.Id : string.Empty; }
			set { Zone = !string.IsNullOrEmpty(value) ? TimeZoneHelper.GetZone(value) : null; }
		}

		[System.Xml.Serialization.XmlIgnore]
		public string Time
		{
			get { return Zone != null ? DateTime.Now.ToUniversalTime().Add(Zone.BaseUtcOffset).Add(TimeZoneHelper.GetDstOffset(Zone)).ToString("HH:mm ddd") + TimeZoneHelper.Offset(Zone) : string.Empty; }
		}

		[System.Xml.Serialization.XmlIgnore]
		public string DST
		{
			get
			{
				return TimeZoneHelper.GetDstInfo(Zone);
			}
		}
	}

	public static class TimeZoneHelper
	{
		public static readonly IList<TimeZoneInfo> Zones = TimeZoneInfo.GetSystemTimeZones();
		private static Dictionary<TimeZoneInfo, DstData> Dst = new Dictionary<TimeZoneInfo, DstData>();
		private static int LastYear;

		static TimeZoneHelper()
		{
			Local = Zones.FirstOrDefault(x => x.BaseUtcOffset == TimeZoneInfo.Local.BaseUtcOffset);
		}

		public static TimeZoneInfo Local { get; private set; }

		public static bool SimplifyInfo { get; set; }

		public static bool ShowRule { get; set; }

		public static TimeZoneInfo GetZone(string id)
		{
			return Zones.FirstOrDefault(x => x.Id == id);
		}

		public static string GetDstInfo(TimeZoneInfo zone)
		{
			if (zone == null) return string.Empty;
			var data = GetDstData(zone);
			return ShowRule ? data.Rule : data.Info;
		}

		public static TimeSpan GetDstOffset(TimeZoneInfo zone)
		{
			var data = GetDstData(zone);
			return data.InDst ? data.Offset : TimeSpan.Zero;
		}

		public static string Offset(TimeZoneInfo zone)
		{
			if (zone == null)
			{
				return string.Empty;
			}

			var dstOffset = GetDstData(zone).Offset;
			var mins = ((zone.BaseUtcOffset.TotalMinutes - Local.BaseUtcOffset.TotalMinutes + dstOffset.TotalMinutes) / 60).ToString();
			if (mins == "0")
			{
				mins = "local";
			}
			else if (!mins.StartsWith("-"))
			{
				mins = "+" + mins;
			}

			return " (" + mins + ")";
		}

		private static DstData GetDstData(TimeZoneInfo zone)
		{
			if (LastYear != DateTime.Now.Year)
			{
				LastYear = DateTime.Now.Year;
				Dst.Clear();
			}

			DstData data;
			if (!Dst.TryGetValue(zone, out data))
			{
				data = new DstData(zone);
				Dst.Add(zone, data);
			}

			return data;
		}

		/// <summary>
		/// Current Dst Data of the TimeZone. Calculates start / end based on the rules
		/// Offset/Info is calculated dynamically so gets updated every minute
		/// </summary>
		private class DstData
		{
			private string Period;

			public DstData(TimeZoneInfo zone)
			{
				TimeZoneInfo.AdjustmentRule rule;
				if (zone.SupportsDaylightSavingTime == false || (rule = GetRule(zone)) == null)
				{
					Offset = TimeSpan.Zero;
					return;
				}

				UseRule(rule);
			}

			#region Properties

			public DateTime Starts { get; private set; }

			public DateTime Ends { get; private set; }

			public TimeSpan Offset { get; private set; }

			public bool HasDst { get; private set; }

			/// <summary>
			/// If HasDst and within the start of current year
			/// </summary>
			public bool InDst
			{
				get
				{
					return HasDst ? Starts < DateTime.Now && DateTime.Now < Ends : false;
				}
			}

			public string Info
			{
				get
				{
					if (!HasDst) return SimplifyInfo ? "-" : "none";
					if (SimplifyInfo) return InDst ? "y" : "n";
					return (InDst ? "on " : string.Empty) + Period;
				}
			}

			public string Rule { get; private set; }

			#endregion

			private TimeZoneInfo.AdjustmentRule GetRule(TimeZoneInfo zone)
			{
				var list = zone.GetAdjustmentRules();
				foreach (var item in list)
				{
					if (item.DateStart < DateTime.Now && item.DateEnd > DateTime.Now)
						return item;
				}

				return null;
			}

			private void UseRule(TimeZoneInfo.AdjustmentRule r)
			{
				Offset = r.DaylightDelta;
				HasDst = true;

				Ends = GetTransitionDate(r.DaylightTransitionEnd);
				Starts = GetTransitionDate(r.DaylightTransitionStart);
				string next = string.Empty;
				if (Starts.Month > Ends.Month)
				{
					Ends = GetTransitionDate(r.DaylightTransitionEnd, DateTime.Now.Year + 1);
					next = "next ";
				}

				Period = string.Format("from {0} till {2}{1}", DateFormatter.Date(Starts), DateFormatter.Date(Ends), next);

				if (r.DaylightTransitionStart.IsFixedDateRule)
				{
					Rule = string.Format("same dates each year since {0})", r.DateStart.Year);
				}
				else
				{
					Rule = string.Format("from {0} till {1} since {2}", Transition_r(r.DaylightTransitionStart), Transition_r(r.DaylightTransitionEnd), r.DateStart.Year);
					if (Ends < DateTime.Now)
					{
						Period += " starts again next " + DateFormatter.Date(GetTransitionDate(r.DaylightTransitionStart, DateTime.Now.Year + 1));
					}
				}
			}

			private DateTime GetTransitionDate(TimeZoneInfo.TransitionTime t, int year = 0)
			{
				if (year == 0) year = DateTime.Now.Year;
				if (t.IsFixedDateRule)
				{
					var st = t.TimeOfDay;
					return new DateTime(year, t.Month, t.Day, st.Hour, st.Minute, st.Second);
				}

				// http://msdn.microsoft.com/en-us/library/system.timezoneinfo.transitiontime.isfixeddaterule.aspx
				var cal = System.Globalization.CultureInfo.CurrentCulture.Calendar;

				// Get first day of week for transition 
				// For example, the 3rd week starts no earlier than the 15th of the month 
				int startOfWeek = t.Week * 7 - 6;

				// What day of the week does the month start on? 
				int firstDayOfWeek = (int)cal.GetDayOfWeek(new DateTime(year, t.Month, 1));

				// Determine how much start date has to be adjusted 
				int transitionDay;
				int changeDayOfWeek = (int)t.DayOfWeek;

				if (firstDayOfWeek <= changeDayOfWeek)
					transitionDay = startOfWeek + (changeDayOfWeek - firstDayOfWeek);
				else
					transitionDay = startOfWeek + (7 - firstDayOfWeek + changeDayOfWeek);

				// Adjust for months with no fifth week 
				if (transitionDay > cal.GetDaysInMonth(year, t.Month))
					transitionDay -= 7;

				var stt = t.TimeOfDay;
				return new DateTime(year, t.Month, transitionDay, stt.Hour, stt.Minute, stt.Second);
			}

			private string Transition_r(TimeZoneInfo.TransitionTime t)
			{
				var month = new DateTime(1900, t.Month, 1).ToString("MMMM");
				return string.Format("{0} {1} of {2}", DateFormatter.Number(t.Week), t.DayOfWeek, month);
			}
		}
	}

	public static class DateFormatter
	{
		public static string LongDate(DateTime dt)
		{
			return string.Format(DateTime.Now.ToString("dddd, MMM {0} yyyy"), Number(dt.Day));
		}

		public static string Date(DateTime dt)
		{
			return string.Format("{0} {1}", dt.ToString("MMMM"), Number(dt.Day));
		}

		public static string Number(int val)
		{
			var i = val % 100;
			var sfx = "th";
			if (i % 10 == 1)
			{
				if (i != 11) sfx = "st";
			}
			else if (i % 10 == 2)
			{
				if (i != 12) sfx = "nd";
			}
			else if (i % 10 == 3)
			{
				if (i != 13) sfx = "rd";
			}

			return string.Concat(val, sfx);
		}
	}
}
