public class tagTYPEKIND : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public tagTYPEKIND TKIND_ENUM;
	public tagTYPEKIND TKIND_RECORD;
	public tagTYPEKIND TKIND_MODULE;
	public tagTYPEKIND TKIND_INTERFACE;
	public tagTYPEKIND TKIND_DISPATCH;
	public tagTYPEKIND TKIND_COCLASS;
	public tagTYPEKIND TKIND_ALIAS;
	public tagTYPEKIND TKIND_UNION;
	public tagTYPEKIND TKIND_MAX;
}

