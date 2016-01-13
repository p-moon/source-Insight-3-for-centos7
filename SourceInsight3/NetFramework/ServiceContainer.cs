public class ServiceContainer : IServiceContainer, System.IServiceProvider, System.IDisposable
{

	// Constructors
	public ServiceContainer() {}
	public ServiceContainer(System.IServiceProvider parentProvider) {}

	// Methods
	public virtual void AddService(Type serviceType, object serviceInstance) {}
	public virtual void AddService(Type serviceType, object serviceInstance, bool promote) {}
	public virtual void AddService(Type serviceType, ServiceCreatorCallback callback) {}
	public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote) {}
	public virtual void Dispose() {}
	public virtual object GetService(Type serviceType) {}
	public virtual void RemoveService(Type serviceType) {}
	public virtual void RemoveService(Type serviceType, bool promote) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

