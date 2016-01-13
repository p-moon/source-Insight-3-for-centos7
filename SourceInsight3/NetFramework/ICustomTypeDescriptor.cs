public interface ICustomTypeDescriptor
{

	// Methods
	public abstract virtual AttributeCollection GetAttributes() {}
	public abstract virtual string GetClassName() {}
	public abstract virtual string GetComponentName() {}
	public abstract virtual TypeConverter GetConverter() {}
	public abstract virtual EventDescriptor GetDefaultEvent() {}
	public abstract virtual PropertyDescriptor GetDefaultProperty() {}
	public abstract virtual object GetEditor(Type editorBaseType) {}
	public abstract virtual EventDescriptorCollection GetEvents() {}
	public abstract virtual EventDescriptorCollection GetEvents(System.Attribute[] attributes) {}
	public abstract virtual PropertyDescriptorCollection GetProperties() {}
	public abstract virtual PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) {}
	public abstract virtual object GetPropertyOwner(PropertyDescriptor pd) {}
}

