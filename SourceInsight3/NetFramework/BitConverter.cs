public class BitConverter
{

	// Methods
	public static byte[] GetBytes(bool value) {}
	public static byte[] GetBytes(char value) {}
	public static byte[] GetBytes(short value) {}
	public static byte[] GetBytes(int value) {}
	public static byte[] GetBytes(long value) {}
	public static byte[] GetBytes(ushort value) {}
	public static byte[] GetBytes(uint value) {}
	public static byte[] GetBytes(ulong value) {}
	public static byte[] GetBytes(float value) {}
	public static byte[] GetBytes(double value) {}
	public static char ToChar(byte[] value, int startIndex) {}
	public static short ToInt16(byte[] value, int startIndex) {}
	public static int ToInt32(byte[] value, int startIndex) {}
	public static long ToInt64(byte[] value, int startIndex) {}
	public static ushort ToUInt16(byte[] value, int startIndex) {}
	public static uint ToUInt32(byte[] value, int startIndex) {}
	public static ulong ToUInt64(byte[] value, int startIndex) {}
	public static float ToSingle(byte[] value, int startIndex) {}
	public static double ToDouble(byte[] value, int startIndex) {}
	public static string ToString(byte[] value, int startIndex, int length) {}
	public static string ToString(byte[] value) {}
	public static string ToString(byte[] value, int startIndex) {}
	public static bool ToBoolean(byte[] value, int startIndex) {}
	public static long DoubleToInt64Bits(double value) {}
	public static double Int64BitsToDouble(long value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public bool IsLittleEndian;
}

