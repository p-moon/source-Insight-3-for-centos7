public interface IInheritanceService
{

	// Methods
	public abstract virtual void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) {}
	public abstract virtual System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component) {}
}

