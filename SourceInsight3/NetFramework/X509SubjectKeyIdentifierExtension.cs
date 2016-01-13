public class X509SubjectKeyIdentifierExtension : X509Extension
{

	// Constructors
	public X509SubjectKeyIdentifierExtension() {}
	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) {}
	public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical) {}
	public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical) {}
	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical) {}
	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SubjectKeyIdentifier { get{} }
	public bool Critical { get{} set{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

