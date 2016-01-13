public class SoapExtensionTypeElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public SoapExtensionTypeElement() {}
	public SoapExtensionTypeElement(string type, int priority, PriorityGroup group) {}
	public SoapExtensionTypeElement(Type type, int priority, PriorityGroup group) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public PriorityGroup Group { get{} set{} }
	public int Priority { get{} set{} }
	public Type Type { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

