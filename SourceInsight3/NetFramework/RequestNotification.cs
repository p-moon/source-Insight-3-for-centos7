public class RequestNotification : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public RequestNotification BeginRequest;
	public RequestNotification AuthenticateRequest;
	public RequestNotification AuthorizeRequest;
	public RequestNotification ResolveRequestCache;
	public RequestNotification MapRequestHandler;
	public RequestNotification AcquireRequestState;
	public RequestNotification PreExecuteRequestHandler;
	public RequestNotification ExecuteRequestHandler;
	public RequestNotification ReleaseRequestState;
	public RequestNotification UpdateRequestCache;
	public RequestNotification LogRequest;
	public RequestNotification EndRequest;
	public RequestNotification SendResponse;
}

