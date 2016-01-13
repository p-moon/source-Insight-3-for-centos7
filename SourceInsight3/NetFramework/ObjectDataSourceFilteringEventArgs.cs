public class ObjectDataSourceFilteringEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ObjectDataSourceFilteringEventArgs(System.Collections.Specialized.IOrderedDictionary parameterValues) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.IOrderedDictionary ParameterValues { get{} }
	public bool Cancel { get{} set{} }
}

