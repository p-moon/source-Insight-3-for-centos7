public class ChannelDataStore : IChannelDataStore
{

	// Constructors
	public ChannelDataStore(string[] channelURIs) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] ChannelUris { get{} set{} }
	public object Item { get{} set{} }
}

