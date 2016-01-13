public class SByte : ValueType, IComparable, IFormattable, IConvertible, IComparable<SByte>, IEquatable<SByte>
{

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual int CompareTo(SByte value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(SByte obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public string ToString(string format) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public static SByte Parse(string s) {}
	public static SByte Parse(string s, System.Globalization.NumberStyles style) {}
	public static SByte Parse(string s, IFormatProvider provider) {}
	public static SByte Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , SByte& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , SByte& result) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public SByte MaxValue;
	public SByte MinValue;
}

