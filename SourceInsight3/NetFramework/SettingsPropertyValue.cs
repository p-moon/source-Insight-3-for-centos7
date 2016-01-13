public class SettingsPropertyValue
{

	// Constructors
	public SettingsPropertyValue(SettingsProperty property) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public bool IsDirty { get{} set{} }
	public SettingsProperty Property { get{} }
	public bool UsingDefaultValue { get{} }
	public object PropertyValue { get{} set{} }
	public object SerializedValue { get{} set{} }
	public bool Deserialized { get{} set{} }
}

