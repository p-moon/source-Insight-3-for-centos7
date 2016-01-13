public class HttpResponseHeader : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public HttpResponseHeader CacheControl;
	public HttpResponseHeader Connection;
	public HttpResponseHeader Date;
	public HttpResponseHeader KeepAlive;
	public HttpResponseHeader Pragma;
	public HttpResponseHeader Trailer;
	public HttpResponseHeader TransferEncoding;
	public HttpResponseHeader Upgrade;
	public HttpResponseHeader Via;
	public HttpResponseHeader Warning;
	public HttpResponseHeader Allow;
	public HttpResponseHeader ContentLength;
	public HttpResponseHeader ContentType;
	public HttpResponseHeader ContentEncoding;
	public HttpResponseHeader ContentLanguage;
	public HttpResponseHeader ContentLocation;
	public HttpResponseHeader ContentMd5;
	public HttpResponseHeader ContentRange;
	public HttpResponseHeader Expires;
	public HttpResponseHeader LastModified;
	public HttpResponseHeader AcceptRanges;
	public HttpResponseHeader Age;
	public HttpResponseHeader ETag;
	public HttpResponseHeader Location;
	public HttpResponseHeader ProxyAuthenticate;
	public HttpResponseHeader RetryAfter;
	public HttpResponseHeader Server;
	public HttpResponseHeader SetCookie;
	public HttpResponseHeader Vary;
	public HttpResponseHeader WwwAuthenticate;
}

