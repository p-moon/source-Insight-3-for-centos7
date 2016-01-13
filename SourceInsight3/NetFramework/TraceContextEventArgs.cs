public class TraceContextEventArgs : System.EventArgs
{

	// Constructors
	public TraceContextEventArgs(System.Collections.ICollection records) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection TraceRecords { get{} }
}

