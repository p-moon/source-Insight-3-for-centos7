public class TreeViewCompareCallback : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public TreeViewCompareCallback(object object, System.IntPtr method) {}

	// Methods
	public virtual int Invoke(System.IntPtr lParam1, System.IntPtr lParam2, System.IntPtr lParamSort) {}
	public virtual System.IAsyncResult BeginInvoke(System.IntPtr lParam1, System.IntPtr lParam2, System.IntPtr lParamSort, System.AsyncCallback callback, object object) {}
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

