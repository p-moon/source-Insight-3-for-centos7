public class HostingEnvironment : System.MarshalByRefObject
{

	// Constructors
	public HostingEnvironment() {}

	// Methods
	public virtual object InitializeLifetimeService() {}
	public static void RegisterObject(IRegisteredObject obj) {}
	public static void UnregisterObject(IRegisteredObject obj) {}
	public static void IncrementBusyCount() {}
	public static void DecrementBusyCount() {}
	public static void MessageReceived() {}
	public static void InitiateShutdown() {}
	public static string MapPath(string virtualPath) {}
	public static System.IDisposable Impersonate() {}
	public static System.IDisposable Impersonate(System.IntPtr token) {}
	public static System.IDisposable Impersonate(System.IntPtr userToken, string virtualPath) {}
	public static System.IDisposable SetCultures() {}
	public static System.IDisposable SetCultures(string virtualPath) {}
	public static void RegisterVirtualPathProvider(VirtualPathProvider virtualPathProvider) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Exception InitializationException { get{} }
	public bool IsHosted { get{} }
	public IApplicationHost ApplicationHost { get{} }
	public string ApplicationID { get{} }
	public string ApplicationPhysicalPath { get{} }
	public string ApplicationVirtualPath { get{} }
	public string SiteName { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public System.Web.ApplicationShutdownReason ShutdownReason { get{} }
	public VirtualPathProvider VirtualPathProvider { get{} }
}

