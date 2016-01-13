public interface IAdphManager
{

	// Methods
	public abstract virtual void StartAppDomainProtocolListenerChannel(string appId, string protocolId, IListenerChannelCallback listenerChannelCallback) {}
	public abstract virtual void StopAppDomainProtocolListenerChannel(string appId, string protocolId, int listenerChannelId, bool immediate) {}
	public abstract virtual void StopAppDomainProtocol(string appId, string protocolId, bool immediate) {}
}

