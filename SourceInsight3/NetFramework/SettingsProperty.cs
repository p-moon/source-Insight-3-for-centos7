public class SettingsProperty
{

	// Constructors
	public SettingsProperty(string name) {}
	public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing) {}
	public SettingsProperty(SettingsProperty propertyToCopy) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public bool IsReadOnly { get{} set{} }
	public object DefaultValue { get{} set{} }
	public Type PropertyType { get{} set{} }
	public SettingsSerializeAs SerializeAs { get{} set{} }
	public SettingsProvider Provider { get{} set{} }
	public SettingsAttributeDictionary Attributes { get{} }
	public bool ThrowOnErrorDeserializing { get{} set{} }
	public bool ThrowOnErrorSerializing { get{} set{} }
}

