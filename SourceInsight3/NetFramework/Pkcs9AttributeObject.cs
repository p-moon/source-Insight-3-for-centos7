public class Pkcs9AttributeObject : System.Security.Cryptography.AsnEncodedData
{

	// Constructors
	public Pkcs9AttributeObject() {}
	public Pkcs9AttributeObject(string oid, byte[] encodedData) {}
	public Pkcs9AttributeObject(System.Security.Cryptography.Oid oid, byte[] encodedData) {}
	public Pkcs9AttributeObject(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.Oid Oid { get{} }
	public byte[] RawData { get{} set{} }
}

