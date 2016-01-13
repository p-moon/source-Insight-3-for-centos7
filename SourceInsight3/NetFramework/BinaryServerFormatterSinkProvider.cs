public class BinaryServerFormatterSinkProvider : IServerFormatterSinkProvider, IServerChannelSinkProvider
{

	// Constructors
	public BinaryServerFormatterSinkProvider() {}
	public BinaryServerFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) {}

	// Methods
	public virtual void GetChannelData(IChannelDataStore channelData) {}
	public virtual IServerChannelSink CreateSink(IChannelReceiver channel) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IServerChannelSinkProvider Next { get{} set{} }
	public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get{} set{} }
}

