public class DateRangeEventArgs : System.EventArgs
{

	// Constructors
	public DateRangeEventArgs(System.DateTime start, System.DateTime end) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime Start { get{} }
	public System.DateTime End { get{} }
}

