public class GridViewRowEventArgs : System.EventArgs
{

	// Constructors
	public GridViewRowEventArgs(GridViewRow row) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public GridViewRow Row { get{} }
}

