public interface IClientChannelSinkProvider
{

	// Methods
	public abstract virtual IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData) {}

	// Properties
	public IClientChannelSinkProvider Next { get{} set{} }
}

