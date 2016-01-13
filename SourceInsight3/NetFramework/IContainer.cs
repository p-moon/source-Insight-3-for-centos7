public interface IContainer : System.IDisposable
{

	// Methods
	public abstract virtual void Add(IComponent component) {}
	public abstract virtual void Add(IComponent component, string name) {}
	public abstract virtual void Remove(IComponent component) {}

	// Properties
	public ComponentCollection Components { get{} }
}

