public class DsReplicaSyncAllW : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public DsReplicaSyncAllW(object object, System.IntPtr method) {}

	// Methods
	public virtual int Invoke(System.IntPtr handle, string partition, int flags, SyncReplicaFromAllServersCallback callback, System.IntPtr data, System.IntPtr& error) {}
	public virtual System.IAsyncResult BeginInvoke(System.IntPtr handle, string partition, int flags, SyncReplicaFromAllServersCallback callback, System.IntPtr data, System.IntPtr& error, System.AsyncCallback callback, object object) {}
	public virtual int EndInvoke(System.IntPtr& error, System.IAsyncResult result) {}
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

