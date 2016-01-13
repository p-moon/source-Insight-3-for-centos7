public interface IServerResponseChannelSinkStack
{

	// Methods
	public abstract virtual void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public abstract virtual System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}
}

