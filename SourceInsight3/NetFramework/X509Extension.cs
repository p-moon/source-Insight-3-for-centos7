public class X509Extension : System.Security.Cryptography.AsnEncodedData
{

	// Constructors
	public X509Extension(string oid, byte[] rawData, bool critical) {}
	public X509Extension(System.Security.Cryptography.AsnEncodedData encodedExtension, bool critical) {}
	public X509Extension(System.Security.Cryptography.Oid oid, byte[] rawData, bool critical) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Critical { get{} set{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

