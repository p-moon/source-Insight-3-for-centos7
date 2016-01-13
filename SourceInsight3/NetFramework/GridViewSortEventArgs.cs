public class GridViewSortEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewSortEventArgs(string sortExpression, SortDirection sortDirection) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SortDirection SortDirection { get{} set{} }
	public string SortExpression { get{} set{} }
	public bool Cancel { get{} set{} }
}

