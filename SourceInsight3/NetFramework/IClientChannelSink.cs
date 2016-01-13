public interface IClientChannelSink : IChannelSinkBase
{

	// Methods
	public abstract virtual void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders requestHeaders, System.IO.Stream requestStreamout , ITransportHeaders& responseHeadersout , System.IO.Stream& responseStream) {}
	public abstract virtual void AsyncProcessRequest(IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public abstract virtual void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, System.IO.Stream stream) {}
	public abstract virtual System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}

	// Properties
	public IClientChannelSink NextChannelSink { get{} }
}

