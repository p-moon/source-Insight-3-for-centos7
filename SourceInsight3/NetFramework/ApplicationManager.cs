public class ApplicationManager : System.MarshalByRefObject
{

	// Methods
	public void Open() {}
	public virtual object InitializeLifetimeService() {}
	public static ApplicationManager GetApplicationManager() {}
	public void Close() {}
	public IRegisteredObject CreateObject(IApplicationHost appHost, Type type) {}
	public IRegisteredObject CreateObject(string appId, Type type, string virtualPath, string physicalPath, bool failIfExists) {}
	public IRegisteredObject CreateObject(string appId, Type type, string virtualPath, string physicalPath, bool failIfExists, bool throwOnError) {}
	public IRegisteredObject GetObject(string appId, Type type) {}
	public void StopObject(string appId, Type type) {}
	public bool IsIdle() {}
	public void ShutdownApplication(string appId) {}
	public void ShutdownAll() {}
	public ApplicationInfo[] GetRunningApplications() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

