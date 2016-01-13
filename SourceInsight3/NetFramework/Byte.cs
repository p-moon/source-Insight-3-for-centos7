public class Byte : ValueType, IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte>
{

	// Methods
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(byte value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(byte obj) {}
	public virtual int GetHashCode() {}
	public static byte Parse(string s) {}
	public static byte Parse(string s, System.Globalization.NumberStyles style) {}
	public static byte Parse(string s, IFormatProvider provider) {}
	public static byte Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Byte& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Byte& result) {}
	public virtual string ToString() {}
	public string ToString(string format) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public byte MaxValue;
	public byte MinValue;
}

