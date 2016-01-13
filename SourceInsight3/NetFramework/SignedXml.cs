public class SignedXml
{

	// Constructors
	public SignedXml() {}
	public SignedXml(System.Xml.XmlDocument document) {}
	public SignedXml(System.Xml.XmlElement elem) {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public void AddReference(Reference reference) {}
	public void AddObject(DataObject dataObject) {}
	public bool CheckSignature() {}
	public bool CheckSignatureReturningKey(out System.Security.Cryptography.AsymmetricAlgorithm& signingKey) {}
	public bool CheckSignature(System.Security.Cryptography.AsymmetricAlgorithm key) {}
	public bool CheckSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) {}
	public bool CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, bool verifySignatureOnly) {}
	public void ComputeSignature() {}
	public void ComputeSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) {}
	public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string XmlDsigNamespaceUrl;
	public string XmlDsigMinimalCanonicalizationUrl;
	public string XmlDsigCanonicalizationUrl;
	public string XmlDsigCanonicalizationWithCommentsUrl;
	public string XmlDsigSHA1Url;
	public string XmlDsigDSAUrl;
	public string XmlDsigRSASHA1Url;
	public string XmlDsigHMACSHA1Url;
	public string XmlDsigC14NTransformUrl;
	public string XmlDsigC14NWithCommentsTransformUrl;
	public string XmlDsigExcC14NTransformUrl;
	public string XmlDsigExcC14NWithCommentsTransformUrl;
	public string XmlDsigBase64TransformUrl;
	public string XmlDsigXPathTransformUrl;
	public string XmlDsigXsltTransformUrl;
	public string XmlDsigEnvelopedSignatureTransformUrl;
	public string XmlDecryptionTransformUrl;
	public string XmlLicenseTransformUrl;

	// Properties
	public string SigningKeyName { get{} set{} }
	public System.Xml.XmlResolver Resolver { set{} }
	public System.Security.Cryptography.AsymmetricAlgorithm SigningKey { get{} set{} }
	public EncryptedXml EncryptedXml { get{} set{} }
	public Signature Signature { get{} }
	public SignedInfo SignedInfo { get{} }
	public string SignatureMethod { get{} }
	public string SignatureLength { get{} }
	public byte[] SignatureValue { get{} }
	public KeyInfo KeyInfo { get{} set{} }
}

