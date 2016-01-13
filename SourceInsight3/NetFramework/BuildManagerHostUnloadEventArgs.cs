public class BuildManagerHostUnloadEventArgs : System.EventArgs
{

	// Constructors
	public BuildManagerHostUnloadEventArgs(System.Web.ApplicationShutdownReason reason) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.ApplicationShutdownReason Reason { get{} }
}

