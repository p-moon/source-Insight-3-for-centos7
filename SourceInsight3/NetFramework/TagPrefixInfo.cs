public class TagPrefixInfo : System.Configuration.ConfigurationElement
{

	// Constructors
	public TagPrefixInfo(string tagPrefix, string nameSpace, string assembly, string tagName, string source) {}

	// Methods
	public virtual bool Equals(object prefix) {}
	public virtual int GetHashCode() {}
	public virtual bool IsReadOnly() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string TagPrefix { get{} set{} }
	public string TagName { get{} set{} }
	public string Namespace { get{} set{} }
	public string Assembly { get{} set{} }
	public string Source { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

