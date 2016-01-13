public class Int16 : ValueType, IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short>
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(short obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(short value) {}
	public string ToString(string format) {}
	public static short Parse(string s) {}
	public static short Parse(string s, System.Globalization.NumberStyles style) {}
	public static short Parse(string s, IFormatProvider provider) {}
	public static short Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Int16& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Int16& result) {}
	public Type GetType() {}

	// Fields
	public short MaxValue;
	public short MinValue;
}

