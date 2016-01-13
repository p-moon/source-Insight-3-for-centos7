public class XmlSchemaElement : XmlSchemaParticle
{

	// Constructors
	public XmlSchemaElement() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsAbstract { get{} set{} }
	public XmlSchemaDerivationMethod Block { get{} set{} }
	public string DefaultValue { get{} set{} }
	public XmlSchemaDerivationMethod Final { get{} set{} }
	public string FixedValue { get{} set{} }
	public XmlSchemaForm Form { get{} set{} }
	public string Name { get{} set{} }
	public bool IsNillable { get{} set{} }
	public System.Xml.XmlQualifiedName RefName { get{} set{} }
	public System.Xml.XmlQualifiedName SubstitutionGroup { get{} set{} }
	public System.Xml.XmlQualifiedName SchemaTypeName { get{} set{} }
	public XmlSchemaType SchemaType { get{} set{} }
	public XmlSchemaObjectCollection Constraints { get{} }
	public System.Xml.XmlQualifiedName QualifiedName { get{} }
	public object ElementType { get{} }
	public XmlSchemaType ElementSchemaType { get{} }
	public XmlSchemaDerivationMethod BlockResolved { get{} }
	public XmlSchemaDerivationMethod FinalResolved { get{} }
	public string MinOccursString { get{} set{} }
	public string MaxOccursString { get{} set{} }
	public decimal MinOccurs { get{} set{} }
	public decimal MaxOccurs { get{} set{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

