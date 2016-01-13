public class Boolean : ValueType, IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(bool obj) {}
	public virtual int CompareTo(object obj) {}
	public virtual int CompareTo(bool value) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public static bool Parse(string value) {}
	public static bool TryParse(string valueout , Boolean& result) {}
	public Type GetType() {}

	// Fields
	public string TrueString;
	public string FalseString;
}

