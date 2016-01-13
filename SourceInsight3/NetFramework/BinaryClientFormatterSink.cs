public class BinaryClientFormatterSink : IClientFormatterSink, System.Runtime.Remoting.Messaging.IMessageSink, IClientChannelSink, IChannelSinkBase
{

	// Constructors
	public BinaryClientFormatterSink(IClientChannelSink nextSink) {}

	// Methods
	public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) {}
	public virtual void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders requestHeaders, System.IO.Stream requestStreamout , ITransportHeaders& responseHeadersout , System.IO.Stream& responseStream) {}
	public virtual void AsyncProcessRequest(IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, System.IO.Stream stream) {}
	public virtual System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, ITransportHeaders headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get{} }
	public IClientChannelSink NextChannelSink { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

