public class ObjectListDataBindEventArgs : System.EventArgs
{

	// Constructors
	public ObjectListDataBindEventArgs(ObjectListItem item, object dataItem) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListItem ListItem { get{} }
	public object DataItem { get{} }
}

