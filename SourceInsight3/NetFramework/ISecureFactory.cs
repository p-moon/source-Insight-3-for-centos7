public interface ISecureFactory
{

	// Methods
	public abstract virtual object CreateInstanceWithSecurity(int dwIdentityFlag, int dwZone, string lpSite, string lpId, string lpLink, string lpLicenses) {}
}

