public class DataGridItemEventArgs : System.EventArgs
{

	// Constructors
	public DataGridItemEventArgs(DataGridItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridItem Item { get{} }
}

