public class ProfilePropertySettings : System.Configuration.ConfigurationElement
{

	// Constructors
	public ProfilePropertySettings(string name) {}
	public ProfilePropertySettings(string name, bool readOnly, SerializationMode serializeAs, string providerName, string defaultValue, string profileType, bool allowAnonymous, string customProviderData) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public SerializationMode SerializeAs { get{} set{} }
	public string Provider { get{} set{} }
	public string DefaultValue { get{} set{} }
	public string Type { get{} set{} }
	public bool AllowAnonymous { get{} set{} }
	public string CustomProviderData { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

