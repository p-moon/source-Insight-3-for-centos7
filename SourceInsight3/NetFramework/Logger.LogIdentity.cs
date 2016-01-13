public class LogIdentity
{

	// Constructors
	public LogIdentity() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public uint ThreadId { get{} }
}

