public class TimerProc : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public TimerProc(object object, System.IntPtr method) {}

	// Methods
	public virtual void Invoke(System.IntPtr hWnd, int msg, System.IntPtr wParam, System.IntPtr lParam) {}
	public virtual System.IAsyncResult BeginInvoke(System.IntPtr hWnd, int msg, System.IntPtr wParam, System.IntPtr lParam, System.AsyncCallback callback, object object) {}
	public virtual void EndInvoke(System.IAsyncResult result) {}
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

