public class CalendarDay
{

	// Constructors
	public CalendarDay(System.DateTime date, bool isWeekend, bool isToday, bool isSelected, bool isOtherMonth, string dayNumberText) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime Date { get{} }
	public string DayNumberText { get{} }
	public bool IsOtherMonth { get{} }
	public bool IsSelectable { get{} set{} }
	public bool IsSelected { get{} }
	public bool IsToday { get{} }
	public bool IsWeekend { get{} }
}

