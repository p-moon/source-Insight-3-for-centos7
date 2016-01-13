public class HostSecurityManager
{

	// Constructors
	public HostSecurityManager() {}

	// Methods
	public virtual System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence inputEvidence) {}
	public virtual System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly loadedAssembly, System.Security.Policy.Evidence inputEvidence) {}
	public virtual System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence applicationEvidence, System.Security.Policy.Evidence activatorEvidence, System.Security.Policy.TrustManagerContext context) {}
	public virtual PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HostSecurityManagerOptions Flags { get{} }
	public System.Security.Policy.PolicyLevel DomainPolicy { get{} }
}

