public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar, System.ICloneable
{

	// Constructors
	public JapaneseLunisolarCalendar() {}

	// Methods
	public virtual int GetEra(System.DateTime time) {}
	public virtual int GetSexagenaryYear(System.DateTime time) {}
	public int GetCelestialStem(int sexagenaryYear) {}
	public int GetTerrestrialBranch(int sexagenaryYear) {}
	public virtual int GetDaysInMonth(int year, int month, int era) {}
	public virtual System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) {}
	public virtual System.DateTime AddMonths(System.DateTime time, int months) {}
	public virtual System.DateTime AddYears(System.DateTime time, int years) {}
	public virtual int GetDayOfYear(System.DateTime time) {}
	public virtual int GetDayOfMonth(System.DateTime time) {}
	public virtual int GetDaysInYear(int year, int era) {}
	public virtual int GetMonth(System.DateTime time) {}
	public virtual int GetYear(System.DateTime time) {}
	public virtual System.DayOfWeek GetDayOfWeek(System.DateTime time) {}
	public virtual int GetMonthsInYear(int year, int era) {}
	public virtual bool IsLeapDay(int year, int month, int day, int era) {}
	public virtual bool IsLeapMonth(int year, int month, int era) {}
	public virtual int GetLeapMonth(int year, int era) {}
	public virtual bool IsLeapYear(int year, int era) {}
	public virtual int ToFourDigitYear(int year) {}
	public virtual object Clone() {}
	public virtual System.DateTime AddMilliseconds(System.DateTime time, double milliseconds) {}
	public virtual System.DateTime AddDays(System.DateTime time, int days) {}
	public virtual System.DateTime AddHours(System.DateTime time, int hours) {}
	public virtual System.DateTime AddMinutes(System.DateTime time, int minutes) {}
	public virtual System.DateTime AddSeconds(System.DateTime time, int seconds) {}
	public virtual System.DateTime AddWeeks(System.DateTime time, int weeks) {}
	public virtual int GetDaysInMonth(int year, int month) {}
	public virtual int GetDaysInYear(int year) {}
	public virtual int GetHour(System.DateTime time) {}
	public virtual double GetMilliseconds(System.DateTime time) {}
	public virtual int GetMinute(System.DateTime time) {}
	public virtual int GetMonthsInYear(int year) {}
	public virtual int GetSecond(System.DateTime time) {}
	public virtual int GetWeekOfYear(System.DateTime time, CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) {}
	public virtual bool IsLeapDay(int year, int month, int day) {}
	public virtual bool IsLeapMonth(int year, int month) {}
	public virtual int GetLeapMonth(int year) {}
	public virtual bool IsLeapYear(int year) {}
	public virtual System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int JapaneseEra;

	// Properties
	public System.DateTime MinSupportedDateTime { get{} }
	public System.DateTime MaxSupportedDateTime { get{} }
	public int[] Eras { get{} }
	public CalendarAlgorithmType AlgorithmType { get{} }
	public int TwoDigitYearMax { get{} set{} }
	public bool IsReadOnly { get{} }
}

