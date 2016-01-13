public class Int64 : ValueType, IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long>
{

	// Methods
	public virtual int CompareTo(long value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(long obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int CompareTo(object value) {}
	public string ToString(string format) {}
	public static long Parse(string s) {}
	public static long Parse(string s, System.Globalization.NumberStyles style) {}
	public static long Parse(string s, IFormatProvider provider) {}
	public static long Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Int64& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Int64& result) {}
	public Type GetType() {}

	// Fields
	public long MaxValue;
	public long MinValue;
}

