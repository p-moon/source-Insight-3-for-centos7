public class TimeZone
{

	// Methods
	public abstract virtual TimeSpan GetUtcOffset(DateTime time) {}
	public virtual DateTime ToUniversalTime(DateTime time) {}
	public virtual DateTime ToLocalTime(DateTime time) {}
	public abstract virtual System.Globalization.DaylightTime GetDaylightChanges(int year) {}
	public virtual bool IsDaylightSavingTime(DateTime time) {}
	public static bool IsDaylightSavingTime(DateTime time, System.Globalization.DaylightTime daylightTimes) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TimeZone CurrentTimeZone { get{} }
	public string StandardName { get{} }
	public string DaylightName { get{} }
}

