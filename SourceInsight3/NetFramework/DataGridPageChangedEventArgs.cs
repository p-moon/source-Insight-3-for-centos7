public class DataGridPageChangedEventArgs : System.EventArgs
{

	// Constructors
	public DataGridPageChangedEventArgs(object commandSource, int newPageIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandSource { get{} }
	public int NewPageIndex { get{} }
}

