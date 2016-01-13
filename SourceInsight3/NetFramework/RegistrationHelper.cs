public class RegistrationHelper : System.MarshalByRefObject, IRegistrationHelper, System.EnterpriseServices.Thunk.IThunkInstallation
{

	// Constructors
	public RegistrationHelper() {}

	// Methods
	public virtual void InstallAssembly(string assembly, System.String& application, System.String& tlb, InstallationFlags installFlags) {}
	public void InstallAssembly(string assembly, System.String& application, string partition, System.String& tlb, InstallationFlags installFlags) {}
	public void InstallAssemblyFromConfig(RegistrationConfig& regConfig) {}
	public virtual void UninstallAssembly(string assembly, string application) {}
	public void UninstallAssembly(string assembly, string application, string partition) {}
	public void UninstallAssemblyFromConfig(RegistrationConfig& regConfig) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

