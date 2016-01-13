public class NumberStyles : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public NumberStyles None;
	public NumberStyles AllowLeadingWhite;
	public NumberStyles AllowTrailingWhite;
	public NumberStyles AllowLeadingSign;
	public NumberStyles AllowTrailingSign;
	public NumberStyles AllowParentheses;
	public NumberStyles AllowDecimalPoint;
	public NumberStyles AllowThousands;
	public NumberStyles AllowExponent;
	public NumberStyles AllowCurrencySymbol;
	public NumberStyles AllowHexSpecifier;
	public NumberStyles Integer;
	public NumberStyles HexNumber;
	public NumberStyles Number;
	public NumberStyles Float;
	public NumberStyles Currency;
	public NumberStyles Any;
}

