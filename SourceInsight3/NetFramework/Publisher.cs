public class Publisher : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public Publisher(System.Security.Cryptography.X509Certificates.X509Certificate cert) {}

	// Methods
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get{} }
}

