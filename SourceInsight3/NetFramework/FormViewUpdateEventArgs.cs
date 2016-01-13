public class FormViewUpdateEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public FormViewUpdateEventArgs(object commandArgument) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandArgument { get{} }
	public System.Collections.Specialized.IOrderedDictionary Keys { get{} }
	public System.Collections.Specialized.IOrderedDictionary NewValues { get{} }
	public System.Collections.Specialized.IOrderedDictionary OldValues { get{} }
	public bool Cancel { get{} set{} }
}

