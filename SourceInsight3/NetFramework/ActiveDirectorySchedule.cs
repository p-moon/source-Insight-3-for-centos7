public class ActiveDirectorySchedule
{

	// Constructors
	public ActiveDirectorySchedule() {}
	public ActiveDirectorySchedule(ActiveDirectorySchedule schedule) {}

	// Methods
	public void SetSchedule(System.DayOfWeek day, HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute) {}
	public void SetSchedule(System.DayOfWeek[] days, HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute) {}
	public void SetDailySchedule(HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute) {}
	public void ResetSchedule() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool[] RawSchedule { get{} set{} }
}

