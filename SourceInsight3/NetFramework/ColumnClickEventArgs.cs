public class ColumnClickEventArgs : System.EventArgs
{

	// Constructors
	public ColumnClickEventArgs(int column) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Column { get{} }
}

