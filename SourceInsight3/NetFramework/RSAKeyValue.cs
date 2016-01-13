public class RSAKeyValue : KeyInfoClause
{

	// Constructors
	public RSAKeyValue() {}
	public RSAKeyValue(System.Security.Cryptography.RSA key) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.RSA Key { get{} set{} }
}

