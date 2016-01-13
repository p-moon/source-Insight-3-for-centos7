public class DocumentableItem
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
}

