public class MemberFilter : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public MemberFilter(object object, System.IntPtr method) {}

	// Methods
	public virtual bool Invoke(MemberInfo m, object filterCriteria) {}
	public virtual System.IAsyncResult BeginInvoke(MemberInfo m, object filterCriteria, System.AsyncCallback callback, object object) {}
	public virtual bool EndInvoke(System.IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public MethodInfo Method { get{} }
	public object Target { get{} }
}

