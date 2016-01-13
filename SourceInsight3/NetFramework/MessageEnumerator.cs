public class MessageEnumerator : System.MarshalByRefObject, System.Collections.IEnumerator, System.IDisposable
{

	// Methods
	public void Close() {}
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public bool MoveNext(System.TimeSpan timeout) {}
	public Message RemoveCurrent() {}
	public Message RemoveCurrent(MessageQueueTransaction transaction) {}
	public Message RemoveCurrent(MessageQueueTransactionType transactionType) {}
	public Message RemoveCurrent(System.TimeSpan timeout) {}
	public Message RemoveCurrent(System.TimeSpan timeout, MessageQueueTransaction transaction) {}
	public Message RemoveCurrent(System.TimeSpan timeout, MessageQueueTransactionType transactionType) {}
	public virtual void Reset() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Message Current { get{} }
	public System.IntPtr CursorHandle { get{} }
}

