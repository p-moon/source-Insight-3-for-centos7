public class ObjectListShowCommandsEventArgs : System.EventArgs
{

	// Constructors
	public ObjectListShowCommandsEventArgs(ObjectListItem item, ObjectListCommandCollection commands) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListCommandCollection Commands { get{} }
	public ObjectListItem ListItem { get{} }
}

