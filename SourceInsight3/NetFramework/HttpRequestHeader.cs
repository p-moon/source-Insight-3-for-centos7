public class HttpRequestHeader : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public HttpRequestHeader CacheControl;
	public HttpRequestHeader Connection;
	public HttpRequestHeader Date;
	public HttpRequestHeader KeepAlive;
	public HttpRequestHeader Pragma;
	public HttpRequestHeader Trailer;
	public HttpRequestHeader TransferEncoding;
	public HttpRequestHeader Upgrade;
	public HttpRequestHeader Via;
	public HttpRequestHeader Warning;
	public HttpRequestHeader Allow;
	public HttpRequestHeader ContentLength;
	public HttpRequestHeader ContentType;
	public HttpRequestHeader ContentEncoding;
	public HttpRequestHeader ContentLanguage;
	public HttpRequestHeader ContentLocation;
	public HttpRequestHeader ContentMd5;
	public HttpRequestHeader ContentRange;
	public HttpRequestHeader Expires;
	public HttpRequestHeader LastModified;
	public HttpRequestHeader Accept;
	public HttpRequestHeader AcceptCharset;
	public HttpRequestHeader AcceptEncoding;
	public HttpRequestHeader AcceptLanguage;
	public HttpRequestHeader Authorization;
	public HttpRequestHeader Cookie;
	public HttpRequestHeader Expect;
	public HttpRequestHeader From;
	public HttpRequestHeader Host;
	public HttpRequestHeader IfMatch;
	public HttpRequestHeader IfModifiedSince;
	public HttpRequestHeader IfNoneMatch;
	public HttpRequestHeader IfRange;
	public HttpRequestHeader IfUnmodifiedSince;
	public HttpRequestHeader MaxForwards;
	public HttpRequestHeader ProxyAuthorization;
	public HttpRequestHeader Referer;
	public HttpRequestHeader Range;
	public HttpRequestHeader Te;
	public HttpRequestHeader Translate;
	public HttpRequestHeader UserAgent;
}

