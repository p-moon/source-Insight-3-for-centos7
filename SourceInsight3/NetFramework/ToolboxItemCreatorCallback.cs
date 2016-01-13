public class ToolboxItemCreatorCallback : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ToolboxItemCreatorCallback(object object, System.IntPtr method) {}

	// Methods
	public virtual ToolboxItem Invoke(object serializedObject, string format) {}
	public virtual System.IAsyncResult BeginInvoke(object serializedObject, string format, System.AsyncCallback callback, object object) {}
	public virtual ToolboxItem EndInvoke(System.IAsyncResult result) {}
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

