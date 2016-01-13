public class SecureFactory : ISecureFactory2, ISecureFactory
{

	// Methods
	public void RemoteCreateInstance(System.Guid riidout , System.Object& ppvObject) {}
	public void RemoteLockServer(int fLock) {}
	public virtual object CreateInstanceWithSecurity(int dwFlag, int dwZone, string pURL, string uniqueIdString, string link, string licenses) {}
	public virtual object CreateInstanceWithSecurity2(int dwFlags, int dwZone, string wszSite, string wszId, string wszConfig, string wszLicenses, string wszDeploymentManifest) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

