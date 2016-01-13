public class ThreadExceptionEventArgs : System.EventArgs
{

	// Constructors
	public ThreadExceptionEventArgs(System.Exception t) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Exception Exception { get{} }
}

