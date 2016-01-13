public class Double : ValueType, IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double>
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(double obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public static bool IsInfinity(double d) {}
	public static bool IsPositiveInfinity(double d) {}
	public static bool IsNegativeInfinity(double d) {}
	public static bool IsNaN(double d) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(double value) {}
	public string ToString(string format) {}
	public static double Parse(string s) {}
	public static double Parse(string s, System.Globalization.NumberStyles style) {}
	public static double Parse(string s, IFormatProvider provider) {}
	public static double Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Double& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Double& result) {}
	public Type GetType() {}

	// Fields
	public double MinValue;
	public double MaxValue;
	public double Epsilon;
	public double NegativeInfinity;
	public double PositiveInfinity;
	public double NaN;
}

