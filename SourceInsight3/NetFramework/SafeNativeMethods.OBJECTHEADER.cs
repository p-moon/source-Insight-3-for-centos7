public class OBJECTHEADER : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public short signature;
	public short headersize;
	public short objectType;
	public short nameLen;
	public short classLen;
	public short nameOffset;
	public short classOffset;
	public short width;
	public short height;
	public System.IntPtr pInfo;
}

