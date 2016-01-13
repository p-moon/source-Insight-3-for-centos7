public interface IProcessInitializer
{

	// Methods
	public abstract virtual void Startup(object punkProcessControl) {}
	public abstract virtual void Shutdown() {}
}

