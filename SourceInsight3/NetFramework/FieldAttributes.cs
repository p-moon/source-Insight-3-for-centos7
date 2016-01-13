public class FieldAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public FieldAttributes FieldAccessMask;
	public FieldAttributes PrivateScope;
	public FieldAttributes Private;
	public FieldAttributes FamANDAssem;
	public FieldAttributes Assembly;
	public FieldAttributes Family;
	public FieldAttributes FamORAssem;
	public FieldAttributes Public;
	public FieldAttributes Static;
	public FieldAttributes InitOnly;
	public FieldAttributes Literal;
	public FieldAttributes NotSerialized;
	public FieldAttributes SpecialName;
	public FieldAttributes PinvokeImpl;
	public FieldAttributes ReservedMask;
	public FieldAttributes RTSpecialName;
	public FieldAttributes HasFieldMarshal;
	public FieldAttributes HasDefault;
	public FieldAttributes HasFieldRVA;
}

