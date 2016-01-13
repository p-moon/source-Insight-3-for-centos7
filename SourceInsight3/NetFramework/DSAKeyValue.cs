public class DSAKeyValue : KeyInfoClause
{

	// Constructors
	public DSAKeyValue() {}
	public DSAKeyValue(System.Security.Cryptography.DSA key) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.DSA Key { get{} set{} }
}

