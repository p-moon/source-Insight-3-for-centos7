public interface IDesigner : System.IDisposable
{

	// Methods
	public abstract virtual void DoDefaultAction() {}
	public abstract virtual void Initialize(System.ComponentModel.IComponent component) {}

	// Properties
	public System.ComponentModel.IComponent Component { get{} }
	public DesignerVerbCollection Verbs { get{} }
}

