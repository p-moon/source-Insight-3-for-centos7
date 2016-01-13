public class TcpClientChannel : System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.ISecurableChannel
{

	// Constructors
	public TcpClientChannel() {}
	public TcpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) {}
	public TcpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) {}

	// Methods
	public virtual string Parse(string urlout , System.String& objectURI) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelDataout , System.String& objectURI) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSecured { get{} set{} }
	public int ChannelPriority { get{} }
	public string ChannelName { get{} }
}

