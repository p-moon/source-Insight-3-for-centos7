public class SdlChannelSink : System.Runtime.Remoting.Channels.IServerChannelSink, System.Runtime.Remoting.Channels.IChannelSinkBase
{

	// Constructors
	public SdlChannelSink(System.Runtime.Remoting.Channels.IChannelReceiver receiver, System.Runtime.Remoting.Channels.IServerChannelSink nextSink) {}

	// Methods
	public virtual System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStreamout , System.Runtime.Remoting.Messaging.IMessage& responseMsgout , System.Runtime.Remoting.Channels.ITransportHeaders& responseHeadersout , System.IO.Stream& responseStream) {}
	public virtual void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

