public class HttpCachePolicyElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public HttpCachePolicyElement() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.TimeSpan MaximumAge { get{} set{} }
	public System.TimeSpan MaximumStale { get{} set{} }
	public System.TimeSpan MinimumFresh { get{} set{} }
	public System.Net.Cache.HttpRequestCacheLevel PolicyLevel { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

