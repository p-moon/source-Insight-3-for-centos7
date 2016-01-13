public class TYPELIBATTR : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.Guid guid;
	public int lcid;
	public SYSKIND syskind;
	public short wMajorVerNum;
	public short wMinorVerNum;
	public LIBFLAGS wLibFlags;
}

