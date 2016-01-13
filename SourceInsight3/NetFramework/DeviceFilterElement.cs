public class DeviceFilterElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public DeviceFilterElement(string name, Type filterClass, string method) {}
	public DeviceFilterElement(string name, string compareName, string argument) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} }
	public Type FilterClass { get{} set{} }
	public string Method { get{} set{} }
	public string Compare { get{} set{} }
	public string Argument { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

