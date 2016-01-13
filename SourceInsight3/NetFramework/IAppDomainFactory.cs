public interface IAppDomainFactory
{

	// Methods
	public abstract virtual object Create(string module, string typeName, string appId, string appPath, string strUrlOfAppOrigin, int iZone) {}
}

