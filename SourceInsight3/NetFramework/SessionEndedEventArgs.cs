public class SessionEndedEventArgs : System.EventArgs
{

	// Constructors
	public SessionEndedEventArgs(SessionEndReasons reason) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SessionEndReasons Reason { get{} }
}

