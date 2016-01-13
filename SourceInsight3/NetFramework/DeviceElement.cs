public class DeviceElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public DeviceElement(string name, string inheritsFrom) {}
	public DeviceElement(string name, Type predicateClass, string predicateMethod, Type pageAdapter) {}
	public DeviceElement(string name, string inheritsFrom, Type predicateClass, string predicateMethod, Type pageAdapter) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public string InheritsFrom { get{} set{} }
	public Type PredicateClass { get{} set{} }
	public string PredicateMethod { get{} set{} }
	public Type PageAdapter { get{} set{} }
	public ControlElementCollection Controls { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

