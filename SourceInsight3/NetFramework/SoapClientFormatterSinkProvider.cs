public class SoapClientFormatterSinkProvider : IClientFormatterSinkProvider, IClientChannelSinkProvider
{

	// Constructors
	public SoapClientFormatterSinkProvider() {}
	public SoapClientFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) {}

	// Methods
	public virtual IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IClientChannelSinkProvider Next { get{} set{} }
}

