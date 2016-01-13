public class RsaProtectedConfigurationProvider : ProtectedConfigurationProvider
{

	// Constructors
	public RsaProtectedConfigurationProvider() {}

	// Methods
	public virtual System.Xml.XmlNode Decrypt(System.Xml.XmlNode encryptedNode) {}
	public virtual System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) {}
	public void AddKey(int keySize, bool exportable) {}
	public void DeleteKey() {}
	public void ImportKey(string xmlFileName, bool exportable) {}
	public void ExportKey(string xmlFileName, bool includePrivateParameters) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string KeyContainerName { get{} }
	public string CspProviderName { get{} }
	public bool UseMachineContainer { get{} }
	public bool UseOAEP { get{} }
	public System.Security.Cryptography.RSAParameters RsaPublicKey { get{} }
	public string Name { get{} }
	public string Description { get{} }
}

