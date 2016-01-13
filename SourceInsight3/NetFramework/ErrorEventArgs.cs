public class ErrorEventArgs : System.EventArgs
{

	// Constructors
	public ErrorEventArgs(System.Exception exception) {}

	// Methods
	public virtual System.Exception GetException() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

