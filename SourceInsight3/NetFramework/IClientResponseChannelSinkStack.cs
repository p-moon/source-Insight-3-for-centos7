public interface IClientResponseChannelSinkStack
{

	// Methods
	public abstract virtual void AsyncProcessResponse(ITransportHeaders headers, System.IO.Stream stream) {}
	public abstract virtual void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg) {}
	public abstract virtual void DispatchException(System.Exception e) {}
}

