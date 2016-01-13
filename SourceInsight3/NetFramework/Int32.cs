public class Int32 : ValueType, IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int>
{

	// Methods
	public virtual int CompareTo(int value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(int obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int CompareTo(object value) {}
	public string ToString(string format) {}
	public static int Parse(string s) {}
	public static int Parse(string s, System.Globalization.NumberStyles style) {}
	public static int Parse(string s, IFormatProvider provider) {}
	public static int Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Int32& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Int32& result) {}
	public Type GetType() {}

	// Fields
	public int MaxValue;
	public int MinValue;
}

