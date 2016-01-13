public class CompareInfo : System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public static CompareInfo GetCompareInfo(int culture, System.Reflection.Assembly assembly) {}
	public static CompareInfo GetCompareInfo(string name, System.Reflection.Assembly assembly) {}
	public static CompareInfo GetCompareInfo(int culture) {}
	public static CompareInfo GetCompareInfo(string name) {}
	public static bool IsSortable(char ch) {}
	public static bool IsSortable(string text) {}
	public virtual int Compare(string string1, string string2) {}
	public virtual int Compare(string string1, string string2, CompareOptions options) {}
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2) {}
	public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options) {}
	public virtual int Compare(string string1, int offset1, string string2, int offset2) {}
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) {}
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) {}
	public virtual bool IsPrefix(string source, string prefix) {}
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) {}
	public virtual bool IsSuffix(string source, string suffix) {}
	public virtual int IndexOf(string source, char value) {}
	public virtual int IndexOf(string source, string value) {}
	public virtual int IndexOf(string source, char value, CompareOptions options) {}
	public virtual int IndexOf(string source, string value, CompareOptions options) {}
	public virtual int IndexOf(string source, char value, int startIndex) {}
	public virtual int IndexOf(string source, string value, int startIndex) {}
	public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options) {}
	public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options) {}
	public virtual int IndexOf(string source, char value, int startIndex, int count) {}
	public virtual int IndexOf(string source, string value, int startIndex, int count) {}
	public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options) {}
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) {}
	public virtual int LastIndexOf(string source, char value) {}
	public virtual int LastIndexOf(string source, string value) {}
	public virtual int LastIndexOf(string source, char value, CompareOptions options) {}
	public virtual int LastIndexOf(string source, string value, CompareOptions options) {}
	public virtual int LastIndexOf(string source, char value, int startIndex) {}
	public virtual int LastIndexOf(string source, string value, int startIndex) {}
	public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options) {}
	public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options) {}
	public virtual int LastIndexOf(string source, char value, int startIndex, int count) {}
	public virtual int LastIndexOf(string source, string value, int startIndex, int count) {}
	public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options) {}
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) {}
	public virtual SortKey GetSortKey(string source, CompareOptions options) {}
	public virtual SortKey GetSortKey(string source) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Name { get{} }
	public int LCID { get{} }
}

