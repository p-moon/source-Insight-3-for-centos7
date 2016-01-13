public class UInt32 : ValueType, IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint>
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(uint value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(uint obj) {}
	public string ToString(string format) {}
	public static uint Parse(string s) {}
	public static uint Parse(string s, System.Globalization.NumberStyles style) {}
	public static uint Parse(string s, IFormatProvider provider) {}
	public static uint Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , UInt32& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , UInt32& result) {}
	public Type GetType() {}

	// Fields
	public uint MaxValue;
	public uint MinValue;
}

