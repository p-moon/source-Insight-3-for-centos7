public class UriComponents : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public UriComponents Scheme;
	public UriComponents UserInfo;
	public UriComponents Host;
	public UriComponents Port;
	public UriComponents Path;
	public UriComponents Query;
	public UriComponents Fragment;
	public UriComponents StrongPort;
	public UriComponents KeepDelimiter;
	public UriComponents SerializationInfoString;
	public UriComponents AbsoluteUri;
	public UriComponents HostAndPort;
	public UriComponents StrongAuthority;
	public UriComponents SchemeAndServer;
	public UriComponents HttpRequestUrl;
	public UriComponents PathAndQuery;
}

