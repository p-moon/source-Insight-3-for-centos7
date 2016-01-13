public class SymAddressKind : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public SymAddressKind ILOffset;
	public SymAddressKind NativeRVA;
	public SymAddressKind NativeRegister;
	public SymAddressKind NativeRegisterRelative;
	public SymAddressKind NativeOffset;
	public SymAddressKind NativeRegisterRegister;
	public SymAddressKind NativeRegisterStack;
	public SymAddressKind NativeStackRegister;
	public SymAddressKind BitField;
	public SymAddressKind NativeSectionOffset;
}

