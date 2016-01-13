public interface IPphManager
{

	// Methods
	public abstract virtual void StartProcessProtocolListenerChannel(string protocolId, IListenerChannelCallback listenerChannelCallback) {}
	public abstract virtual void StopProcessProtocolListenerChannel(string protocolId, int listenerChannelId, bool immediate) {}
	public abstract virtual void StopProcessProtocol(string protocolId, bool immediate) {}
}

