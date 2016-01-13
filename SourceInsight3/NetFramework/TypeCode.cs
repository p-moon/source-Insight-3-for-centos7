public class TypeCode : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public TypeCode Empty;
	public TypeCode Object;
	public TypeCode DBNull;
	public TypeCode Boolean;
	public TypeCode Char;
	public TypeCode SByte;
	public TypeCode Byte;
	public TypeCode Int16;
	public TypeCode UInt16;
	public TypeCode Int32;
	public TypeCode UInt32;
	public TypeCode Int64;
	public TypeCode UInt64;
	public TypeCode Single;
	public TypeCode Double;
	public TypeCode Decimal;
	public TypeCode DateTime;
	public TypeCode String;
}

