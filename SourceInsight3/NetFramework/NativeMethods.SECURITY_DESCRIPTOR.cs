public class SECURITY_DESCRIPTOR
{

	// Constructors
	public SECURITY_DESCRIPTOR() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public byte revision;
	public byte size;
	public short control;
	public System.IntPtr owner;
	public System.IntPtr Group;
	public System.IntPtr Sacl;
	public System.IntPtr Dacl;
}

