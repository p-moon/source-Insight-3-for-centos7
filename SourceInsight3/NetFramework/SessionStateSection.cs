public class SessionStateSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public SessionStateSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Web.SessionState.SessionStateMode Mode { get{} set{} }
	public string StateConnectionString { get{} set{} }
	public System.TimeSpan StateNetworkTimeout { get{} set{} }
	public string SqlConnectionString { get{} set{} }
	public System.TimeSpan SqlCommandTimeout { get{} set{} }
	public string CustomProvider { get{} set{} }
	public System.Web.HttpCookieMode Cookieless { get{} set{} }
	public string CookieName { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
	public bool AllowCustomSqlDatabase { get{} set{} }
	public bool RegenerateExpiredSessionId { get{} set{} }
	public System.Configuration.ProviderSettingsCollection Providers { get{} }
	public string PartitionResolverType { get{} set{} }
	public bool UseHostingIdentity { get{} set{} }
	public string SessionIDManagerType { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

