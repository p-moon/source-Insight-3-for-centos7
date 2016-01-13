public class DsReplicaGetInfo2W : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public DsReplicaGetInfo2W(object object, System.IntPtr method) {}

	// Methods
	public virtual int Invoke(System.IntPtr handle, int type, string objectPath, System.IntPtr sourceGUID, string attributeName, string value, int flag, int context, System.IntPtr& info) {}
	public virtual System.IAsyncResult BeginInvoke(System.IntPtr handle, int type, string objectPath, System.IntPtr sourceGUID, string attributeName, string value, int flag, int context, System.IntPtr& info, System.AsyncCallback callback, object object) {}
	public virtual int EndInvoke(System.IntPtr& info, System.IAsyncResult result) {}
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

