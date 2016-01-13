public class CustomTypeDescriptor : ICustomTypeDescriptor
{

	// Methods
	public virtual AttributeCollection GetAttributes() {}
	public virtual string GetClassName() {}
	public virtual string GetComponentName() {}
	public virtual TypeConverter GetConverter() {}
	public virtual EventDescriptor GetDefaultEvent() {}
	public virtual PropertyDescriptor GetDefaultProperty() {}
	public virtual object GetEditor(Type editorBaseType) {}
	public virtual EventDescriptorCollection GetEvents() {}
	public virtual EventDescriptorCollection GetEvents(System.Attribute[] attributes) {}
	public virtual PropertyDescriptorCollection GetProperties() {}
	public virtual PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) {}
	public virtual object GetPropertyOwner(PropertyDescriptor pd) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

