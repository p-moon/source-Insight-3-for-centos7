public class InstallEventArgs : System.EventArgs
{

	// Constructors
	public InstallEventArgs() {}
	public InstallEventArgs(System.Collections.IDictionary savedState) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary SavedState { get{} }
}

