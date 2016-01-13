public class AuthenticateEventArgs : System.EventArgs
{

	// Constructors
	public AuthenticateEventArgs() {}
	public AuthenticateEventArgs(bool authenticated) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Authenticated { get{} set{} }
}

