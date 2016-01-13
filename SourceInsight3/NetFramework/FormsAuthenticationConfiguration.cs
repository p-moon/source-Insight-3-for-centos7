public class FormsAuthenticationConfiguration : System.Configuration.ConfigurationElement
{

	// Constructors
	public FormsAuthenticationConfiguration() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public FormsAuthenticationCredentials Credentials { get{} }
	public string Name { get{} set{} }
	public string LoginUrl { get{} set{} }
	public string DefaultUrl { get{} set{} }
	public FormsProtectionEnum Protection { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
	public string Path { get{} set{} }
	public bool RequireSSL { get{} set{} }
	public bool SlidingExpiration { get{} set{} }
	public bool EnableCrossAppRedirects { get{} set{} }
	public System.Web.HttpCookieMode Cookieless { get{} set{} }
	public string Domain { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

