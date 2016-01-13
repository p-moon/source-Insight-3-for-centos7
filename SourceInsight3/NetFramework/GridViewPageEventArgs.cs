public class GridViewPageEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewPageEventArgs(int newPageIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int NewPageIndex { get{} set{} }
	public bool Cancel { get{} set{} }
}

