public class AppDomainManager : MarshalByRefObject
{

	// Constructors
	public AppDomainManager() {}

	// Methods
	public virtual AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, AppDomainSetup appDomainInfo) {}
	public virtual void InitializeNewDomain(AppDomainSetup appDomainInfo) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AppDomainManagerInitializationOptions InitializationFlags { get{} set{} }
	public System.Runtime.Hosting.ApplicationActivator ApplicationActivator { get{} }
	public System.Security.HostSecurityManager HostSecurityManager { get{} }
	public System.Threading.HostExecutionContextManager HostExecutionContextManager { get{} }
	public System.Reflection.Assembly EntryAssembly { get{} }
}

