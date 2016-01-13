public class EnvelopedCms
{

	// Constructors
	public EnvelopedCms() {}
	public EnvelopedCms(ContentInfo contentInfo) {}
	public EnvelopedCms(SubjectIdentifierType recipientIdentifierType, ContentInfo contentInfo) {}
	public EnvelopedCms(ContentInfo contentInfo, AlgorithmIdentifier encryptionAlgorithm) {}
	public EnvelopedCms(SubjectIdentifierType recipientIdentifierType, ContentInfo contentInfo, AlgorithmIdentifier encryptionAlgorithm) {}

	// Methods
	public byte[] Encode() {}
	public void Decode(byte[] encodedMessage) {}
	public void Encrypt() {}
	public void Encrypt(CmsRecipient recipient) {}
	public void Encrypt(CmsRecipientCollection recipients) {}
	public void Decrypt() {}
	public void Decrypt(RecipientInfo recipientInfo) {}
	public void Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) {}
	public void Decrypt(RecipientInfo recipientInfo, System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public ContentInfo ContentInfo { get{} }
	public AlgorithmIdentifier ContentEncryptionAlgorithm { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get{} }
	public System.Security.Cryptography.CryptographicAttributeObjectCollection UnprotectedAttributes { get{} }
	public RecipientInfoCollection RecipientInfos { get{} }
}

