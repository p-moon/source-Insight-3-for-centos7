public class RefreshEventArgs : System.EventArgs
{

	// Constructors
	public RefreshEventArgs(object componentChanged) {}
	public RefreshEventArgs(Type typeChanged) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ComponentChanged { get{} }
	public Type TypeChanged { get{} }
}

