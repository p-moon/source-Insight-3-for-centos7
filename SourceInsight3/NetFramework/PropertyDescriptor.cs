public class PropertyDescriptor : MemberDescriptor
{

	// Methods
	public virtual void AddValueChanged(object component, System.EventHandler handler) {}
	public abstract virtual bool CanResetValue(object component) {}
	public virtual bool Equals(object obj) {}
	public PropertyDescriptorCollection GetChildProperties() {}
	public PropertyDescriptorCollection GetChildProperties(System.Attribute[] filter) {}
	public PropertyDescriptorCollection GetChildProperties(object instance) {}
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, System.Attribute[] filter) {}
	public virtual object GetEditor(Type editorBaseType) {}
	public virtual int GetHashCode() {}
	public abstract virtual object GetValue(object component) {}
	public virtual void RemoveValueChanged(object component, System.EventHandler handler) {}
	public abstract virtual void ResetValue(object component) {}
	public abstract virtual void SetValue(object component, object value) {}
	public abstract virtual bool ShouldSerializeValue(object component) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ComponentType { get{} }
	public TypeConverter Converter { get{} }
	public bool IsLocalizable { get{} }
	public bool IsReadOnly { get{} }
	public DesignerSerializationVisibility SerializationVisibility { get{} }
	public Type PropertyType { get{} }
	public bool SupportsChangeEvents { get{} }
	public AttributeCollection Attributes { get{} }
	public string Category { get{} }
	public string Description { get{} }
	public bool IsBrowsable { get{} }
	public string Name { get{} }
	public bool DesignTimeOnly { get{} }
	public string DisplayName { get{} }
}

