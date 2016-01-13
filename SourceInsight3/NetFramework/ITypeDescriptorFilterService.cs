public interface ITypeDescriptorFilterService
{

	// Methods
	public abstract virtual bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes) {}
	public abstract virtual bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events) {}
	public abstract virtual bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties) {}
}

