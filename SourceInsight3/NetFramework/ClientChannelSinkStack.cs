public class ClientChannelSinkStack : IClientChannelSinkStack, IClientResponseChannelSinkStack
{

	// Constructors
	public ClientChannelSinkStack() {}
	public ClientChannelSinkStack(System.Runtime.Remoting.Messaging.IMessageSink replySink) {}

	// Methods
	public virtual void Push(IClientChannelSink sink, object state) {}
	public virtual object Pop(IClientChannelSink sink) {}
	public virtual void AsyncProcessResponse(ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg) {}
	public virtual void DispatchException(System.Exception e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

