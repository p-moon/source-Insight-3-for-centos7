public class EncryptionProperty
{

	// Constructors
	public EncryptionProperty() {}
	public EncryptionProperty(System.Xml.XmlElement elementProperty) {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} }
	public string Target { get{} }
	public System.Xml.XmlElement PropertyElement { get{} set{} }
}

