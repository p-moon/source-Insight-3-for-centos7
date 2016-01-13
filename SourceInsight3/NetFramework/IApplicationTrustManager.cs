public interface IApplicationTrustManager : System.Security.ISecurityEncodable
{

	// Methods
	public abstract virtual ApplicationTrust DetermineApplicationTrust(System.ActivationContext activationContext, TrustManagerContext context) {}
}

