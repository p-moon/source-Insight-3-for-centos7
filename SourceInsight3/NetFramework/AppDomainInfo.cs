public class AppDomainInfo : IAppDomainInfo
{

	// Methods
	public virtual string GetId() {}
	public virtual string GetVirtualPath() {}
	public virtual string GetPhysicalPath() {}
	public virtual int GetSiteId() {}
	public virtual bool IsIdle() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

