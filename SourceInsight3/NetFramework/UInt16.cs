public class UInt16 : ValueType, IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort>
{

	// Methods
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(ushort value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(ushort obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public string ToString(string format) {}
	public static ushort Parse(string s) {}
	public static ushort Parse(string s, System.Globalization.NumberStyles style) {}
	public static ushort Parse(string s, IFormatProvider provider) {}
	public static ushort Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , UInt16& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , UInt16& result) {}
	public Type GetType() {}

	// Fields
	public ushort MaxValue;
	public ushort MinValue;
}

