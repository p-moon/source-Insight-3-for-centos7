public class HttpStatusCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public HttpStatusCode Continue;
	public HttpStatusCode SwitchingProtocols;
	public HttpStatusCode OK;
	public HttpStatusCode Created;
	public HttpStatusCode Accepted;
	public HttpStatusCode NonAuthoritativeInformation;
	public HttpStatusCode NoContent;
	public HttpStatusCode ResetContent;
	public HttpStatusCode PartialContent;
	public HttpStatusCode MultipleChoices;
	public HttpStatusCode Ambiguous;
	public HttpStatusCode MovedPermanently;
	public HttpStatusCode Moved;
	public HttpStatusCode Found;
	public HttpStatusCode Redirect;
	public HttpStatusCode SeeOther;
	public HttpStatusCode RedirectMethod;
	public HttpStatusCode NotModified;
	public HttpStatusCode UseProxy;
	public HttpStatusCode Unused;
	public HttpStatusCode TemporaryRedirect;
	public HttpStatusCode RedirectKeepVerb;
	public HttpStatusCode BadRequest;
	public HttpStatusCode Unauthorized;
	public HttpStatusCode PaymentRequired;
	public HttpStatusCode Forbidden;
	public HttpStatusCode NotFound;
	public HttpStatusCode MethodNotAllowed;
	public HttpStatusCode NotAcceptable;
	public HttpStatusCode ProxyAuthenticationRequired;
	public HttpStatusCode RequestTimeout;
	public HttpStatusCode Conflict;
	public HttpStatusCode Gone;
	public HttpStatusCode LengthRequired;
	public HttpStatusCode PreconditionFailed;
	public HttpStatusCode RequestEntityTooLarge;
	public HttpStatusCode RequestUriTooLong;
	public HttpStatusCode UnsupportedMediaType;
	public HttpStatusCode RequestedRangeNotSatisfiable;
	public HttpStatusCode ExpectationFailed;
	public HttpStatusCode InternalServerError;
	public HttpStatusCode NotImplemented;
	public HttpStatusCode BadGateway;
	public HttpStatusCode ServiceUnavailable;
	public HttpStatusCode GatewayTimeout;
	public HttpStatusCode HttpVersionNotSupported;
}

