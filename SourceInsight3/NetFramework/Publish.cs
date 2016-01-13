public class Publish : IComSoapPublisher
{

	// Constructors
	public Publish() {}

	// Methods
	public virtual void RegisterAssembly(string AssemblyPath) {}
	public virtual void UnRegisterAssembly(string AssemblyPath) {}
	public virtual void GacInstall(string AssemblyPath) {}
	public virtual void GacRemove(string AssemblyPath) {}
	public virtual void GetAssemblyNameForCache(string TypeLibPathout , System.String& CachePath) {}
	public static string GetClientPhysicalPath(bool CreateDir) {}
	public static void ParseUrl(string FullUrlout , System.String& BaseUrlout , System.String& VirtualRoot) {}
	public virtual void CreateVirtualRoot(string Operation, string FullUrlout , System.String& BaseUrlout , System.String& VirtualRootout , System.String& PhysicalPathout , System.String& Error) {}
	public virtual void DeleteVirtualRoot(string RootWebServer, string FullUrlout , System.String& Error) {}
	public virtual void CreateMailBox(string RootMailServer, string MailBoxout , System.String& SmtpNameout , System.String& Domainout , System.String& PhysicalPathout , System.String& Error) {}
	public virtual void DeleteMailBox(string RootMailServer, string MailBoxout , System.String& Error) {}
	public virtual void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operationout , System.String& strAssemblyNameout , System.String& TypeNameout , System.String& Error) {}
	public virtual string GetTypeNameFromProgId(string AssemblyPath, string ProgId) {}
	public virtual void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transportout , System.String& AssemblyNameout , System.String& TypeNameout , System.String& Error) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

