public class ArgumentOutOfRangeException : ArgumentException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public ArgumentOutOfRangeException() {}
	public ArgumentOutOfRangeException(string paramName) {}
	public ArgumentOutOfRangeException(string paramName, string message) {}
	public ArgumentOutOfRangeException(string message, Exception innerException) {}
	public ArgumentOutOfRangeException(string paramName, object actualValue, string message) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public object ActualValue { get{} }
	public string ParamName { get{} }
	public System.Collections.IDictionary Data { get{} }
	public Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

