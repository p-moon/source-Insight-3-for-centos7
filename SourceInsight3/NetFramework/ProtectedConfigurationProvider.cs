public class ProtectedConfigurationProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) {}
	public abstract virtual System.Xml.XmlNode Decrypt(System.Xml.XmlNode encryptedNode) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Description { get{} }
}

