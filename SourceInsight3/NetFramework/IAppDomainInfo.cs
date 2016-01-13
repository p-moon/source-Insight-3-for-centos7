public interface IAppDomainInfo
{

	// Methods
	public abstract virtual string GetId() {}
	public abstract virtual string GetVirtualPath() {}
	public abstract virtual string GetPhysicalPath() {}
	public abstract virtual int GetSiteId() {}
	public abstract virtual bool IsIdle() {}
}

