using System;

namespace AmadeusWeb.Updater
{
	/// <summary>
	/// Settings for Updates
	/// </summary>
	public class UpdateSettings
	{
		public string Url { get; set; }

		public string ProgramName { get; set; }

		public string Support { get; set; }

		/// <summary>
		/// How often the Update should be run
		/// </summary>
		public UpdateFrequency Frequency { get; set; }

		public bool NeverCheck { get; set; }

		public DateTime? NextUpdateAt { get; set; }

		/// <summary>
		/// When it was last checked
		/// </summary>
		public DateTime? LastCheckedAt { get; set; }

		/// <summary>
		/// When (if ever) it was last updated
		/// </summary>
		public DateTime? LastUpdateAt { get; set; }

		/// <summary>
		/// When was the last time user was told that an update was available.
		/// TODO: UI/workflow for this and the next property
		/// </summary>
		public DateTime? LastRemindedAt { get; set; }

		public DaySpan? RemindAfter { get; set; }
	}
}
