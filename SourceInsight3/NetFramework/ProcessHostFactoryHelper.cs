public class ProcessHostFactoryHelper : System.MarshalByRefObject, IProcessHostFactoryHelper
{

	// Constructors
	public ProcessHostFactoryHelper() {}

	// Methods
	public virtual object GetProcessHost(IProcessHostSupportFunctions functions) {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

