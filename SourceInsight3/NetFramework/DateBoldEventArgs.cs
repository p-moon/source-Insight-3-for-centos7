public class DateBoldEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime StartDate { get{} }
	public int Size { get{} }
	public int[] DaysToBold { get{} set{} }
}

