public class HttpParseException : HttpException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public HttpParseException() {}
	public HttpParseException(string message) {}
	public HttpParseException(string message, System.Exception innerException) {}
	public HttpParseException(string message, System.Exception innerException, string virtualPath, string sourceCode, int line) {}

	// Methods
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
	public string FileName { get{} }
	public string VirtualPath { get{} }
	public int Line { get{} }
	public ParserErrorCollection ParserErrors { get{} }
	public int ErrorCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

