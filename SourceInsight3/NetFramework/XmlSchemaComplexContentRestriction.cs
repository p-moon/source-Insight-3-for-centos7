public class XmlSchemaComplexContentRestriction : XmlSchemaContent
{

	// Constructors
	public XmlSchemaComplexContentRestriction() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlQualifiedName BaseTypeName { get{} set{} }
	public XmlSchemaParticle Particle { get{} set{} }
	public XmlSchemaObjectCollection Attributes { get{} }
	public XmlSchemaAnyAttribute AnyAttribute { get{} set{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

