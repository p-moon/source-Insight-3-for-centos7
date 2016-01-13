public class UnreferencedObjectEventArgs : System.EventArgs
{

	// Constructors
	public UnreferencedObjectEventArgs(object o, string id) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object UnreferencedObject { get{} }
	public string UnreferencedId { get{} }
}

