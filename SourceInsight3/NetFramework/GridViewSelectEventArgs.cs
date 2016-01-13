public class GridViewSelectEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewSelectEventArgs(int newSelectedIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int NewSelectedIndex { get{} set{} }
	public bool Cancel { get{} set{} }
}

