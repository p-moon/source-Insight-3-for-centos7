public class NavigateEventArgs : System.EventArgs
{

	// Constructors
	public NavigateEventArgs(bool isForward) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Forward { get{} }
}

