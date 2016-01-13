public class ObjectDataSourceMethodEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ObjectDataSourceMethodEventArgs(System.Collections.Specialized.IOrderedDictionary inputParameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.IOrderedDictionary InputParameters { get{} }
	public bool Cancel { get{} set{} }
}

