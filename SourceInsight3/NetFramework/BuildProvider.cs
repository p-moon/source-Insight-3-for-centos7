public class BuildProvider : System.Configuration.ConfigurationElement
{

	// Constructors
	public BuildProvider(string extension, string type) {}

	// Methods
	public virtual bool Equals(object provider) {}
	public virtual int GetHashCode() {}
	public virtual bool IsReadOnly() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Extension { get{} set{} }
	public string Type { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

