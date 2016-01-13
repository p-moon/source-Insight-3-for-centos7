public class SessionSwitchEventArgs : System.EventArgs
{

	// Constructors
	public SessionSwitchEventArgs(SessionSwitchReason reason) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SessionSwitchReason Reason { get{} }
}

