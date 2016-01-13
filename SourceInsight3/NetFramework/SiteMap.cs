public class SiteMap
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SiteMapNode CurrentNode { get{} }
	public bool Enabled { get{} }
	public SiteMapProvider Provider { get{} }
	public SiteMapProviderCollection Providers { get{} }
	public SiteMapNode RootNode { get{} }

	// Events
	public event System.Web.SiteMapResolveEventHandler SiteMapResolve;
}

