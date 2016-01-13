public class CollectionChangeEventArgs : System.EventArgs
{

	// Constructors
	public CollectionChangeEventArgs(CollectionChangeAction action, object element) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CollectionChangeAction Action { get{} }
	public object Element { get{} }
}

