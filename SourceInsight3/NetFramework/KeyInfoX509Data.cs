public class KeyInfoX509Data : KeyInfoClause
{

	// Constructors
	public KeyInfoX509Data() {}
	public KeyInfoX509Data(byte[] rgbCert) {}
	public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert) {}
	public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509IncludeOption includeOption) {}

	// Methods
	public void AddCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) {}
	public void AddSubjectKeyId(byte[] subjectKeyId) {}
	public void AddSubjectKeyId(string subjectKeyId) {}
	public void AddSubjectName(string subjectName) {}
	public void AddIssuerSerial(string issuerName, string serialNumber) {}
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement element) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ArrayList Certificates { get{} }
	public System.Collections.ArrayList SubjectKeyIds { get{} }
	public System.Collections.ArrayList SubjectNames { get{} }
	public System.Collections.ArrayList IssuerSerials { get{} }
	public byte[] CRL { get{} set{} }
}

