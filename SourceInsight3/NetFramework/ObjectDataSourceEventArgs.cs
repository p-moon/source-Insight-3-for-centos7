public class ObjectDataSourceEventArgs : System.EventArgs
{

	// Constructors
	public ObjectDataSourceEventArgs(object objectInstance) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ObjectInstance { get{} set{} }
}

