public class DSASignatureFormatter : AsymmetricSignatureFormatter
{

	// Constructors
	public DSASignatureFormatter() {}
	public DSASignatureFormatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public virtual void SetHashAlgorithm(string strName) {}
	public virtual byte[] CreateSignature(byte[] rgbHash) {}
	public virtual byte[] CreateSignature(HashAlgorithm hash) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

