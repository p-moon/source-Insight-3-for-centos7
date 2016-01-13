public class String : IComparable, ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, System.Collections.IEnumerable, IEquatable<string>
{

	// Constructors
	public String(Char* value) {}
	public String(Char* value, int startIndex, int length) {}
	public String(SByte* value) {}
	public String(SByte* value, int startIndex, int length) {}
	public String(SByte* value, int startIndex, int length, System.Text.Encoding enc) {}
	public String(char[] value, int startIndex, int length) {}
	public String(char[] value) {}
	public String(char c, int count) {}

	// Methods
	public int IndexOf(char value, int startIndex, int count) {}
	public int IndexOfAny(char[] anyOf, int startIndex, int count) {}
	public int LastIndexOf(char value, int startIndex, int count) {}
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) {}
	public string Insert(int startIndex, string value) {}
	public string Replace(char oldChar, char newChar) {}
	public string Replace(string oldValue, string newValue) {}
	public string Remove(int startIndex, int count) {}
	public static string Join(string separator, string[] value) {}
	public static string Join(string separator, string[] value, int startIndex, int count) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(string value) {}
	public bool Equals(string value, StringComparison comparisonType) {}
	public static bool Equals(string a, string b) {}
	public static bool Equals(string a, string b, StringComparison comparisonType) {}
	public static bool op_Equality(string a, string b) {}
	public static bool op_Inequality(string a, string b) {}
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) {}
	public char[] ToCharArray() {}
	public char[] ToCharArray(int startIndex, int length) {}
	public static bool IsNullOrEmpty(string value) {}
	public virtual int GetHashCode() {}
	public string[] Split(char[] separator) {}
	public string[] Split(char[] separator, int count) {}
	public string[] Split(char[] separator, StringSplitOptions options) {}
	public string[] Split(char[] separator, int count, StringSplitOptions options) {}
	public string[] Split(string[] separator, StringSplitOptions options) {}
	public string[] Split(string[] separator, int count, StringSplitOptions options) {}
	public string Substring(int startIndex) {}
	public string Substring(int startIndex, int length) {}
	public string Trim(char[] trimChars) {}
	public string TrimStart(char[] trimChars) {}
	public string TrimEnd(char[] trimChars) {}
	public bool IsNormalized() {}
	public bool IsNormalized(System.Text.NormalizationForm normalizationForm) {}
	public string Normalize() {}
	public string Normalize(System.Text.NormalizationForm normalizationForm) {}
	public static int Compare(string strA, string strB) {}
	public static int Compare(string strA, string strB, bool ignoreCase) {}
	public static int Compare(string strA, string strB, StringComparison comparisonType) {}
	public static int Compare(string strA, string strB, bool ignoreCase, System.Globalization.CultureInfo culture) {}
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) {}
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) {}
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, System.Globalization.CultureInfo culture) {}
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(string strB) {}
	public static int CompareOrdinal(string strA, string strB) {}
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) {}
	public bool Contains(string value) {}
	public bool EndsWith(string value) {}
	public bool EndsWith(string value, StringComparison comparisonType) {}
	public bool EndsWith(string value, bool ignoreCase, System.Globalization.CultureInfo culture) {}
	public int IndexOf(char value) {}
	public int IndexOf(char value, int startIndex) {}
	public int IndexOfAny(char[] anyOf) {}
	public int IndexOfAny(char[] anyOf, int startIndex) {}
	public int IndexOf(string value) {}
	public int IndexOf(string value, int startIndex) {}
	public int IndexOf(string value, int startIndex, int count) {}
	public int IndexOf(string value, StringComparison comparisonType) {}
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) {}
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) {}
	public int LastIndexOf(char value) {}
	public int LastIndexOf(char value, int startIndex) {}
	public int LastIndexOfAny(char[] anyOf) {}
	public int LastIndexOfAny(char[] anyOf, int startIndex) {}
	public int LastIndexOf(string value) {}
	public int LastIndexOf(string value, int startIndex) {}
	public int LastIndexOf(string value, int startIndex, int count) {}
	public int LastIndexOf(string value, StringComparison comparisonType) {}
	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType) {}
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) {}
	public string PadLeft(int totalWidth) {}
	public string PadLeft(int totalWidth, char paddingChar) {}
	public string PadRight(int totalWidth) {}
	public string PadRight(int totalWidth, char paddingChar) {}
	public bool StartsWith(string value) {}
	public bool StartsWith(string value, StringComparison comparisonType) {}
	public bool StartsWith(string value, bool ignoreCase, System.Globalization.CultureInfo culture) {}
	public string ToLower() {}
	public string ToLower(System.Globalization.CultureInfo culture) {}
	public string ToLowerInvariant() {}
	public string ToUpper() {}
	public string ToUpper(System.Globalization.CultureInfo culture) {}
	public string ToUpperInvariant() {}
	public virtual string ToString() {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual object Clone() {}
	public string Trim() {}
	public string Remove(int startIndex) {}
	public static string Format(string format, object arg0) {}
	public static string Format(string format, object arg0, object arg1) {}
	public static string Format(string format, object arg0, object arg1, object arg2) {}
	public static string Format(string format, object[] args) {}
	public static string Format(IFormatProvider provider, string format, object[] args) {}
	public static string Copy(string str) {}
	public static string Concat(object arg0) {}
	public static string Concat(object arg0, object arg1) {}
	public static string Concat(object arg0, object arg1, object arg2) {}
	public static string Concat(object arg0, object arg1, object arg2, object arg3) {}
	public static string Concat(object[] args) {}
	public static string Concat(string str0, string str1) {}
	public static string Concat(string str0, string str1, string str2) {}
	public static string Concat(string str0, string str1, string str2, string str3) {}
	public static string Concat(string[] values) {}
	public static string Intern(string str) {}
	public static string IsInterned(string str) {}
	public virtual TypeCode GetTypeCode() {}
	public CharEnumerator GetEnumerator() {}
	public Type GetType() {}

	// Fields
	public string Empty;

	// Properties
	public char Chars { get{} }
	public int Length { get{} }
}

