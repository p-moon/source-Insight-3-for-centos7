public class ServerChannelSinkStack : IServerChannelSinkStack, IServerResponseChannelSinkStack
{

	// Constructors
	public ServerChannelSinkStack() {}

	// Methods
	public virtual void Push(IServerChannelSink sink, object state) {}
	public virtual object Pop(IServerChannelSink sink) {}
	public virtual void Store(IServerChannelSink sink, object state) {}
	public virtual void StoreAndDispatch(IServerChannelSink sink, object state) {}
	public virtual void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}
	public virtual void ServerCallback(System.IAsyncResult ar) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

