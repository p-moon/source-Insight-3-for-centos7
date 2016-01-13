public interface ISoapUtility
{

	// Methods
	public abstract virtual void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRootout , System.String& physicalPath) {}
	public abstract virtual void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRootout , System.String& binPath) {}
	public abstract virtual void Present() {}
}

