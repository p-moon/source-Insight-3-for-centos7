public class ListDataBindEventArgs : System.EventArgs
{

	// Constructors
	public ListDataBindEventArgs(MobileListItem item, object dataItem) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MobileListItem ListItem { get{} }
	public object DataItem { get{} }
}

