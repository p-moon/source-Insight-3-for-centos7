public class ConnectionStringSettings : ConfigurationElement
{

	// Constructors
	public ConnectionStringSettings() {}
	public ConnectionStringSettings(string name, string connectionString) {}
	public ConnectionStringSettings(string name, string connectionString, string providerName) {}

	// Methods
	public virtual string ToString() {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public string Name { get{} set{} }
	public string ConnectionString { get{} set{} }
	public string ProviderName { get{} set{} }
	public ConfigurationLockCollection LockAttributes { get{} }
	public ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public ConfigurationLockCollection LockElements { get{} }
	public ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public ElementInformation ElementInformation { get{} }
}

