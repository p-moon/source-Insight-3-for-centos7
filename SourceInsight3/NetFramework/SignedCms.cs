public class SignedCms
{

	// Constructors
	public SignedCms() {}
	public SignedCms(SubjectIdentifierType signerIdentifierType) {}
	public SignedCms(ContentInfo contentInfo) {}
	public SignedCms(SubjectIdentifierType signerIdentifierType, ContentInfo contentInfo) {}
	public SignedCms(ContentInfo contentInfo, bool detached) {}
	public SignedCms(SubjectIdentifierType signerIdentifierType, ContentInfo contentInfo, bool detached) {}

	// Methods
	public byte[] Encode() {}
	public void Decode(byte[] encodedMessage) {}
	public void ComputeSignature() {}
	public void ComputeSignature(CmsSigner signer) {}
	public void ComputeSignature(CmsSigner signer, bool silent) {}
	public void RemoveSignature(int index) {}
	public void RemoveSignature(SignerInfo signerInfo) {}
	public void CheckSignature(bool verifySignatureOnly) {}
	public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) {}
	public void CheckHash() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public ContentInfo ContentInfo { get{} }
	public bool Detached { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get{} }
	public SignerInfoCollection SignerInfos { get{} }
}

