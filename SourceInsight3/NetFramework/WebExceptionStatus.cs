public class WebExceptionStatus : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public WebExceptionStatus Success;
	public WebExceptionStatus NameResolutionFailure;
	public WebExceptionStatus ConnectFailure;
	public WebExceptionStatus ReceiveFailure;
	public WebExceptionStatus SendFailure;
	public WebExceptionStatus PipelineFailure;
	public WebExceptionStatus RequestCanceled;
	public WebExceptionStatus ProtocolError;
	public WebExceptionStatus ConnectionClosed;
	public WebExceptionStatus TrustFailure;
	public WebExceptionStatus SecureChannelFailure;
	public WebExceptionStatus ServerProtocolViolation;
	public WebExceptionStatus KeepAliveFailure;
	public WebExceptionStatus Pending;
	public WebExceptionStatus Timeout;
	public WebExceptionStatus ProxyNameResolutionFailure;
	public WebExceptionStatus UnknownError;
	public WebExceptionStatus MessageLengthLimitExceeded;
	public WebExceptionStatus CacheEntryNotFound;
	public WebExceptionStatus RequestProhibitedByCachePolicy;
	public WebExceptionStatus RequestProhibitedByProxy;
}

