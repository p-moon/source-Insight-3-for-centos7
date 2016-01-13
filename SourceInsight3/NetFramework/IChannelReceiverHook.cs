public interface IChannelReceiverHook
{

	// Methods
	public abstract virtual void AddHookChannelUri(string channelUri) {}

	// Properties
	public string ChannelScheme { get{} }
	public bool WantsToListen { get{} }
	public IServerChannelSink ChannelSinkChain { get{} }
}

