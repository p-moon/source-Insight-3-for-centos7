public class HealthMonitoringSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public HealthMonitoringSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.TimeSpan HeartbeatInterval { get{} set{} }
	public bool Enabled { get{} set{} }
	public BufferModesCollection BufferModes { get{} }
	public System.Configuration.ProviderSettingsCollection Providers { get{} }
	public ProfileSettingsCollection Profiles { get{} }
	public RuleSettingsCollection Rules { get{} }
	public EventMappingSettingsCollection EventMappings { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

