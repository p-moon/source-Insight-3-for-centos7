public class CALLCONV : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public CALLCONV CC_CDECL;
	public CALLCONV CC_MSCPASCAL;
	public CALLCONV CC_PASCAL;
	public CALLCONV CC_MACPASCAL;
	public CALLCONV CC_STDCALL;
	public CALLCONV CC_RESERVED;
	public CALLCONV CC_SYSCALL;
	public CALLCONV CC_MPWCDECL;
	public CALLCONV CC_MPWPASCAL;
	public CALLCONV CC_MAX;
}

