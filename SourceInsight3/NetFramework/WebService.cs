public class WebService : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider
{

	// Constructors
	public WebService() {}

	// Methods
	public virtual void Dispose() {}
	public virtual object GetService(Type service) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.HttpApplicationState Application { get{} }
	public System.Web.HttpContext Context { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Security.Principal.IPrincipal User { get{} }
	public System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }
	public bool DesignMode { get{} }

	// Events
	public event System.EventHandler Disposed;
}

