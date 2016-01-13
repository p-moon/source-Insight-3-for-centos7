public class ProfileSettings : System.Configuration.ConfigurationElement
{

	// Constructors
	public ProfileSettings(string name) {}
	public ProfileSettings(string name, int minInstances, int maxLimit, System.TimeSpan minInterval) {}
	public ProfileSettings(string name, int minInstances, int maxLimit, System.TimeSpan minInterval, string custom) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public int MinInstances { get{} set{} }
	public int MaxLimit { get{} set{} }
	public System.TimeSpan MinInterval { get{} set{} }
	public string Custom { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

