using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cselian.IvyUpdater
{
	/// <summary>
	/// Checks for Updates and launches updater when has any
	/// </summary>
	public static class UpdateManager
	{
		public static string Caption { get; private set; }

		public static UpdateVersion GetVersion()
		{
			return StoreHelper.Read<UpdateVersion>();
		}

		public static bool MustCheckForUpdates()
		{
			var settings = ReadSettings();

			if (settings.NeverCheck)
			{
				return false;
			}

			if (settings.LastRemindedAt.HasValue)
			{
				if (settings.RemindAfter.HasValue && settings.LastRemindedAt.Value.AddSpan(settings.RemindAfter.Value) < DateTime.Now)
				{
					return false;
				}

				settings.LastRemindedAt = DateTime.Now;
			}
			else if (settings.Frequency != UpdateFrequency.AppStart)
			{
				if (DateTime.Now < settings.NextUpdateAt.GetValueOrDefault())
				{
					return false;
				}

				var span = Spans.Of(settings.Frequency);
				if (settings.NextUpdateAt.HasValue == false)
				{
					settings.NextUpdateAt = DateTime.Today;
				}

				while (settings.NextUpdateAt.Value <= DateTime.Today)
				{
					settings.NextUpdateAt = settings.NextUpdateAt.Value.AddSpan(span);
				}
			}

			settings.LastCheckedAt = DateTime.Now;
			StoreHelper.Save(settings);

			// TODO: recalculate the NextUpdateAt if appstart is false
			// should that be calculated in the settings dialog as well? perhaps not
			return true;
		}

		public static void CheckForUpdates()
		{
			RunUpdater();
		}

		public static void ShowSettings()
		{
			RunUpdater("/set");
		}

		internal static UpdateSettings ReadSettings()
		{
			var settings = StoreHelper.Read<UpdateSettings>()
				?? new UpdateSettings { Frequency = UpdateFrequency.Daily, NextUpdateAt = DateTime.Today };

			if (string.IsNullOrEmpty(settings.Url))
			{
				settings.Url = "http://localhost/microvic/ivy/updates/"; // .cselian.com
				settings.ProgramName = "IViewer";
				settings.Support = "ivy@cselian.com";
				StoreHelper.Save(settings);
			}

			Caption = settings.ProgramName + " - Ivy Updater";

			return settings;
		}

		internal static string GetZipName(UpdateSettings s)
		{
			return s.ProgramName + "-latest.zip";
		}

		private static void RunUpdater(string args = null)
		{
			var exe = typeof(UpdateManager).Assembly.Location;
			Program.Run(exe, args);
		}

		private static DateTime AddSpan(this DateTime what, DaySpan period)
		{
			switch (period.Unit)
			{
				case DayUnit.Day:
					return what.AddDays(period.Value);
				case DayUnit.Week:
					return what.AddDays(period.Value * 7);
				case DayUnit.Month:
					return what.AddMonths(period.Value);
				case DayUnit.Year:
					return what.AddYears(period.Value);
				default:
					throw new NotImplementedException("Unsupported DayUnit:" + period.Unit.ToString());
			}
		}

		/// <summary>
		/// Holds DaySpan per UpdateFrequency
		/// </summary>
		private static class Spans
		{
			private static readonly Dictionary<UpdateFrequency, DaySpan> DaySpans;

			static Spans()
			{
				DaySpans = new Dictionary<UpdateFrequency, DaySpan>();
				Add(UpdateFrequency.Daily, DayUnit.Day, 1);
				Add(UpdateFrequency.Weekly, DayUnit.Week, 1);
				Add(UpdateFrequency.Biweekly, DayUnit.Day, 14);
				Add(UpdateFrequency.Monthly, DayUnit.Month, 1);
			}

			public static DaySpan Of(UpdateFrequency freq)
			{
				return DaySpans[freq];
			}

			private static void Add(UpdateFrequency uf, DayUnit unit, int val)
			{
				DaySpans.Add(uf, new DaySpan(unit, val));
			}
		}
	}
}
