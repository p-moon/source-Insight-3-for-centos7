public interface ITypeDescriptorContext : System.IServiceProvider
{

	// Methods
	public abstract virtual bool OnComponentChanging() {}
	public abstract virtual void OnComponentChanged() {}

	// Properties
	public IContainer Container { get{} }
	public object Instance { get{} }
	public PropertyDescriptor PropertyDescriptor { get{} }
}

