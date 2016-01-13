public class DayRenderEventArgs
{

	// Constructors
	public DayRenderEventArgs(TableCell cell, CalendarDay day) {}
	public DayRenderEventArgs(TableCell cell, CalendarDay day, string selectUrl) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TableCell Cell { get{} }
	public CalendarDay Day { get{} }
	public string SelectUrl { get{} }
}

