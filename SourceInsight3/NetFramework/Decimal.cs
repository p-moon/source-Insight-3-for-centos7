public class Decimal : ValueType, IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>
{

	// Constructors
	public Decimal(float value) {}
	public Decimal(double value) {}
	public Decimal(int value) {}
	public Decimal(uint value) {}
	public Decimal(long value) {}
	public Decimal(ulong value) {}
	public Decimal(int[] bits) {}
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) {}

	// Methods
	public static int Compare(decimal d1, decimal d2) {}
	public virtual int GetHashCode() {}
	public static double ToDouble(decimal d) {}
	public static float ToSingle(decimal d) {}
	public static long ToOACurrency(decimal value) {}
	public static decimal FromOACurrency(long cy) {}
	public static decimal Add(decimal d1, decimal d2) {}
	public static decimal Ceiling(decimal d) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(decimal value) {}
	public static decimal Divide(decimal d1, decimal d2) {}
	public virtual bool Equals(object value) {}
	public virtual bool Equals(decimal value) {}
	public static bool Equals(decimal d1, decimal d2) {}
	public static decimal Floor(decimal d) {}
	public virtual string ToString() {}
	public string ToString(string format) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public static decimal Parse(string s) {}
	public static decimal Parse(string s, System.Globalization.NumberStyles style) {}
	public static decimal Parse(string s, IFormatProvider provider) {}
	public static decimal Parse(string s, System.Globalization.NumberStyles style, IFormatProvider provider) {}
	public static bool TryParse(string sout , Decimal& result) {}
	public static bool TryParse(string s, System.Globalization.NumberStyles style, IFormatProvider providerout , Decimal& result) {}
	public static int[] GetBits(decimal d) {}
	public static decimal Remainder(decimal d1, decimal d2) {}
	public static decimal Multiply(decimal d1, decimal d2) {}
	public static decimal Negate(decimal d) {}
	public static decimal Round(decimal d) {}
	public static decimal Round(decimal d, int decimals) {}
	public static decimal Round(decimal d, MidpointRounding mode) {}
	public static decimal Round(decimal d, int decimals, MidpointRounding mode) {}
	public static decimal Subtract(decimal d1, decimal d2) {}
	public static byte ToByte(decimal value) {}
	public static SByte ToSByte(decimal value) {}
	public static short ToInt16(decimal value) {}
	public static int ToInt32(decimal d) {}
	public static long ToInt64(decimal d) {}
	public static ushort ToUInt16(decimal value) {}
	public static uint ToUInt32(decimal d) {}
	public static ulong ToUInt64(decimal d) {}
	public static decimal Truncate(decimal d) {}
	public static decimal op_Implicit(byte value) {}
	public static decimal op_Implicit(SByte value) {}
	public static decimal op_Implicit(short value) {}
	public static decimal op_Implicit(ushort value) {}
	public static decimal op_Implicit(char value) {}
	public static decimal op_Implicit(int value) {}
	public static decimal op_Implicit(uint value) {}
	public static decimal op_Implicit(long value) {}
	public static decimal op_Implicit(ulong value) {}
	public static decimal op_Explicit(float value) {}
	public static decimal op_Explicit(double value) {}
	public static byte op_Explicit(decimal value) {}
	public static SByte op_Explicit(decimal value) {}
	public static char op_Explicit(decimal value) {}
	public static short op_Explicit(decimal value) {}
	public static ushort op_Explicit(decimal value) {}
	public static int op_Explicit(decimal value) {}
	public static uint op_Explicit(decimal value) {}
	public static long op_Explicit(decimal value) {}
	public static ulong op_Explicit(decimal value) {}
	public static float op_Explicit(decimal value) {}
	public static double op_Explicit(decimal value) {}
	public static decimal op_UnaryPlus(decimal d) {}
	public static decimal op_UnaryNegation(decimal d) {}
	public static decimal op_Increment(decimal d) {}
	public static decimal op_Decrement(decimal d) {}
	public static decimal op_Addition(decimal d1, decimal d2) {}
	public static decimal op_Subtraction(decimal d1, decimal d2) {}
	public static decimal op_Multiply(decimal d1, decimal d2) {}
	public static decimal op_Division(decimal d1, decimal d2) {}
	public static decimal op_Modulus(decimal d1, decimal d2) {}
	public static bool op_Equality(decimal d1, decimal d2) {}
	public static bool op_Inequality(decimal d1, decimal d2) {}
	public static bool op_LessThan(decimal d1, decimal d2) {}
	public static bool op_LessThanOrEqual(decimal d1, decimal d2) {}
	public static bool op_GreaterThan(decimal d1, decimal d2) {}
	public static bool op_GreaterThanOrEqual(decimal d1, decimal d2) {}
	public virtual TypeCode GetTypeCode() {}
	public Type GetType() {}

	// Fields
	public decimal Zero;
	public decimal One;
	public decimal MinusOne;
	public decimal MaxValue;
	public decimal MinValue;
}

