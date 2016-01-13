public class AsyncResult : System.IAsyncResult, IMessageSink
{

	// Methods
	public virtual void SetMessageCtrl(IMessageCtrl mc) {}
	public virtual IMessage SyncProcessMessage(IMessage msg) {}
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) {}
	public virtual IMessage GetReplyMessage() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsCompleted { get{} }
	public object AsyncDelegate { get{} }
	public object AsyncState { get{} }
	public bool CompletedSynchronously { get{} }
	public bool EndInvokeCalled { get{} set{} }
	public System.Threading.WaitHandle AsyncWaitHandle { get{} }
	public IMessageSink NextSink { get{} }
}

