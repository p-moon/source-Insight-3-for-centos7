public class DSACryptoServiceProvider : DSA, System.IDisposable, ICspAsymmetricAlgorithm
{

	// Constructors
	public DSACryptoServiceProvider() {}
	public DSACryptoServiceProvider(int dwKeySize) {}
	public DSACryptoServiceProvider(CspParameters parameters) {}
	public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters) {}

	// Methods
	public virtual DSAParameters ExportParameters(bool includePrivateParameters) {}
	public virtual byte[] ExportCspBlob(bool includePrivateParameters) {}
	public virtual void ImportParameters(DSAParameters parameters) {}
	public virtual void ImportCspBlob(byte[] keyBlob) {}
	public byte[] SignData(System.IO.Stream inputStream) {}
	public byte[] SignData(byte[] buffer) {}
	public byte[] SignData(byte[] buffer, int offset, int count) {}
	public bool VerifyData(byte[] rgbData, byte[] rgbSignature) {}
	public virtual byte[] CreateSignature(byte[] rgbHash) {}
	public virtual bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) {}
	public byte[] SignHash(byte[] rgbHash, string str) {}
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) {}
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

