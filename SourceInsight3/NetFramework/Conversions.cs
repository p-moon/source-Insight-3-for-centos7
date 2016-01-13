public class Conversions
{

	// Methods
	public static T ToGenericParameter<T>(object Value) {}
	public static bool ToBoolean(string Value) {}
	public static bool ToBoolean(object Value) {}
	public static byte ToByte(string Value) {}
	public static byte ToByte(object Value) {}
	public static System.SByte ToSByte(string Value) {}
	public static System.SByte ToSByte(object Value) {}
	public static short ToShort(string Value) {}
	public static short ToShort(object Value) {}
	public static ushort ToUShort(string Value) {}
	public static ushort ToUShort(object Value) {}
	public static int ToInteger(string Value) {}
	public static int ToInteger(object Value) {}
	public static uint ToUInteger(string Value) {}
	public static uint ToUInteger(object Value) {}
	public static long ToLong(string Value) {}
	public static long ToLong(object Value) {}
	public static ulong ToULong(string Value) {}
	public static ulong ToULong(object Value) {}
	public static decimal ToDecimal(bool Value) {}
	public static decimal ToDecimal(string Value) {}
	public static decimal ToDecimal(object Value) {}
	public static float ToSingle(string Value) {}
	public static float ToSingle(object Value) {}
	public static double ToDouble(string Value) {}
	public static double ToDouble(object Value) {}
	public static System.DateTime ToDate(string Value) {}
	public static System.DateTime ToDate(object Value) {}
	public static char ToChar(string Value) {}
	public static char ToChar(object Value) {}
	public static char[] ToCharArrayRankOne(string Value) {}
	public static char[] ToCharArrayRankOne(object Value) {}
	public static string ToString(bool Value) {}
	public static string ToString(byte Value) {}
	public static string ToString(char Value) {}
	public static string FromCharArray(char[] Value) {}
	public static string FromCharAndCount(char Value, int Count) {}
	public static string FromCharArraySubset(char[] Value, int StartIndex, int Length) {}
	public static string ToString(short Value) {}
	public static string ToString(int Value) {}
	public static string ToString(uint Value) {}
	public static string ToString(long Value) {}
	public static string ToString(ulong Value) {}
	public static string ToString(float Value) {}
	public static string ToString(double Value) {}
	public static string ToString(float Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string ToString(double Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string ToString(System.DateTime Value) {}
	public static string ToString(decimal Value) {}
	public static string ToString(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string ToString(object Value) {}
	public static object ChangeType(object Expression, Type TargetType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

