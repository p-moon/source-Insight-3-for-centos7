public class VariantType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public VariantType Empty;
	public VariantType Null;
	public VariantType Short;
	public VariantType Integer;
	public VariantType Single;
	public VariantType Double;
	public VariantType Currency;
	public VariantType Date;
	public VariantType String;
	public VariantType Object;
	public VariantType Error;
	public VariantType Boolean;
	public VariantType Variant;
	public VariantType DataObject;
	public VariantType Decimal;
	public VariantType Byte;
	public VariantType Char;
	public VariantType Long;
	public VariantType UserDefinedType;
	public VariantType Array;
}

