public class TimeSpan : ValueType, IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>
{

	// Constructors
	public TimeSpan(long ticks) {}
	public TimeSpan(int hours, int minutes, int seconds) {}
	public TimeSpan(int days, int hours, int minutes, int seconds) {}
	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) {}

	// Methods
	public virtual int CompareTo(TimeSpan value) {}
	public virtual bool Equals(object value) {}
	public virtual bool Equals(TimeSpan obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public TimeSpan Add(TimeSpan ts) {}
	public static int Compare(TimeSpan t1, TimeSpan t2) {}
	public virtual int CompareTo(object value) {}
	public static TimeSpan FromDays(double value) {}
	public TimeSpan Duration() {}
	public static bool Equals(TimeSpan t1, TimeSpan t2) {}
	public static TimeSpan FromHours(double value) {}
	public static TimeSpan FromMilliseconds(double value) {}
	public static TimeSpan FromMinutes(double value) {}
	public TimeSpan Negate() {}
	public static TimeSpan Parse(string s) {}
	public static bool TryParse(string sout , TimeSpan& result) {}
	public static TimeSpan FromSeconds(double value) {}
	public TimeSpan Subtract(TimeSpan ts) {}
	public static TimeSpan FromTicks(long value) {}
	public static TimeSpan op_UnaryNegation(TimeSpan t) {}
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) {}
	public static TimeSpan op_UnaryPlus(TimeSpan t) {}
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) {}
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) {}
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) {}
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) {}
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) {}
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) {}
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) {}
	public Type GetType() {}

	// Fields
	public TimeSpan Zero;
	public TimeSpan MaxValue;
	public TimeSpan MinValue;
	public long TicksPerMillisecond;
	public long TicksPerSecond;
	public long TicksPerMinute;
	public long TicksPerHour;
	public long TicksPerDay;

	// Properties
	public long Ticks { get{} }
	public int Days { get{} }
	public int Hours { get{} }
	public int Milliseconds { get{} }
	public int Minutes { get{} }
	public int Seconds { get{} }
	public double TotalDays { get{} }
	public double TotalHours { get{} }
	public double TotalMilliseconds { get{} }
	public double TotalMinutes { get{} }
	public double TotalSeconds { get{} }
}

