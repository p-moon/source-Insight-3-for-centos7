public interface IComSoapPublisher
{

	// Methods
	public abstract virtual void CreateVirtualRoot(string Operation, string FullUrlout , System.String& BaseUrlout , System.String& VirtualRootout , System.String& PhysicalPathout , System.String& Error) {}
	public abstract virtual void DeleteVirtualRoot(string RootWebServer, string FullUrlout , System.String& Error) {}
	public abstract virtual void CreateMailBox(string RootMailServer, string MailBoxout , System.String& SmtpNameout , System.String& Domainout , System.String& PhysicalPathout , System.String& Error) {}
	public abstract virtual void DeleteMailBox(string RootMailServer, string MailBoxout , System.String& Error) {}
	public abstract virtual void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operationout , System.String& AssemblyNameout , System.String& TypeNameout , System.String& Error) {}
	public abstract virtual void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transportout , System.String& AssemblyNameout , System.String& TypeNameout , System.String& Error) {}
	public abstract virtual string GetTypeNameFromProgId(string AssemblyPath, string ProgId) {}
	public abstract virtual void RegisterAssembly(string AssemblyPath) {}
	public abstract virtual void UnRegisterAssembly(string AssemblyPath) {}
	public abstract virtual void GacInstall(string AssemblyPath) {}
	public abstract virtual void GacRemove(string AssemblyPath) {}
	public abstract virtual void GetAssemblyNameForCache(string TypeLibPathout , System.String& CachePath) {}
}

