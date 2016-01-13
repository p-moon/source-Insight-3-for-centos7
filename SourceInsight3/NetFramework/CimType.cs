public class CimType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public CimType None;
	public CimType SInt8;
	public CimType UInt8;
	public CimType SInt16;
	public CimType UInt16;
	public CimType SInt32;
	public CimType UInt32;
	public CimType SInt64;
	public CimType UInt64;
	public CimType Real32;
	public CimType Real64;
	public CimType Boolean;
	public CimType String;
	public CimType DateTime;
	public CimType Reference;
	public CimType Char16;
	public CimType Object;
}

