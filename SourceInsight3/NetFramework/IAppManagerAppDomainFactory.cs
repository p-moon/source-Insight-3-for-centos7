public interface IAppManagerAppDomainFactory
{

	// Methods
	public abstract virtual object Create(string appId, string appPath) {}
	public abstract virtual void Stop() {}
}

