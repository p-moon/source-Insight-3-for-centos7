public class tagDESCKIND : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public tagDESCKIND DESCKIND_NONE;
	public tagDESCKIND DESCKIND_FUNCDESC;
	public tagDESCKIND DESCKIND_VARDESC;
	public tagDESCKIND DESCKIND_TYPECOMP;
	public tagDESCKIND DESCKIND_IMPLICITAPPOBJ;
	public tagDESCKIND DESCKIND_MAX;
}

