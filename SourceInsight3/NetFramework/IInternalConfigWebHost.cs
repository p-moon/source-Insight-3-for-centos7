public interface IInternalConfigWebHost
{

	// Methods
	public abstract virtual void GetSiteIDAndVPathFromConfigPath(string configPathout , System.String& siteIDout , System.String& vpath) {}
	public abstract virtual string GetConfigPathFromSiteIDAndVPath(string siteID, string vpath) {}
}

