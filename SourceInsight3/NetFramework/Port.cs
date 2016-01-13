public class Port : NamedItem
{

	// Constructors
	public Port() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Service Service { get{} }
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public System.Xml.XmlQualifiedName Binding { get{} set{} }
	public string Name { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

