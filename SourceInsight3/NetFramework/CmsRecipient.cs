public class CmsRecipient
{

	// Constructors
	public CmsRecipient(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) {}
	public CmsRecipient(SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SubjectIdentifierType RecipientIdentifierType { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get{} }
}

