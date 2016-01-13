public class SettingElement : ConfigurationElement
{

	// Constructors
	public SettingElement() {}
	public SettingElement(string name, SettingsSerializeAs serializeAs) {}

	// Methods
	public virtual bool Equals(object settings) {}
	public virtual int GetHashCode() {}
	public virtual bool IsReadOnly() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public SettingsSerializeAs SerializeAs { get{} set{} }
	public SettingValueElement Value { get{} set{} }
	public ConfigurationLockCollection LockAttributes { get{} }
	public ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public ConfigurationLockCollection LockElements { get{} }
	public ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public ElementInformation ElementInformation { get{} }
}

