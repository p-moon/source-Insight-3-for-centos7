public interface _Exception
{

	// Methods
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object obj) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual Type GetType() {}
	public abstract virtual System.Exception GetBaseException() {}
	public abstract virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}

	// Properties
	public string Message { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
}

