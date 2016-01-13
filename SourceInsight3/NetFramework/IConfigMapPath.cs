public interface IConfigMapPath
{

	// Methods
	public abstract virtual string GetMachineConfigFilename() {}
	public abstract virtual string GetRootWebConfigFilename() {}
	public abstract virtual void GetPathConfigFilename(string siteID, string pathout , System.String& directoryout , System.String& baseName) {}
	public abstract virtual void GetDefaultSiteNameAndID(out System.String& siteNameout , System.String& siteID) {}
	public abstract virtual void ResolveSiteArgument(string siteArgumentout , System.String& siteNameout , System.String& siteID) {}
	public abstract virtual string MapPath(string siteID, string path) {}
	public abstract virtual string GetAppPathForPath(string siteID, string path) {}
}

