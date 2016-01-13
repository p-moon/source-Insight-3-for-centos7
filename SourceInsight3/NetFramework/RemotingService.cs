public class RemotingService : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public RemotingService() {}

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.HttpApplicationState Application { get{} }
	public System.Web.HttpContext Context { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Security.Principal.IPrincipal User { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

