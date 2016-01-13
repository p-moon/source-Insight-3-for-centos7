public class BreakOutOfFinally : System.ApplicationException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public BreakOutOfFinally(int target) {}
	public BreakOutOfFinally(string m) {}
	public BreakOutOfFinally(string m, System.Exception e) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int target;

	// Properties
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

