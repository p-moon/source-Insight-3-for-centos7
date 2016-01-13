public class Pkcs9DocumentDescription : Pkcs9AttributeObject
{

	// Constructors
	public Pkcs9DocumentDescription() {}
	public Pkcs9DocumentDescription(string documentDescription) {}
	public Pkcs9DocumentDescription(byte[] encodedDocumentDescription) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DocumentDescription { get{} }
	public System.Security.Cryptography.Oid Oid { get{} }
	public byte[] RawData { get{} set{} }
}

