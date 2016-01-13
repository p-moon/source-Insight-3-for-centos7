public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{

	// Constructors
	public RSAPKCS1SignatureDeformatter() {}
	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public virtual void SetHashAlgorithm(string strName) {}
	public virtual bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) {}
	public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

