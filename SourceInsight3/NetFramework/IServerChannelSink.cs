public interface IServerChannelSink : IChannelSinkBase
{

	// Methods
	public abstract virtual ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, ITransportHeaders requestHeaders, System.IO.Stream requestStreamout , System.Runtime.Remoting.Messaging.IMessage& responseMsgout , ITransportHeaders& responseHeadersout , System.IO.Stream& responseStream) {}
	public abstract virtual void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public abstract virtual System.IO.Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}

	// Properties
	public IServerChannelSink NextChannelSink { get{} }
}

