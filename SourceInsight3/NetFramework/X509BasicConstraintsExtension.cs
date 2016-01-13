public class X509BasicConstraintsExtension : X509Extension
{

	// Constructors
	public X509BasicConstraintsExtension() {}
	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) {}
	public X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical) {}

	// Methods
	public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CertificateAuthority { get{} }
	public bool HasPathLengthConstraint { get{} }
	public int PathLengthConstraint { get{} }
	public bool Critical { get{} set{} }
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}

