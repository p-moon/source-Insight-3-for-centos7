public class DESCKIND : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public DESCKIND DESCKIND_NONE;
	public DESCKIND DESCKIND_FUNCDESC;
	public DESCKIND DESCKIND_VARDESC;
	public DESCKIND DESCKIND_TYPECOMP;
	public DESCKIND DESCKIND_IMPLICITAPPOBJ;
	public DESCKIND DESCKIND_MAX;
}

