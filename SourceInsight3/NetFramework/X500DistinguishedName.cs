public class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
{

	// Constructors
	public X500DistinguishedName(byte[] encodedDistinguishedName) {}
	public X500DistinguishedName(System.Security.Cryptography.AsnEncodedData encodedDistinguishedName) {}
	public X500DistinguishedName(X500DistinguishedName distinguishedName) {}
	public X500DistinguishedName(string distinguishedName) {}
	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag) {}

	// Methods
	public string Decode(X500DistinguishedNameFlags flag) {}
	public virtual string Format(bool multiLine) {}
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

