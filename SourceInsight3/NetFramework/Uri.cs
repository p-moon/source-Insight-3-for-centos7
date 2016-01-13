public class Uri : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public Uri(string uriString) {}
	public Uri(string uriString, UriKind uriKind) {}
	public Uri(Uri baseUri, string relativeUri) {}
	public Uri(string uriString, bool dontEscape) {}
	public Uri(Uri baseUri, string relativeUri, bool dontEscape) {}
	public Uri(Uri baseUri, Uri relativeUri) {}

	// Methods
	public static bool op_Equality(Uri uri1, Uri uri2) {}
	public static bool op_Inequality(Uri uri1, Uri uri2) {}
	public static UriHostNameType CheckHostName(string name) {}
	public static bool CheckSchemeName(string schemeName) {}
	public static int FromHex(char digit) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual bool Equals(object comparand) {}
	public string GetLeftPart(UriPartial part) {}
	public static string HexEscape(char character) {}
	public static char HexUnescape(string pattern, Int32& index) {}
	public static bool IsHexDigit(char character) {}
	public static bool IsHexEncoding(string pattern, int index) {}
	public string MakeRelative(Uri toUri) {}
	public Uri MakeRelativeUri(Uri uri) {}
	public static bool TryCreate(string uriString, UriKind uriKindout , Uri& result) {}
	public static bool TryCreate(Uri baseUri, string relativeUriout , Uri& result) {}
	public static bool TryCreate(Uri baseUri, Uri relativeUriout , Uri& result) {}
	public bool IsBaseOf(Uri uri) {}
	public string GetComponents(UriComponents components, UriFormat format) {}
	public bool IsWellFormedOriginalString() {}
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) {}
	public static int Compare(Uri uri1, Uri uri2, UriComponents partsToCompare, UriFormat compareFormat, StringComparison comparisonType) {}
	public static string UnescapeDataString(string stringToUnescape) {}
	public static string EscapeUriString(string stringToEscape) {}
	public static string EscapeDataString(string stringToEscape) {}
	public Type GetType() {}

	// Fields
	public string UriSchemeFile;
	public string UriSchemeFtp;
	public string UriSchemeGopher;
	public string UriSchemeHttp;
	public string UriSchemeHttps;
	public string UriSchemeMailto;
	public string UriSchemeNews;
	public string UriSchemeNntp;
	public string UriSchemeNetTcp;
	public string UriSchemeNetPipe;
	public string SchemeDelimiter;

	// Properties
	public string AbsolutePath { get{} }
	public string AbsoluteUri { get{} }
	public string Authority { get{} }
	public string Host { get{} }
	public UriHostNameType HostNameType { get{} }
	public bool IsDefaultPort { get{} }
	public bool IsFile { get{} }
	public bool IsLoopback { get{} }
	public bool IsUnc { get{} }
	public string LocalPath { get{} }
	public string PathAndQuery { get{} }
	public int Port { get{} }
	public string Query { get{} }
	public string Fragment { get{} }
	public string Scheme { get{} }
	public string OriginalString { get{} }
	public string DnsSafeHost { get{} }
	public bool IsAbsoluteUri { get{} }
	public string[] Segments { get{} }
	public bool UserEscaped { get{} }
	public string UserInfo { get{} }
}

