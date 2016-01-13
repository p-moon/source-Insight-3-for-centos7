public class MarshalByValueComponent : IComponent, System.IDisposable, System.IServiceProvider
{

	// Constructors
	public MarshalByValueComponent() {}

	// Methods
	public virtual void Dispose() {}
	public virtual object GetService(Type service) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ISite Site { get{} set{} }
	public IContainer Container { get{} }
	public bool DesignMode { get{} }

	// Events
	public event System.EventHandler Disposed;
}

