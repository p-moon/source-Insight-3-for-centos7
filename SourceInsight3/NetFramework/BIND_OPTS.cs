public class BIND_OPTS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int cbStruct;
	public int grfFlags;
	public int grfMode;
	public int dwTickCountDeadline;
}

