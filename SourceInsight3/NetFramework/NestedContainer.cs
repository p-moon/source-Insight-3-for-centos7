public class NestedContainer : Container, IContainer, System.IDisposable, INestedContainer
{

	// Constructors
	public NestedContainer(IComponent owner) {}

	// Methods
	public virtual void Add(IComponent component) {}
	public virtual void Add(IComponent component, string name) {}
	public virtual void Dispose() {}
	public virtual void Remove(IComponent component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IComponent Owner { get{} }
	public ComponentCollection Components { get{} }
}

