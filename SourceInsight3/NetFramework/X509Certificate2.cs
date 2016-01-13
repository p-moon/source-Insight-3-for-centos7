public class X509Certificate2 : X509Certificate, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public X509Certificate2() {}
	public X509Certificate2(byte[] rawData) {}
	public X509Certificate2(byte[] rawData, string password) {}
	public X509Certificate2(byte[] rawData, System.Security.SecureString password) {}
	public X509Certificate2(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate2(byte[] rawData, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate2(string fileName) {}
	public X509Certificate2(string fileName, string password) {}
	public X509Certificate2(string fileName, System.Security.SecureString password) {}
	public X509Certificate2(string fileName, string password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate2(string fileName, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate2(System.IntPtr handle) {}
	public X509Certificate2(X509Certificate certificate) {}

	// Methods
	public virtual string ToString() {}
	public virtual string ToString(bool verbose) {}
	public string GetNameInfo(X509NameType nameType, bool forIssuer) {}
	public virtual void Import(byte[] rawData) {}
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(byte[] rawData, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(string fileName) {}
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(string fileName, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Reset() {}
	public bool Verify() {}
	public static X509ContentType GetCertContentType(byte[] rawData) {}
	public static X509ContentType GetCertContentType(string fileName) {}
	public virtual string GetName() {}
	public virtual string GetIssuerName() {}
	public virtual byte[] GetSerialNumber() {}
	public virtual string GetSerialNumberString() {}
	public virtual byte[] GetKeyAlgorithmParameters() {}
	public virtual string GetKeyAlgorithmParametersString() {}
	public virtual string GetKeyAlgorithm() {}
	public virtual byte[] GetPublicKey() {}
	public virtual string GetPublicKeyString() {}
	public virtual byte[] GetRawCertData() {}
	public virtual string GetRawCertDataString() {}
	public virtual byte[] GetCertHash() {}
	public virtual string GetCertHashString() {}
	public virtual string GetEffectiveDateString() {}
	public virtual string GetExpirationDateString() {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(X509Certificate other) {}
	public virtual int GetHashCode() {}
	public virtual string GetFormat() {}
	public virtual byte[] Export(X509ContentType contentType) {}
	public virtual byte[] Export(X509ContentType contentType, string password) {}
	public virtual byte[] Export(X509ContentType contentType, System.Security.SecureString password) {}
	public Type GetType() {}

	// Properties
	public bool Archived { get{} set{} }
	public X509ExtensionCollection Extensions { get{} }
	public string FriendlyName { get{} set{} }
	public X500DistinguishedName IssuerName { get{} }
	public System.DateTime NotAfter { get{} }
	public System.DateTime NotBefore { get{} }
	public bool HasPrivateKey { get{} }
	public System.Security.Cryptography.AsymmetricAlgorithm PrivateKey { get{} set{} }
	public PublicKey PublicKey { get{} }
	public byte[] RawData { get{} }
	public string SerialNumber { get{} }
	public X500DistinguishedName SubjectName { get{} }
	public System.Security.Cryptography.Oid SignatureAlgorithm { get{} }
	public string Thumbprint { get{} }
	public int Version { get{} }
	public System.IntPtr Handle { get{} }
	public string Issuer { get{} }
	public string Subject { get{} }
}

