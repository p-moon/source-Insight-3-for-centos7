public class SoapServerFormatterSink : IServerChannelSink, IChannelSinkBase
{

	// Constructors
	public SoapServerFormatterSink(Protocol protocol, IServerChannelSink nextSink, IChannelReceiver receiver) {}

	// Methods
	public virtual ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, ITransportHeaders requestHeaders, System.IO.Stream requestStreamout , System.Runtime.Remoting.Messaging.IMessage& responseMsgout , ITransportHeaders& responseHeadersout , System.IO.Stream& responseStream) {}
	public virtual void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual System.IO.Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get{} set{} }
	public IServerChannelSink NextChannelSink { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

