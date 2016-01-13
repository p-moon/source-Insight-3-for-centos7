public class Enum : ValueType, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public static object Parse(Type enumType, string value) {}
	public static object Parse(Type enumType, string value, bool ignoreCase) {}
	public static Type GetUnderlyingType(Type enumType) {}
	public static Array GetValues(Type enumType) {}
	public static string GetName(Type enumType, object value) {}
	public static string[] GetNames(Type enumType) {}
	public static object ToObject(Type enumType, object value) {}
	public static bool IsDefined(Type enumType, object value) {}
	public static string Format(Type enumType, object value, string format) {}
	public string ToString(string format) {}
	public static object ToObject(Type enumType, SByte value) {}
	public static object ToObject(Type enumType, short value) {}
	public static object ToObject(Type enumType, int value) {}
	public static object ToObject(Type enumType, byte value) {}
	public static object ToObject(Type enumType, ushort value) {}
	public static object ToObject(Type enumType, uint value) {}
	public static object ToObject(Type enumType, long value) {}
	public static object ToObject(Type enumType, ulong value) {}
	public Type GetType() {}
}

