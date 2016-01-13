public class SignerInfo
{

	// Methods
	public void ComputeCounterSignature() {}
	public void ComputeCounterSignature(CmsSigner signer) {}
	public void RemoveCounterSignature(int index) {}
	public void RemoveCounterSignature(SignerInfo counterSignerInfo) {}
	public void CheckSignature(bool verifySignatureOnly) {}
	public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) {}
	public void CheckHash() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get{} }
	public SubjectIdentifier SignerIdentifier { get{} }
	public System.Security.Cryptography.Oid DigestAlgorithm { get{} }
	public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { get{} }
	public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { get{} }
	public SignerInfoCollection CounterSignerInfos { get{} }
}

