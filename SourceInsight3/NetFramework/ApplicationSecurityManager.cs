public class ApplicationSecurityManager
{

	// Methods
	public static bool DetermineApplicationTrust(System.ActivationContext activationContext, TrustManagerContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ApplicationTrustCollection UserApplicationTrusts { get{} }
	public IApplicationTrustManager ApplicationTrustManager { get{} }
}

