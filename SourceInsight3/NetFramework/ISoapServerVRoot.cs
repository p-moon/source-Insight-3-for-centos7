public interface ISoapServerVRoot
{

	// Methods
	public abstract virtual void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operationout , System.String& baseUrlout , System.String& virtualRootout , System.String& physicalPath) {}
	public abstract virtual void DeleteVirtualRootEx(string rootWebServer, string baseUrl, string virtualRoot) {}
	public abstract virtual void GetVirtualRootStatus(string rootWebServer, string inBaseUrl, string inVirtualRootout , System.String& existsout , System.String& secureSocketsout , System.String& windowsAuthout , System.String& anonymousout , System.String& homePageout , System.String& discoFileout , System.String& physicalPathout , System.String& baseUrlout , System.String& virtualRoot) {}
}

