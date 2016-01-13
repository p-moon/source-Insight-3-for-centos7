public interface IProcessHost
{

	// Methods
	public abstract virtual void StartApplication(string appId, string appPathout , System.Object& runtimeInterface) {}
	public abstract virtual void ShutdownApplication(string appId) {}
	public abstract virtual void Shutdown() {}
	public abstract virtual void EnumerateAppDomains(out IAppDomainInfoEnum& appDomainInfoEnum) {}
}

