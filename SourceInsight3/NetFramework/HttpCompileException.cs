public class HttpCompileException : HttpException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public HttpCompileException() {}
	public HttpCompileException(string message) {}
	public HttpCompileException(string message, System.Exception innerException) {}
	public HttpCompileException(System.CodeDom.Compiler.CompilerResults results, string sourceCode) {}

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
	public string Message { get{} }
	public System.CodeDom.Compiler.CompilerResults Results { get{} }
	public string SourceCode { get{} }
	public int ErrorCode { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

