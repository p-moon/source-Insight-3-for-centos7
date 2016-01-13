public class AsyncCallback : MulticastDelegate, ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public AsyncCallback(object object, IntPtr method) {}

	// Methods
	public virtual void Invoke(IAsyncResult ar) {}
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) {}
	public virtual void EndInvoke(IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

