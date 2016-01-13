public class RegistrationHelperTx : ServicedComponent, IRemoteDispatch, System.IDisposable, IManagedObject, IServicedComponentInfo
{

	// Constructors
	public RegistrationHelperTx() {}

	// Methods
	public void InstallAssembly(string assembly, System.String& application, System.String& tlb, InstallationFlags installFlags, object sync) {}
	public void InstallAssembly(string assembly, System.String& application, string partition, System.String& tlb, InstallationFlags installFlags, object sync) {}
	public void InstallAssemblyFromConfig(RegistrationConfig& regConfig, object sync) {}
	public void UninstallAssembly(string assembly, string application, object sync) {}
	public void UninstallAssembly(string assembly, string application, string partition, object sync) {}
	public void UninstallAssemblyFromConfig(RegistrationConfig& regConfig, object sync) {}
	public bool IsInTransaction() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

