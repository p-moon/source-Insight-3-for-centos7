public class LoadedEventArgs : System.EventArgs
{

	// Constructors
	public LoadedEventArgs(bool succeeded, System.Collections.ICollection errors) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection Errors { get{} }
	public bool HasSucceeded { get{} }
}

