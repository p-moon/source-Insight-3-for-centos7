public interface IApplicationHost
{

	// Methods
	public abstract virtual System.IntPtr GetConfigToken() {}
	public abstract virtual string GetSiteName() {}
	public abstract virtual string GetSiteID() {}
	public abstract virtual string GetVirtualPath() {}
	public abstract virtual string GetPhysicalPath() {}
	public abstract virtual System.Web.Configuration.IConfigMapPathFactory GetConfigMapPathFactory() {}
	public abstract virtual void MessageReceived() {}
}

