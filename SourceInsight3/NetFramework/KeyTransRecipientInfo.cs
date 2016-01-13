public class KeyTransRecipientInfo : RecipientInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public SubjectIdentifier RecipientIdentifier { get{} }
	public AlgorithmIdentifier KeyEncryptionAlgorithm { get{} }
	public byte[] EncryptedKey { get{} }
	public RecipientInfoType Type { get{} }
}

