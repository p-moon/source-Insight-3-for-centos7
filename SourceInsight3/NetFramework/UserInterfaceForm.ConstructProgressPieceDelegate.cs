public class ConstructProgressPieceDelegate : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ConstructProgressPieceDelegate(object object, System.IntPtr method) {}

	// Methods
	public virtual ProgressPiece Invoke(UserInterfaceInfo info) {}
	public virtual System.IAsyncResult BeginInvoke(UserInterfaceInfo info, System.AsyncCallback callback, object object) {}
	public virtual ProgressPiece EndInvoke(System.IAsyncResult result) {}
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

