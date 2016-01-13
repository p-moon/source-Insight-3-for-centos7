public class KeyInfoEncryptedKey : KeyInfoClause
{

	// Constructors
	public KeyInfoEncryptedKey() {}
	public KeyInfoEncryptedKey(EncryptedKey encryptedKey) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EncryptedKey EncryptedKey { get{} set{} }
}

