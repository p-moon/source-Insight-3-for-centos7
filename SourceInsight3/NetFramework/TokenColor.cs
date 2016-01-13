public class TokenColor : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TokenColor COLOR_TEXT;
	public TokenColor COLOR_IDENTIFIER;
	public TokenColor COLOR_KEYWORD;
	public TokenColor COLOR_COMMENT;
	public TokenColor COLOR_OPERATOR;
	public TokenColor COLOR_NUMBER;
	public TokenColor COLOR_STRING;
	public TokenColor COLOR_CONDITIONAL_COMP;
}

