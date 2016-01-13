public class InvalidProjectFileException : System.Exception, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public InvalidProjectFileException() {}
	public InvalidProjectFileException(string message) {}
	public InvalidProjectFileException(string message, System.Exception innerException) {}
	public InvalidProjectFileException(System.Xml.XmlNode xmlNode, string message, string errorSubcategory, string errorCode, string helpKeyword) {}
	public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public string BaseMessage { get{} }
	public string ProjectFile { get{} }
	public int LineNumber { get{} }
	public int ColumnNumber { get{} }
	public int EndLineNumber { get{} }
	public int EndColumnNumber { get{} }
	public string ErrorSubcategory { get{} }
	public string ErrorCode { get{} }
	public string HelpKeyword { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

