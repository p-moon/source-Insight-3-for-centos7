public class DateTimeOffset : ValueType, IComparable, IFormattable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>
{

	// Constructors
	public DateTimeOffset(long ticks, TimeSpan offset) {}
	public DateTimeOffset(DateTime dateTime) {}
	public DateTimeOffset(DateTime dateTime, TimeSpan offset) {}
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) {}
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) {}
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, TimeSpan offset) {}

	// Methods
	public DateTimeOffset ToOffset(TimeSpan offset) {}
	public DateTimeOffset Add(TimeSpan timeSpan) {}
	public DateTimeOffset AddDays(double days) {}
	public DateTimeOffset AddHours(double hours) {}
	public DateTimeOffset AddMilliseconds(double milliseconds) {}
	public DateTimeOffset AddMinutes(double minutes) {}
	public DateTimeOffset AddMonths(int months) {}
	public DateTimeOffset AddSeconds(double seconds) {}
	public DateTimeOffset AddTicks(long ticks) {}
	public DateTimeOffset AddYears(int years) {}
	public static int Compare(DateTimeOffset first, DateTimeOffset second) {}
	public virtual int CompareTo(DateTimeOffset other) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(DateTimeOffset other) {}
	public bool EqualsExact(DateTimeOffset other) {}
	public static bool Equals(DateTimeOffset first, DateTimeOffset second) {}
	public static DateTimeOffset FromFileTime(long fileTime) {}
	public virtual int GetHashCode() {}
	public static DateTimeOffset Parse(string input) {}
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) {}
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) {}
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider) {}
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) {}
	public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) {}
	public TimeSpan Subtract(DateTimeOffset value) {}
	public DateTimeOffset Subtract(TimeSpan value) {}
	public long ToFileTime() {}
	public DateTimeOffset ToLocalTime() {}
	public virtual string ToString() {}
	public string ToString(string format) {}
	public string ToString(IFormatProvider formatProvider) {}
	public virtual string ToString(string format, IFormatProvider formatProvider) {}
	public DateTimeOffset ToUniversalTime() {}
	public static bool TryParse(string inputout , DateTimeOffset& result) {}
	public static bool TryParse(string input, IFormatProvider formatProvider, System.Globalization.DateTimeStyles stylesout , DateTimeOffset& result) {}
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, System.Globalization.DateTimeStyles stylesout , DateTimeOffset& result) {}
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, System.Globalization.DateTimeStyles stylesout , DateTimeOffset& result) {}
	public static DateTimeOffset op_Implicit(DateTime dateTime) {}
	public static DateTimeOffset op_Addition(DateTimeOffset dateTimeTz, TimeSpan timeSpan) {}
	public static DateTimeOffset op_Subtraction(DateTimeOffset dateTimeTz, TimeSpan timeSpan) {}
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_LessThan(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_LessThanOrEqual(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_GreaterThan(DateTimeOffset left, DateTimeOffset right) {}
	public static bool op_GreaterThanOrEqual(DateTimeOffset left, DateTimeOffset right) {}
	public Type GetType() {}

	// Fields
	public DateTimeOffset MinValue;
	public DateTimeOffset MaxValue;

	// Properties
	public DateTimeOffset Now { get{} }
	public DateTimeOffset UtcNow { get{} }
	public DateTime DateTime { get{} }
	public DateTime UtcDateTime { get{} }
	public DateTime LocalDateTime { get{} }
	public DateTime Date { get{} }
	public int Day { get{} }
	public DayOfWeek DayOfWeek { get{} }
	public int DayOfYear { get{} }
	public int Hour { get{} }
	public int Millisecond { get{} }
	public int Minute { get{} }
	public int Month { get{} }
	public TimeSpan Offset { get{} }
	public int Second { get{} }
	public long Ticks { get{} }
	public long UtcTicks { get{} }
	public TimeSpan TimeOfDay { get{} }
	public int Year { get{} }
}

