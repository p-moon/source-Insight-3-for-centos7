public class AsymmetricSignatureDeformatter
{

	// Methods
	public abstract virtual void SetKey(AsymmetricAlgorithm key) {}
	public abstract virtual void SetHashAlgorithm(string strName) {}
	public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature) {}
	public abstract virtual bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

