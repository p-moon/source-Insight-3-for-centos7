public class JScriptException : System.ApplicationException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception, IVsaFullErrorInfo, Microsoft.Vsa.IVsaError
{

	// Constructors
	public JScriptException() {}
	public JScriptException(string m) {}
	public JScriptException(string m, System.Exception e) {}
	public JScriptException(JSError errorNumber) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SourceMoniker { get{} }
	public int StartColumn { get{} }
	public int Column { get{} }
	public string Description { get{} }
	public int EndLine { get{} }
	public int EndColumn { get{} }
	public int Number { get{} }
	public int ErrorNumber { get{} }
	public int Line { get{} }
	public string LineText { get{} }
	public string Message { get{} }
	public int Severity { get{} }
	public Microsoft.Vsa.IVsaItem SourceItem { get{} }
	public string StackTrace { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

