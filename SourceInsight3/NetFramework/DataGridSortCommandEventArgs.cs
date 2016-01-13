public class DataGridSortCommandEventArgs : System.EventArgs
{

	// Constructors
	public DataGridSortCommandEventArgs(object commandSource, DataGridCommandEventArgs dce) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandSource { get{} }
	public string SortExpression { get{} }
}

