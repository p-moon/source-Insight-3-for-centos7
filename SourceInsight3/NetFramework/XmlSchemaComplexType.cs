public class XmlSchemaComplexType : XmlSchemaType
{

	// Constructors
	public XmlSchemaComplexType() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsAbstract { get{} set{} }
	public XmlSchemaDerivationMethod Block { get{} set{} }
	public bool IsMixed { get{} set{} }
	public XmlSchemaContentModel ContentModel { get{} set{} }
	public XmlSchemaParticle Particle { get{} set{} }
	public XmlSchemaObjectCollection Attributes { get{} }
	public XmlSchemaAnyAttribute AnyAttribute { get{} set{} }
	public XmlSchemaContentType ContentType { get{} }
	public XmlSchemaParticle ContentTypeParticle { get{} }
	public XmlSchemaDerivationMethod BlockResolved { get{} }
	public XmlSchemaObjectTable AttributeUses { get{} }
	public XmlSchemaAnyAttribute AttributeWildcard { get{} }
	public string Name { get{} set{} }
	public XmlSchemaDerivationMethod Final { get{} set{} }
	public System.Xml.XmlQualifiedName QualifiedName { get{} }
	public XmlSchemaDerivationMethod FinalResolved { get{} }
	public object BaseSchemaType { get{} }
	public XmlSchemaType BaseXmlSchemaType { get{} }
	public XmlSchemaDerivationMethod DerivedBy { get{} }
	public XmlSchemaDatatype Datatype { get{} }
	public XmlTypeCode TypeCode { get{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

