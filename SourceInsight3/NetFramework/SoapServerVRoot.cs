public class SoapServerVRoot : ISoapServerVRoot
{

	// Constructors
	public SoapServerVRoot() {}

	// Methods
	public virtual void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operationout , System.String& baseUrlout , System.String& virtualRootout , System.String& physicalPath) {}
	public virtual void DeleteVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot) {}
	public virtual void GetVirtualRootStatus(string RootWebServer, string inBaseUrl, string inVirtualRootout , System.String& Existsout , System.String& SSLout , System.String& WindowsAuthout , System.String& Anonymousout , System.String& HomePageout , System.String& DiscoFileout , System.String& PhysicalPathout , System.String& BaseUrlout , System.String& VirtualRoot) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

