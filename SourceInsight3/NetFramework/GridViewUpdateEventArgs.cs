public class GridViewUpdateEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public GridViewUpdateEventArgs(int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.IOrderedDictionary Keys { get{} }
	public System.Collections.Specialized.IOrderedDictionary NewValues { get{} }
	public System.Collections.Specialized.IOrderedDictionary OldValues { get{} }
	public int RowIndex { get{} }
	public bool Cancel { get{} set{} }
}

