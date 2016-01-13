public class OutputCacheProfile : System.Configuration.ConfigurationElement
{

	// Constructors
	public OutputCacheProfile(string name) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public bool Enabled { get{} set{} }
	public int Duration { get{} set{} }
	public System.Web.UI.OutputCacheLocation Location { get{} set{} }
	public string SqlDependency { get{} set{} }
	public string VaryByCustom { get{} set{} }
	public string VaryByControl { get{} set{} }
	public string VaryByContentEncoding { get{} set{} }
	public string VaryByHeader { get{} set{} }
	public string VaryByParam { get{} set{} }
	public bool NoStore { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

