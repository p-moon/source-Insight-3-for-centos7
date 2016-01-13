public interface IServerChannelSinkProvider
{

	// Methods
	public abstract virtual void GetChannelData(IChannelDataStore channelData) {}
	public abstract virtual IServerChannelSink CreateSink(IChannelReceiver channel) {}

	// Properties
	public IServerChannelSinkProvider Next { get{} set{} }
}

