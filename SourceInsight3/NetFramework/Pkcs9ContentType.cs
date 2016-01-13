public class Pkcs9ContentType : Pkcs9AttributeObject
{

	// Constructors
	public Pkcs9ContentType() {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.Oid ContentType { get{} }
	public System.Security.Cryptography.Oid Oid { get{} }
	public byte[] RawData { get{} set{} }
}

