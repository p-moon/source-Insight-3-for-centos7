public class SettingValueElement : ConfigurationElement
{

	// Constructors
	public SettingValueElement() {}

	// Methods
	public virtual bool Equals(object settingValue) {}
	public virtual int GetHashCode() {}
	public virtual bool IsReadOnly() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Xml.XmlNode ValueXml { get{} set{} }
	public ConfigurationLockCollection LockAttributes { get{} }
	public ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public ConfigurationLockCollection LockElements { get{} }
	public ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public ElementInformation ElementInformation { get{} }
}

