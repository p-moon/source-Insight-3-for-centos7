public class Char : ValueType, IComparable, IConvertible, IComparable<char>, IEquatable<char>
{

	// Methods
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(char obj) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(char value) {}
	public static string ToString(char c) {}
	public static char Parse(string s) {}
	public static bool TryParse(string sout , Char& result) {}
	public static bool IsDigit(char c) {}
	public static bool IsLetter(char c) {}
	public static bool IsWhiteSpace(char c) {}
	public static bool IsUpper(char c) {}
	public static bool IsLower(char c) {}
	public static bool IsPunctuation(char c) {}
	public static bool IsLetterOrDigit(char c) {}
	public static char ToUpper(char c, System.Globalization.CultureInfo culture) {}
	public static char ToUpper(char c) {}
	public static char ToUpperInvariant(char c) {}
	public static char ToLower(char c, System.Globalization.CultureInfo culture) {}
	public static char ToLower(char c) {}
	public static char ToLowerInvariant(char c) {}
	public static bool IsControl(char c) {}
	public static bool IsControl(string s, int index) {}
	public static bool IsDigit(string s, int index) {}
	public static bool IsLetter(string s, int index) {}
	public static bool IsLetterOrDigit(string s, int index) {}
	public static bool IsLower(string s, int index) {}
	public static bool IsNumber(char c) {}
	public static bool IsNumber(string s, int index) {}
	public static bool IsPunctuation(string s, int index) {}
	public static bool IsSeparator(char c) {}
	public static bool IsSeparator(string s, int index) {}
	public static bool IsSurrogate(char c) {}
	public static bool IsSurrogate(string s, int index) {}
	public static bool IsSymbol(char c) {}
	public static bool IsSymbol(string s, int index) {}
	public static bool IsUpper(string s, int index) {}
	public static bool IsWhiteSpace(string s, int index) {}
	public static System.Globalization.UnicodeCategory GetUnicodeCategory(char c) {}
	public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index) {}
	public static double GetNumericValue(char c) {}
	public static double GetNumericValue(string s, int index) {}
	public static bool IsHighSurrogate(char c) {}
	public static bool IsHighSurrogate(string s, int index) {}
	public static bool IsLowSurrogate(char c) {}
	public static bool IsLowSurrogate(string s, int index) {}
	public static bool IsSurrogatePair(string s, int index) {}
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) {}
	public static string ConvertFromUtf32(int utf32) {}
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) {}
	public static int ConvertToUtf32(string s, int index) {}
	public Type GetType() {}

	// Fields
	public char MaxValue;
	public char MinValue;
}

