public class X509KeyUsageExtension : X509Extension
{

	// Constructors
	public X509KeyUsageExtension() {}
	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical) {}
	public X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509KeyUsageFlags KeyUsages { get{} }
	public bool Critical { get{} set{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

