public class ServiceControlCallbackEx : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ServiceControlCallbackEx(object object, System.IntPtr method) {}

	// Methods
	public virtual int Invoke(int control, int eventType, System.IntPtr eventData, System.IntPtr eventContext) {}
	public virtual System.IAsyncResult BeginInvoke(int control, int eventType, System.IntPtr eventData, System.IntPtr eventContext, System.AsyncCallback callback, object object) {}
	public virtual int EndInvoke(System.IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

