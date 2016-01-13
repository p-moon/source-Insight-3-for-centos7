public class X509Certificate : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public X509Certificate() {}
	public X509Certificate(byte[] data) {}
	public X509Certificate(byte[] rawData, string password) {}
	public X509Certificate(byte[] rawData, System.Security.SecureString password) {}
	public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate(byte[] rawData, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate(string fileName) {}
	public X509Certificate(string fileName, string password) {}
	public X509Certificate(string fileName, System.Security.SecureString password) {}
	public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate(string fileName, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public X509Certificate(System.IntPtr handle) {}
	public X509Certificate(X509Certificate cert) {}
	public X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}

	// Methods
	public static X509Certificate CreateFromCertFile(string filename) {}
	public static X509Certificate CreateFromSignedFile(string filename) {}
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
	public virtual string ToString() {}
	public virtual string ToString(bool fVerbose) {}
	public virtual string GetFormat() {}
	public virtual void Import(byte[] rawData) {}
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(byte[] rawData, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(string fileName) {}
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual void Import(string fileName, System.Security.SecureString password, X509KeyStorageFlags keyStorageFlags) {}
	public virtual byte[] Export(X509ContentType contentType) {}
	public virtual byte[] Export(X509ContentType contentType, string password) {}
	public virtual byte[] Export(X509ContentType contentType, System.Security.SecureString password) {}
	public virtual void Reset() {}
	public Type GetType() {}

	// Properties
	public System.IntPtr Handle { get{} }
	public string Issuer { get{} }
	public string Subject { get{} }
}

