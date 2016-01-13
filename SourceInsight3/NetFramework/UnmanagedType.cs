public class UnmanagedType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public UnmanagedType Bool;
	public UnmanagedType I1;
	public UnmanagedType U1;
	public UnmanagedType I2;
	public UnmanagedType U2;
	public UnmanagedType I4;
	public UnmanagedType U4;
	public UnmanagedType I8;
	public UnmanagedType U8;
	public UnmanagedType R4;
	public UnmanagedType R8;
	public UnmanagedType Currency;
	public UnmanagedType BStr;
	public UnmanagedType LPStr;
	public UnmanagedType LPWStr;
	public UnmanagedType LPTStr;
	public UnmanagedType ByValTStr;
	public UnmanagedType IUnknown;
	public UnmanagedType IDispatch;
	public UnmanagedType Struct;
	public UnmanagedType Interface;
	public UnmanagedType SafeArray;
	public UnmanagedType ByValArray;
	public UnmanagedType SysInt;
	public UnmanagedType SysUInt;
	public UnmanagedType VBByRefStr;
	public UnmanagedType AnsiBStr;
	public UnmanagedType TBStr;
	public UnmanagedType VariantBool;
	public UnmanagedType FunctionPtr;
	public UnmanagedType AsAny;
	public UnmanagedType LPArray;
	public UnmanagedType LPStruct;
	public UnmanagedType CustomMarshaler;
	public UnmanagedType Error;
}

