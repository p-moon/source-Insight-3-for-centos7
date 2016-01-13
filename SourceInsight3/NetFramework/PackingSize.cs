public class PackingSize : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public PackingSize Unspecified;
	public PackingSize Size1;
	public PackingSize Size2;
	public PackingSize Size4;
	public PackingSize Size8;
	public PackingSize Size16;
	public PackingSize Size32;
	public PackingSize Size64;
	public PackingSize Size128;
}

