public class TYPEKIND : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TYPEKIND TKIND_ENUM;
	public TYPEKIND TKIND_RECORD;
	public TYPEKIND TKIND_MODULE;
	public TYPEKIND TKIND_INTERFACE;
	public TYPEKIND TKIND_DISPATCH;
	public TYPEKIND TKIND_COCLASS;
	public TYPEKIND TKIND_ALIAS;
	public TYPEKIND TKIND_UNION;
	public TYPEKIND TKIND_MAX;
}

