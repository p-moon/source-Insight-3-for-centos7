public class XmlSchemaAttribute : XmlSchemaAnnotated
{

	// Constructors
	public XmlSchemaAttribute() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DefaultValue { get{} set{} }
	public string FixedValue { get{} set{} }
	public XmlSchemaForm Form { get{} set{} }
	public string Name { get{} set{} }
	public System.Xml.XmlQualifiedName RefName { get{} set{} }
	public System.Xml.XmlQualifiedName SchemaTypeName { get{} set{} }
	public XmlSchemaSimpleType SchemaType { get{} set{} }
	public XmlSchemaUse Use { get{} set{} }
	public System.Xml.XmlQualifiedName QualifiedName { get{} }
	public object AttributeType { get{} }
	public XmlSchemaSimpleType AttributeSchemaType { get{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

