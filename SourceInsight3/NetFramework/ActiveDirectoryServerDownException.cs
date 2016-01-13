public class ActiveDirectoryServerDownException : System.Exception, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public ActiveDirectoryServerDownException(string message, System.Exception inner, int errorCode, string name) {}
	public ActiveDirectoryServerDownException(string message, int errorCode, string name) {}
	public ActiveDirectoryServerDownException(string message, System.Exception inner) {}
	public ActiveDirectoryServerDownException(string message) {}
	public ActiveDirectoryServerDownException() {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ErrorCode { get{} }
	public string Name { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

