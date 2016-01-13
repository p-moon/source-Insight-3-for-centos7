public class ObjectListSelectEventArgs : System.EventArgs
{

	// Constructors
	public ObjectListSelectEventArgs(ObjectListItem item, bool selectMore) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListItem ListItem { get{} }
	public bool SelectMore { get{} }
	public bool UseDefaultHandling { get{} set{} }
}

