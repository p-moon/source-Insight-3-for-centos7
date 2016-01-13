public class StringType
{

	// Methods
	public static string FromBoolean(bool Value) {}
	public static string FromByte(byte Value) {}
	public static string FromChar(char Value) {}
	public static string FromShort(short Value) {}
	public static string FromInteger(int Value) {}
	public static string FromLong(long Value) {}
	public static string FromSingle(float Value) {}
	public static string FromDouble(double Value) {}
	public static string FromSingle(float Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string FromDouble(double Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string FromDate(System.DateTime Value) {}
	public static string FromDecimal(decimal Value) {}
	public static string FromDecimal(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) {}
	public static string FromObject(object Value) {}
	public static int StrCmp(string sLeft, string sRight, bool TextCompare) {}
	public static bool StrLike(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) {}
	public static bool StrLikeBinary(string Source, string Pattern) {}
	public static bool StrLikeText(string Source, string Pattern) {}
	public static void MidStmtStr(System.String& sDest, int StartPosition, int MaxInsertLength, string sInsert) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

