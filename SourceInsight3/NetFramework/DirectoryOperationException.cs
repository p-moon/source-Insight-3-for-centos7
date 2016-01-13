public class DirectoryOperationException : DirectoryException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public DirectoryOperationException() {}
	public DirectoryOperationException(string message) {}
	public DirectoryOperationException(string message, System.Exception inner) {}
	public DirectoryOperationException(DirectoryResponse response) {}
	public DirectoryOperationException(DirectoryResponse response, string message) {}
	public DirectoryOperationException(DirectoryResponse response, string message, System.Exception inner) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryResponse Response { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

