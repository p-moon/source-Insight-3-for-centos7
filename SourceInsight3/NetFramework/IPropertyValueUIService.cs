public interface IPropertyValueUIService
{

	// Methods
	public abstract virtual void AddPropertyValueUIHandler(PropertyValueUIHandler newHandler) {}
	public abstract virtual PropertyValueUIItem[] GetPropertyUIValueItems(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc) {}
	public abstract virtual void NotifyPropertyValueUIItemsChanged() {}
	public abstract virtual void RemovePropertyValueUIHandler(PropertyValueUIHandler newHandler) {}

	// Events
	public event System.EventHandler PropertyUIValueItemsChanged;
}

