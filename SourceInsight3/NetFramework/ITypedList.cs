public interface ITypedList
{

	// Methods
	public abstract virtual string GetListName(PropertyDescriptor[] listAccessors) {}
	public abstract virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) {}
}

