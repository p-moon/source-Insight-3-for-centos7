public interface IProcessHostSupportFunctions
{

	// Methods
	public abstract virtual System.IntPtr GetConfigToken(string appId) {}
	public abstract virtual string GetRootWebConfigFilename() {}
	public abstract virtual System.IntPtr GetNativeConfigurationSystem() {}
	public abstract virtual void GetApplicationProperties(string appIdout , System.String& virtualPathout , System.String& physicalPathout , System.String& siteNameout , System.String& siteId) {}
	public abstract virtual void MapPath(string appId, string virtualPathout , System.String& physicalPath) {}
	public abstract virtual string GetAppHostConfigFilename() {}
}

