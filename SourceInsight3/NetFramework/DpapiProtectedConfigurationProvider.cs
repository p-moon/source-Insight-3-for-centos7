public class DpapiProtectedConfigurationProvider : ProtectedConfigurationProvider
{

	// Constructors
	public DpapiProtectedConfigurationProvider() {}

	// Methods
	public virtual System.Xml.XmlNode Decrypt(System.Xml.XmlNode encryptedNode) {}
	public virtual System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UseMachineProtection { get{} }
	public string Name { get{} }
	public string Description { get{} }
}

