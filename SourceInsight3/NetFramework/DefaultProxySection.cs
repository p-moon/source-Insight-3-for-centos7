public class DefaultProxySection : System.Configuration.ConfigurationSection
{

	// Constructors
	public DefaultProxySection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public BypassElementCollection BypassList { get{} }
	public ModuleElement Module { get{} }
	public ProxyElement Proxy { get{} }
	public bool Enabled { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

