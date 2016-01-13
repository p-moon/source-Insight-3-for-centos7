public class InheritanceService : IInheritanceService, System.IDisposable
{

	// Constructors
	public InheritanceService() {}

	// Methods
	public virtual void Dispose() {}
	public virtual void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) {}
	public virtual System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

