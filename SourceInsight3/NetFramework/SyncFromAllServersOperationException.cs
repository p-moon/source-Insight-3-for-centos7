public class SyncFromAllServersOperationException : ActiveDirectoryOperationException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SyncFromAllServersOperationException(string message, System.Exception inner, SyncFromAllServersErrorInformation[] errors) {}
	public SyncFromAllServersOperationException(string message, System.Exception inner) {}
	public SyncFromAllServersOperationException(string message) {}
	public SyncFromAllServersOperationException() {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SyncFromAllServersErrorInformation[] ErrorInformation { get{} }
	public int ErrorCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

