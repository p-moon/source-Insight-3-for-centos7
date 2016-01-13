public interface IBindableComponent : System.ComponentModel.IComponent, System.IDisposable
{

	// Properties
	public ControlBindingsCollection DataBindings { get{} }
	public BindingContext BindingContext { get{} set{} }
}

