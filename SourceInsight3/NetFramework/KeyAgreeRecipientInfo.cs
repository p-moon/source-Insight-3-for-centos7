public class KeyAgreeRecipientInfo : RecipientInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public SubjectIdentifierOrKey OriginatorIdentifierOrKey { get{} }
	public SubjectIdentifier RecipientIdentifier { get{} }
	public System.DateTime Date { get{} }
	public System.Security.Cryptography.CryptographicAttributeObject OtherKeyAttribute { get{} }
	public AlgorithmIdentifier KeyEncryptionAlgorithm { get{} }
	public byte[] EncryptedKey { get{} }
	public RecipientInfoType Type { get{} }
}

