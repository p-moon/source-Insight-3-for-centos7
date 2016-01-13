public interface IComNativeDescriptorHandler
{

	// Methods
	public abstract virtual AttributeCollection GetAttributes(object component) {}
	public abstract virtual string GetClassName(object component) {}
	public abstract virtual TypeConverter GetConverter(object component) {}
	public abstract virtual EventDescriptor GetDefaultEvent(object component) {}
	public abstract virtual PropertyDescriptor GetDefaultProperty(object component) {}
	public abstract virtual object GetEditor(object component, Type baseEditorType) {}
	public abstract virtual string GetName(object component) {}
	public abstract virtual EventDescriptorCollection GetEvents(object component) {}
	public abstract virtual EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes) {}
	public abstract virtual PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) {}
	public abstract virtual object GetPropertyValue(object component, string propertyName, System.Boolean& success) {}
	public abstract virtual object GetPropertyValue(object component, int dispid, System.Boolean& success) {}
}

