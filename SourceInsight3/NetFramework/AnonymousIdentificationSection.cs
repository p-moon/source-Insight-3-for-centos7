public class AnonymousIdentificationSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public AnonymousIdentificationSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Enabled { get{} set{} }
	public string CookieName { get{} set{} }
	public System.TimeSpan CookieTimeout { get{} set{} }
	public string CookiePath { get{} set{} }
	public bool CookieRequireSSL { get{} set{} }
	public bool CookieSlidingExpiration { get{} set{} }
	public System.Web.Security.CookieProtection CookieProtection { get{} set{} }
	public System.Web.HttpCookieMode Cookieless { get{} set{} }
	public string Domain { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

