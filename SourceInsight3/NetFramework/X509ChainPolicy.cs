public class X509ChainPolicy
{

	// Constructors
	public X509ChainPolicy() {}

	// Methods
	public void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.OidCollection ApplicationPolicy { get{} }
	public System.Security.Cryptography.OidCollection CertificatePolicy { get{} }
	public X509RevocationMode RevocationMode { get{} set{} }
	public X509RevocationFlag RevocationFlag { get{} set{} }
	public X509VerificationFlags VerificationFlags { get{} set{} }
	public System.DateTime VerificationTime { get{} set{} }
	public System.TimeSpan UrlRetrievalTimeout { get{} set{} }
	public X509Certificate2Collection ExtraStore { get{} }
}

