public class ProcessHost : System.MarshalByRefObject, IProcessHost, IAdphManager, IPphManager, IProcessHostIdleAndHealthCheck
{

	// Methods
	public virtual object InitializeLifetimeService() {}
	public virtual void StartProcessProtocolListenerChannel(string protocolId, IListenerChannelCallback listenerChannelCallback) {}
	public virtual void StopProcessProtocolListenerChannel(string protocolId, int listenerChannelId, bool immediate) {}
	public virtual void StopProcessProtocol(string protocolId, bool immediate) {}
	public virtual void StartAppDomainProtocolListenerChannel(string appId, string protocolId, IListenerChannelCallback listenerChannelCallback) {}
	public virtual void StopAppDomainProtocolListenerChannel(string appId, string protocolId, int listenerChannelId, bool immediate) {}
	public virtual void StopAppDomainProtocol(string appId, string protocolId, bool immediate) {}
	public virtual void StartApplication(string appId, string appPathout , System.Object& runtimeInterface) {}
	public virtual void ShutdownApplication(string appId) {}
	public virtual void Shutdown() {}
	public virtual void EnumerateAppDomains(out IAppDomainInfoEnum& appDomainInfoEnum) {}
	public virtual bool IsIdle() {}
	public virtual void Ping(IProcessPingCallback callback) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

