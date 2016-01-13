public class SoapUtility : ISoapUtility
{

	// Constructors
	public SoapUtility() {}

	// Methods
	public virtual void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRootout , System.String& physicalPath) {}
	public virtual void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRootout , System.String& binPath) {}
	public virtual void Present() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

