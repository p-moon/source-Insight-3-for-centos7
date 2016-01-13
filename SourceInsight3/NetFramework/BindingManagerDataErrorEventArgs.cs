public class BindingManagerDataErrorEventArgs : System.EventArgs
{

	// Constructors
	public BindingManagerDataErrorEventArgs(System.Exception exception) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Exception Exception { get{} }
}

