public class UInt64 : ValueType, IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong>
{

	// Methods
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(ulong value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(ulong obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public string ToString(string format) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public static ulong Parse(string s) {}
	public static ulong Parse(string s, System.Globalization.NumberStyles style) {}
	public static ulong Parse(string s, IFormatProvider provider) {}
	public static ulong Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , UInt64& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , UInt64& result) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public ulong MaxValue;
	public ulong MinValue;
}

