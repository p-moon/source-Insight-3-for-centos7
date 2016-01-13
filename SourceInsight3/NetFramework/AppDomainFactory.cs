public class AppDomainFactory : IAppDomainFactory
{

	// Constructors
	public AppDomainFactory() {}

	// Methods
	public virtual object Create(string module, string typeName, string appId, string appPath, string strUrlOfAppOrigin, int iZone) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

