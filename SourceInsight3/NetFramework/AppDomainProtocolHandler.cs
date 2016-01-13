public class AppDomainProtocolHandler : System.MarshalByRefObject, IRegisteredObject
{

	// Methods
	public virtual object InitializeLifetimeService() {}
	public abstract virtual void StartListenerChannel(IListenerChannelCallback listenerChannelCallback) {}
	public abstract virtual void StopListenerChannel(int listenerChannelId, bool immediate) {}
	public abstract virtual void StopProtocol(bool immediate) {}
	public virtual void Stop(bool immediate) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

