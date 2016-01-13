public class MessageQueueEnumerator : System.MarshalByRefObject, System.Collections.IEnumerator, System.IDisposable
{

	// Methods
	public void Close() {}
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public virtual void Reset() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessageQueue Current { get{} }
	public System.IntPtr LocatorHandle { get{} }
}

