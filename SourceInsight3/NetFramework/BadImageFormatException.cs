public class BadImageFormatException : SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public BadImageFormatException() {}
	public BadImageFormatException(string message) {}
	public BadImageFormatException(string message, Exception inner) {}
	public BadImageFormatException(string message, string fileName) {}
	public BadImageFormatException(string message, string fileName, Exception inner) {}

	// Methods
	public virtual string ToString() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual Exception GetBaseException() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public string FileName { get{} }
	public string FusionLog { get{} }
	public System.Collections.IDictionary Data { get{} }
	public Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

