public class Import : DocumentableItem
{

	// Constructors
	public Import() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public ServiceDescription ServiceDescription { get{} }
	public string Namespace { get{} set{} }
	public string Location { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

