public class ProcessProtocolHandler : System.MarshalByRefObject
{

	// Methods
	public virtual object InitializeLifetimeService() {}
	public abstract virtual void StartListenerChannel(IListenerChannelCallback listenerChannelCallback, IAdphManager AdphManager) {}
	public abstract virtual void StopListenerChannel(int listenerChannelId, bool immediate) {}
	public abstract virtual void StopProtocol(bool immediate) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

