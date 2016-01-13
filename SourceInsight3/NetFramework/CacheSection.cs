public class CacheSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public CacheSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool DisableMemoryCollection { get{} set{} }
	public bool DisableExpiration { get{} set{} }
	public long PrivateBytesLimit { get{} set{} }
	public int PercentagePhysicalMemoryUsedLimit { get{} set{} }
	public System.TimeSpan PrivateBytesPollTime { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

