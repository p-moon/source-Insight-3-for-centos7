public class Single : ValueType, IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float>
{

	// Methods
	public static bool IsInfinity(float f) {}
	public static bool IsPositiveInfinity(float f) {}
	public static bool IsNegativeInfinity(float f) {}
	public static bool IsNaN(float f) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(float value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(float obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public string ToString(string format) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public static float Parse(string s) {}
	public static float Parse(string s, System.Globalization.NumberStyles style) {}
	public static float Parse(string s, IFormatProvider provider) {}
	public static float Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Single& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Single& result) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public float MinValue;
	public float Epsilon;
	public float MaxValue;
	public float PositiveInfinity;
	public float NegativeInfinity;
	public float NaN;
}

