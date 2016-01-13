public class DetailsViewInsertEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public DetailsViewInsertEventArgs(object commandArgument) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandArgument { get{} }
	public System.Collections.Specialized.IOrderedDictionary Values { get{} }
	public bool Cancel { get{} set{} }
}

