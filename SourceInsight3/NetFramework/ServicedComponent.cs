public class ServicedComponent : System.ContextBoundObject, IRemoteDispatch, System.IDisposable, IManagedObject, IServicedComponentInfo
{

	// Constructors
	public ServicedComponent() {}

	// Methods
	public static void DisposeObject(ServicedComponent sc) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

