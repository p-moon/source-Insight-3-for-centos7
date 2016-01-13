public class VARIANT
{

	// Constructors
	public VARIANT() {}

	// Methods
	public void Clear() {}
	public static VARIANT FromObject(object var) {}
	public void SetLong(long lVal) {}
	public System.IntPtr ToCoTaskMemPtr() {}
	public object ToObject() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public short vt;
	public short reserved1;
	public short reserved2;
	public short reserved3;
	public System.IntPtr data1;
	public System.IntPtr data2;

	// Properties
	public bool Byref { get{} }
}

