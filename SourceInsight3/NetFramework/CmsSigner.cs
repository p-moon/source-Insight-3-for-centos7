public class CmsSigner
{

	// Constructors
	public CmsSigner() {}
	public CmsSigner(SubjectIdentifierType signerIdentifierType) {}
	public CmsSigner(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) {}
	public CmsSigner(System.Security.Cryptography.CspParameters parameters) {}
	public CmsSigner(SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SubjectIdentifierType SignerIdentifierType { get{} set{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get{} set{} }
	public System.Security.Cryptography.Oid DigestAlgorithm { get{} set{} }
	public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { get{} }
	public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get{} }
	public System.Security.Cryptography.X509Certificates.X509IncludeOption IncludeOption { get{} set{} }
}

