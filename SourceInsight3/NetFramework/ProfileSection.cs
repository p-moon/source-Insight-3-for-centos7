public class ProfileSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public ProfileSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AutomaticSaveEnabled { get{} set{} }
	public bool Enabled { get{} set{} }
	public string DefaultProvider { get{} set{} }
	public string Inherits { get{} set{} }
	public System.Configuration.ProviderSettingsCollection Providers { get{} }
	public RootProfilePropertySettingsCollection PropertySettings { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

