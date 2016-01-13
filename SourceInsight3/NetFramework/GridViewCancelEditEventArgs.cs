public class GridViewCancelEditEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewCancelEditEventArgs(int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public bool Cancel { get{} set{} }
}

