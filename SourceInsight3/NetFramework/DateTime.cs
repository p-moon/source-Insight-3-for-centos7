public class DateTime : ValueType, IComparable, IFormattable, IConvertible, System.Runtime.Serialization.ISerializable, IComparable<DateTime>, IEquatable<DateTime>
{

	// Constructors
	public DateTime(long ticks) {}
	public DateTime(long ticks, DateTimeKind kind) {}
	public DateTime(int year, int month, int day) {}
	public DateTime(int year, int month, int day, System.Globalization.Calendar calendar) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) {}
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, DateTimeKind kind) {}

	// Methods
	public DateTime Add(TimeSpan value) {}
	public DateTime AddDays(double value) {}
	public DateTime AddHours(double value) {}
	public DateTime AddMilliseconds(double value) {}
	public DateTime AddMinutes(double value) {}
	public DateTime AddMonths(int months) {}
	public DateTime AddSeconds(double value) {}
	public DateTime AddTicks(long value) {}
	public DateTime AddYears(int value) {}
	public static int Compare(DateTime t1, DateTime t2) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(DateTime value) {}
	public static int DaysInMonth(int year, int month) {}
	public virtual bool Equals(object value) {}
	public virtual bool Equals(DateTime value) {}
	public static bool Equals(DateTime t1, DateTime t2) {}
	public static DateTime FromBinary(long dateData) {}
	public static DateTime FromFileTime(long fileTime) {}
	public static DateTime FromFileTimeUtc(long fileTime) {}
	public static DateTime FromOADate(double d) {}
	public bool IsDaylightSavingTime() {}
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) {}
	public long ToBinary() {}
	public virtual int GetHashCode() {}
	public static bool IsLeapYear(int year) {}
	public static DateTime Parse(string s) {}
	public static DateTime Parse(string s, IFormatProvider provider) {}
	public static DateTime Parse(string s, IFormatProvider provider, System.Globalization.DateTimeStyles styles) {}
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) {}
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, System.Globalization.DateTimeStyles style) {}
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, System.Globalization.DateTimeStyles style) {}
	public TimeSpan Subtract(DateTime value) {}
	public DateTime Subtract(TimeSpan value) {}
	public double ToOADate() {}
	public long ToFileTime() {}
	public long ToFileTimeUtc() {}
	public DateTime ToLocalTime() {}
	public string ToLongDateString() {}
	public string ToLongTimeString() {}
	public string ToShortDateString() {}
	public string ToShortTimeString() {}
	public virtual string ToString() {}
	public string ToString(string format) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public DateTime ToUniversalTime() {}
	public static bool TryParse(string sout , DateTime& result) {}
	public static bool TryParse(string s, IFormatProvider provider, System.Globalization.DateTimeStyles stylesout , DateTime& result) {}
	public static bool TryParseExact(string s, string format, IFormatProvider provider, System.Globalization.DateTimeStyles styleout , DateTime& result) {}
	public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, System.Globalization.DateTimeStyles styleout , DateTime& result) {}
	public static DateTime op_Addition(DateTime d, TimeSpan t) {}
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) {}
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) {}
	public static bool op_Equality(DateTime d1, DateTime d2) {}
	public static bool op_Inequality(DateTime d1, DateTime d2) {}
	public static bool op_LessThan(DateTime t1, DateTime t2) {}
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) {}
	public static bool op_GreaterThan(DateTime t1, DateTime t2) {}
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) {}
	public string[] GetDateTimeFormats() {}
	public string[] GetDateTimeFormats(IFormatProvider provider) {}
	public string[] GetDateTimeFormats(char format) {}
	public string[] GetDateTimeFormats(char format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public DateTime MinValue;
	public DateTime MaxValue;

	// Properties
	public DateTime Date { get{} }
	public int Day { get{} }
	public DayOfWeek DayOfWeek { get{} }
	public int DayOfYear { get{} }
	public int Hour { get{} }
	public DateTimeKind Kind { get{} }
	public int Millisecond { get{} }
	public int Minute { get{} }
	public int Month { get{} }
	public DateTime Now { get{} }
	public DateTime UtcNow { get{} }
	public int Second { get{} }
	public long Ticks { get{} }
	public TimeSpan TimeOfDay { get{} }
	public DateTime Today { get{} }
	public int Year { get{} }
}

