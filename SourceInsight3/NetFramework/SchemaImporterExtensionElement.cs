public class SchemaImporterExtensionElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public SchemaImporterExtensionElement() {}
	public SchemaImporterExtensionElement(string name, string type) {}
	public SchemaImporterExtensionElement(string name, Type type) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public Type Type { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

