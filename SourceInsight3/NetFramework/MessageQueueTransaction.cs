public class MessageQueueTransaction : System.IDisposable
{

	// Constructors
	public MessageQueueTransaction() {}

	// Methods
	public void Abort() {}
	public void Begin() {}
	public void Commit() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessageQueueTransactionStatus Status { get{} }
}

