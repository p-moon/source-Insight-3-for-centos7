public class LSA_UNICODE_STRING_withPointer
{

	// Constructors
	public LSA_UNICODE_STRING_withPointer() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public short length;
	public short maximumLength;
	public System.IntPtr pwstr;
}

