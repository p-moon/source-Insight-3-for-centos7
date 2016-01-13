public class HttpException : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public HttpException() {}
	public HttpException(string message) {}
	public HttpException(string message, int hr) {}
	public HttpException(string message, System.Exception innerException) {}
	public HttpException(int httpCode, string message, System.Exception innerException) {}
	public HttpException(int httpCode, string message) {}
	public HttpException(int httpCode, string message, int hr) {}

	// Methods
	public static HttpException CreateFromLastError(string message) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public int GetHttpCode() {}
	public string GetHtmlErrorMessage() {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ErrorCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

