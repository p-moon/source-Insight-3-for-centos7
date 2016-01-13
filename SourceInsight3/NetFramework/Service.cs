public class Service : NamedItem
{

	// Constructors
	public Service() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescription ServiceDescription { get{} }
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public PortCollection Ports { get{} }
	public string Name { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

