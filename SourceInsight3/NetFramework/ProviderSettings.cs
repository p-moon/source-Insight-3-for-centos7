public class ProviderSettings : ConfigurationElement
{

	// Constructors
	public ProviderSettings() {}
	public ProviderSettings(string name, string type) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public string Type { get{} set{} }
	public System.Collections.Specialized.NameValueCollection Parameters { get{} }
	public ConfigurationLockCollection LockAttributes { get{} }
	public ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public ConfigurationLockCollection LockElements { get{} }
	public ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public ElementInformation ElementInformation { get{} }
}

