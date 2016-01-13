public class HttpUtility
{

	// Constructors
	public HttpUtility() {}

	// Methods
	public static string HtmlDecode(string s) {}
	public static void HtmlDecode(string s, System.IO.TextWriter output) {}
	public static string HtmlEncode(string s) {}
	public static void HtmlEncode(string s, System.IO.TextWriter output) {}
	public static string HtmlAttributeEncode(string s) {}
	public static void HtmlAttributeEncode(string s, System.IO.TextWriter output) {}
	public static System.Collections.Specialized.NameValueCollection ParseQueryString(string query) {}
	public static System.Collections.Specialized.NameValueCollection ParseQueryString(string query, System.Text.Encoding encoding) {}
	public static string UrlEncode(string str) {}
	public static string UrlPathEncode(string str) {}
	public static string UrlEncode(string str, System.Text.Encoding e) {}
	public static string UrlEncode(byte[] bytes) {}
	public static string UrlEncode(byte[] bytes, int offset, int count) {}
	public static byte[] UrlEncodeToBytes(string str) {}
	public static byte[] UrlEncodeToBytes(string str, System.Text.Encoding e) {}
	public static byte[] UrlEncodeToBytes(byte[] bytes) {}
	public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) {}
	public static string UrlEncodeUnicode(string str) {}
	public static byte[] UrlEncodeUnicodeToBytes(string str) {}
	public static string UrlDecode(string str) {}
	public static string UrlDecode(string str, System.Text.Encoding e) {}
	public static string UrlDecode(byte[] bytes, System.Text.Encoding e) {}
	public static string UrlDecode(byte[] bytes, int offset, int count, System.Text.Encoding e) {}
	public static byte[] UrlDecodeToBytes(string str) {}
	public static byte[] UrlDecodeToBytes(string str, System.Text.Encoding e) {}
	public static byte[] UrlDecodeToBytes(byte[] bytes) {}
	public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

