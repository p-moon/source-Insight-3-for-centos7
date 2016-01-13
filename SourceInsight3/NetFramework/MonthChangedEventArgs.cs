public class MonthChangedEventArgs
{

	// Constructors
	public MonthChangedEventArgs(System.DateTime newDate, System.DateTime previousDate) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime NewDate { get{} }
	public System.DateTime PreviousDate { get{} }
}

