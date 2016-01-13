public class PublicKey
{

	// Constructors
	public PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.AsymmetricAlgorithm Key { get{} }
	public System.Security.Cryptography.Oid Oid { get{} }
	public System.Security.Cryptography.AsnEncodedData EncodedKeyValue { get{} }
	public System.Security.Cryptography.AsnEncodedData EncodedParameters { get{} }
}

