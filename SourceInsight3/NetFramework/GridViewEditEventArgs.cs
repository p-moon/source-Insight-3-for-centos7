public class GridViewEditEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewEditEventArgs(int newEditIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int NewEditIndex { get{} set{} }
	public bool Cancel { get{} set{} }
}

