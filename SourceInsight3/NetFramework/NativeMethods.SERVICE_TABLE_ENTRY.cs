public class SERVICE_TABLE_ENTRY
{

	// Constructors
	public SERVICE_TABLE_ENTRY() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr name;
	public System.Delegate callback;
}

