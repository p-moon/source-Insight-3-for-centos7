public class IpcServerChannel : System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.ISecurableChannel
{

	// Constructors
	public IpcServerChannel(string portName) {}
	public IpcServerChannel(string name, string portName) {}
	public IpcServerChannel(string name, string portName, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) {}
	public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) {}
	public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider, System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) {}

	// Methods
	public virtual string Parse(string urlout , System.String& objectURI) {}
	public string GetChannelUri() {}
	public virtual string[] GetUrlsForUri(string objectUri) {}
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

