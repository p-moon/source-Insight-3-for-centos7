public class DSA : AsymmetricAlgorithm, System.IDisposable
{

	// Methods
	public static DSA Create() {}
	public static DSA Create(string algName) {}
	public abstract virtual byte[] CreateSignature(byte[] rgbHash) {}
	public abstract virtual bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) {}
	public virtual void FromXmlString(string xmlString) {}
	public virtual string ToXmlString(bool includePrivateParameters) {}
	public abstract virtual DSAParameters ExportParameters(bool includePrivateParameters) {}
	public abstract virtual void ImportParameters(DSAParameters parameters) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int KeySize { get{} set{} }
	public KeySizes[] LegalKeySizes { get{} }
	public string SignatureAlgorithm { get{} }
	public string KeyExchangeAlgorithm { get{} }
}

