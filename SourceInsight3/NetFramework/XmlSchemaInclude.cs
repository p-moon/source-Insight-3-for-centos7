public class XmlSchemaInclude : XmlSchemaExternal
{

	// Constructors
	public XmlSchemaInclude() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public string SchemaLocation { get{} set{} }
	public XmlSchema Schema { get{} set{} }
	public string Id { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

