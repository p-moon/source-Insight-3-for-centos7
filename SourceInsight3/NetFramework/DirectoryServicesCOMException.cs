public class DirectoryServicesCOMException : System.Runtime.InteropServices.COMException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public DirectoryServicesCOMException() {}
	public DirectoryServicesCOMException(string message) {}
	public DirectoryServicesCOMException(string message, System.Exception inner) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual string ToString() {}
	public virtual System.Exception GetBaseException() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ExtendedError { get{} }
	public string ExtendedErrorMessage { get{} }
	public int ErrorCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

