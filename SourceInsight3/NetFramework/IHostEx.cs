public interface IHostEx
{

	// Methods
	public abstract virtual ISecureFactory GetSecuredClassFactory(int dwIdentityFlags, int dwZone, string lpSite, string pbSecurityId, string lpHash, string className, string fileName) {}
	public abstract virtual ISecureFactory GetClassFactory(string className, string fileName) {}
}

