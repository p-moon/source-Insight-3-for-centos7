public class DateAndTime
{

	// Methods
	public static System.DateTime DateAdd(DateInterval Interval, double Number, System.DateTime DateValue) {}
	public static long DateDiff(DateInterval Interval, System.DateTime Date1, System.DateTime Date2, FirstDayOfWeek DayOfWeek, FirstWeekOfYear WeekOfYear) {}
	public static int DatePart(DateInterval Interval, System.DateTime DateValue, FirstDayOfWeek FirstDayOfWeekValue, FirstWeekOfYear FirstWeekOfYearValue) {}
	public static System.DateTime DateAdd(string Interval, double Number, object DateValue) {}
	public static long DateDiff(string Interval, object Date1, object Date2, FirstDayOfWeek DayOfWeek, FirstWeekOfYear WeekOfYear) {}
	public static int DatePart(string Interval, object DateValue, FirstDayOfWeek DayOfWeek, FirstWeekOfYear WeekOfYear) {}
	public static System.DateTime DateSerial(int Year, int Month, int Day) {}
	public static System.DateTime TimeSerial(int Hour, int Minute, int Second) {}
	public static System.DateTime DateValue(string StringDate) {}
	public static System.DateTime TimeValue(string StringTime) {}
	public static int Year(System.DateTime DateValue) {}
	public static int Month(System.DateTime DateValue) {}
	public static int Day(System.DateTime DateValue) {}
	public static int Hour(System.DateTime TimeValue) {}
	public static int Minute(System.DateTime TimeValue) {}
	public static int Second(System.DateTime TimeValue) {}
	public static int Weekday(System.DateTime DateValue, FirstDayOfWeek DayOfWeek) {}
	public static string MonthName(int Month, bool Abbreviate) {}
	public static string WeekdayName(int Weekday, bool Abbreviate, FirstDayOfWeek FirstDayOfWeekValue) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime Today { get{} set{} }
	public System.DateTime Now { get{} }
	public System.DateTime TimeOfDay { get{} set{} }
	public string TimeString { get{} set{} }
	public string DateString { get{} set{} }
	public double Timer { get{} }
}

