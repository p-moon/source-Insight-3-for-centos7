public class HttpRuntime
{

	// Constructors
	public HttpRuntime() {}

	// Methods
	public static void ProcessRequest(HttpWorkerRequest wr) {}
	public static void Close() {}
	public static void UnloadAppDomain() {}
	public static System.Security.NamedPermissionSet GetNamedPermissionSet() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.Caching.Cache Cache { get{} }
	public string AspInstallDirectory { get{} }
	public string AspClientScriptVirtualPath { get{} }
	public string AspClientScriptPhysicalPath { get{} }
	public string ClrInstallDirectory { get{} }
	public string MachineConfigurationDirectory { get{} }
	public string CodegenDir { get{} }
	public string AppDomainAppId { get{} }
	public string AppDomainAppPath { get{} }
	public string AppDomainAppVirtualPath { get{} }
	public string AppDomainId { get{} }
	public string BinDirectory { get{} }
	public bool IsOnUNCShare { get{} }
}

