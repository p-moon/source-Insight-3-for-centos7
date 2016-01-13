public interface IServiceContainer : System.IServiceProvider
{

	// Methods
	public abstract virtual void AddService(Type serviceType, object serviceInstance) {}
	public abstract virtual void AddService(Type serviceType, object serviceInstance, bool promote) {}
	public abstract virtual void AddService(Type serviceType, ServiceCreatorCallback callback) {}
	public abstract virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote) {}
	public abstract virtual void RemoveService(Type serviceType) {}
	public abstract virtual void RemoveService(Type serviceType, bool promote) {}
}

