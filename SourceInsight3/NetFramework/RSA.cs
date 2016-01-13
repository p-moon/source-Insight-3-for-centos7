public class RSA : AsymmetricAlgorithm, System.IDisposable
{

	// Methods
	public static RSA Create() {}
	public static RSA Create(string algName) {}
	public abstract virtual byte[] DecryptValue(byte[] rgb) {}
	public abstract virtual byte[] EncryptValue(byte[] rgb) {}
	public virtual void FromXmlString(string xmlString) {}
	public virtual string ToXmlString(bool includePrivateParameters) {}
	public abstract virtual RSAParameters ExportParameters(bool includePrivateParameters) {}
	public abstract virtual void ImportParameters(RSAParameters parameters) {}
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

