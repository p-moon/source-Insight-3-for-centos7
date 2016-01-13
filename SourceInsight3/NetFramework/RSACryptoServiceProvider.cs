public class RSACryptoServiceProvider : RSA, System.IDisposable, ICspAsymmetricAlgorithm
{

	// Constructors
	public RSACryptoServiceProvider() {}
	public RSACryptoServiceProvider(int dwKeySize) {}
	public RSACryptoServiceProvider(CspParameters parameters) {}
	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) {}

	// Methods
	public virtual RSAParameters ExportParameters(bool includePrivateParameters) {}
	public virtual byte[] ExportCspBlob(bool includePrivateParameters) {}
	public virtual void ImportParameters(RSAParameters parameters) {}
	public virtual void ImportCspBlob(byte[] keyBlob) {}
	public byte[] SignData(System.IO.Stream inputStream, object halg) {}
	public byte[] SignData(byte[] buffer, object halg) {}
	public byte[] SignData(byte[] buffer, int offset, int count, object halg) {}
	public bool VerifyData(byte[] buffer, object halg, byte[] signature) {}
	public byte[] SignHash(byte[] rgbHash, string str) {}
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) {}
	public byte[] Encrypt(byte[] rgb, bool fOAEP) {}
	public byte[] Decrypt(byte[] rgb, bool fOAEP) {}
	public virtual byte[] DecryptValue(byte[] rgb) {}
	public virtual byte[] EncryptValue(byte[] rgb) {}
	public virtual void FromXmlString(string xmlString) {}
	public virtual string ToXmlString(bool includePrivateParameters) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool PublicOnly { get{} }
	public CspKeyContainerInfo CspKeyContainerInfo { get{} }
	public int KeySize { get{} }
	public string KeyExchangeAlgorithm { get{} }
	public string SignatureAlgorithm { get{} }
	public bool UseMachineKeyStore { get{} set{} }
	public bool PersistKeyInCsp { get{} set{} }
	public KeySizes[] LegalKeySizes { get{} }
}

