public class ColumnWidthChangedEventArgs : System.EventArgs
{

	// Constructors
	public ColumnWidthChangedEventArgs(int columnIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
}

