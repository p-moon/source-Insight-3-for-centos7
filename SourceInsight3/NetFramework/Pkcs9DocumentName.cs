public class Pkcs9DocumentName : Pkcs9AttributeObject
{

	// Constructors
	public Pkcs9DocumentName() {}
	public Pkcs9DocumentName(string documentName) {}
	public Pkcs9DocumentName(byte[] encodedDocumentName) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DocumentName { get{} }
	public System.Security.Cryptography.Oid Oid { get{} }
	public byte[] RawData { get{} set{} }
}

