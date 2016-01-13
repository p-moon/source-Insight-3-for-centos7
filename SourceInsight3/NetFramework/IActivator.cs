public interface IActivator
{

	// Methods
	public abstract virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg) {}

	// Properties
	public IActivator NextActivator { get{} set{} }
	public ActivatorLevel Level { get{} }
}

