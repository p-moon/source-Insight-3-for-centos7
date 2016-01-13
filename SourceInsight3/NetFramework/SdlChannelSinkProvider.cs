public class SdlChannelSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider
{

	// Constructors
	public SdlChannelSinkProvider() {}
	public SdlChannelSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) {}

	// Methods
	public virtual void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore localChannelData) {}
	public virtual System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get{} set{} }
}

