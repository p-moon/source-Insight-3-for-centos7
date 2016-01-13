public class HitArea : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public HitArea Nowhere;
	public HitArea TitleBackground;
	public HitArea TitleMonth;
	public HitArea TitleYear;
	public HitArea NextMonthButton;
	public HitArea PrevMonthButton;
	public HitArea CalendarBackground;
	public HitArea Date;
	public HitArea NextMonthDate;
	public HitArea PrevMonthDate;
	public HitArea DayOfWeek;
	public HitArea WeekNumbers;
	public HitArea TodayLink;
}

