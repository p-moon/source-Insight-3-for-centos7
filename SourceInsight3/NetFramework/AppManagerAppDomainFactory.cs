public class AppManagerAppDomainFactory : IAppManagerAppDomainFactory
{

	// Constructors
	public AppManagerAppDomainFactory() {}

	// Methods
	public virtual object Create(string appId, string appPath) {}
	public virtual void Stop() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

