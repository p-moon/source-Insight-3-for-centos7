public class PropertyAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public PropertyAttributes None;
	public PropertyAttributes SpecialName;
	public PropertyAttributes ReservedMask;
	public PropertyAttributes RTSpecialName;
	public PropertyAttributes HasDefault;
	public PropertyAttributes Reserved2;
	public PropertyAttributes Reserved3;
	public PropertyAttributes Reserved4;
}

