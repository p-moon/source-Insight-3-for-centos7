public class X509EnhancedKeyUsageExtension : X509Extension
{

	// Constructors
	public X509EnhancedKeyUsageExtension() {}
	public X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical) {}
	public X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.OidCollection EnhancedKeyUsages { get{} }
	public bool Critical { get{} set{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

