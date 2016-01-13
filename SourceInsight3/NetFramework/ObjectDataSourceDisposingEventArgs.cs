public class ObjectDataSourceDisposingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ObjectDataSourceDisposingEventArgs(object objectInstance) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ObjectInstance { get{} }
	public bool Cancel { get{} set{} }
}

