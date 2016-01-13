public class FilterType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public FilterType And;
	public FilterType Or;
	public FilterType Not;
	public FilterType EqualityMatch;
	public FilterType Substrings;
	public FilterType GreaterOrEqual;
	public FilterType LessOrEqual;
	public FilterType Present;
	public FilterType ApproxMatch;
	public FilterType ExtensibleMatch;
}

