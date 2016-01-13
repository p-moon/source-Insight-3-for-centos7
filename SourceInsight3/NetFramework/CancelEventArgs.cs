public class CancelEventArgs : System.EventArgs
{

	// Constructors
	public CancelEventArgs() {}
	public CancelEventArgs(bool cancel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancel { get{} set{} }
}

