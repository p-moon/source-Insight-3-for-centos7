public class RequestCachingSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public RequestCachingSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HttpCachePolicyElement DefaultHttpCachePolicy { get{} }
	public FtpCachePolicyElement DefaultFtpCachePolicy { get{} }
	public System.Net.Cache.RequestCacheLevel DefaultPolicyLevel { get{} set{} }
	public bool DisableAllCaching { get{} set{} }
	public bool IsPrivateCache { get{} set{} }
	public System.TimeSpan UnspecifiedMaximumAge { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

