namespace Cselian.IvyUpdater
{
	public enum UpdateFrequency
	{
		AppStart,
		Daily,
		Weekly,
		Biweekly,
		Monthly
	}

	/// <summary>
	/// The unit for a Day Interval
	/// </summary>
	public enum DayUnit
	{
		Day,
		Week,
		Month,
		Year
	}

	/// <summary>
	/// Representation of a Date Interval.
	/// Used to create constants and add them to dates.
	/// </summary>
	public struct DaySpan
	{
		public DaySpan(DayUnit unit, int value)
			: this()
		{
			Unit = unit;
			Value = value;
		}

		public DayUnit Unit { get; set; }

		public int Value { get; set; }
	}
}
