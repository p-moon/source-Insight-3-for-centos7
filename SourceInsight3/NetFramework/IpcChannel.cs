public class IpcChannel : System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
{

	// Constructors
	public IpcChannel() {}
	public IpcChannel(string portName) {}
	public IpcChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) {}

	// Methods
	public virtual string Parse(string urlout , System.String& objectURI) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelDataout , System.String& objectURI) {}
	public virtual string[] GetUrlsForUri(string objectURI) {}
	public virtual void StartListening(object data) {}
	public virtual void StopListening(object data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSecured { get{} set{} }
	public int ChannelPriority { get{} }
	public string ChannelName { get{} }
	public object ChannelData { get{} }
}

