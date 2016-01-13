public class ModuleResolveEventHandler : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ModuleResolveEventHandler(object object, System.IntPtr method) {}

	// Methods
	public virtual Module Invoke(object sender, System.ResolveEventArgs e) {}
	public virtual System.IAsyncResult BeginInvoke(object sender, System.ResolveEventArgs e, System.AsyncCallback callback, object object) {}
	public virtual Module EndInvoke(System.IAsyncResult result) {}
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

