public class Converter<TInput,TOutput> : MulticastDelegate, ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public Converter(object object, IntPtr method) {}

	// Methods
	public virtual TOutput Invoke(TInput input) {}
	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) {}
	public virtual TOutput EndInvoke(IAsyncResult result) {}
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

