public class Pkcs9SigningTime : Pkcs9AttributeObject
{

	// Constructors
	public Pkcs9SigningTime() {}
	public Pkcs9SigningTime(System.DateTime signingTime) {}
	public Pkcs9SigningTime(byte[] encodedSigningTime) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime SigningTime { get{} }
	public System.Security.Cryptography.Oid Oid { get{} }
	public byte[] RawData { get{} set{} }
}

