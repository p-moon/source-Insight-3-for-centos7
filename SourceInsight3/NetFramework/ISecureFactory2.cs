public interface ISecureFactory2 : ISecureFactory
{

	// Methods
	public abstract virtual object CreateInstanceWithSecurity(int dwIdentityFlag, int dwZone, string lpSite, string lpId, string lpLink, string lpLicenses) {}
	public abstract virtual object CreateInstanceWithSecurity2(int dwFlags, int dwZone, string wszSite, string wszId, string wszConfig, string wszLicenses, string wszDeploymentManifest) {}
}

