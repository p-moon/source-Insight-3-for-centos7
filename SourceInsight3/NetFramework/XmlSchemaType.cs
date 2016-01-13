public class XmlSchemaType : XmlSchemaAnnotated
{

	// Constructors
	public XmlSchemaType() {}

	// Methods
	public static XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName) {}
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) {}
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlTypeCode typeCode) {}
	public static XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName) {}
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public XmlSchemaDerivationMethod Final { get{} set{} }
	public System.Xml.XmlQualifiedName QualifiedName { get{} }
	public XmlSchemaDerivationMethod FinalResolved { get{} }
	public object BaseSchemaType { get{} }
	public XmlSchemaType BaseXmlSchemaType { get{} }
	public XmlSchemaDerivationMethod DerivedBy { get{} }
	public XmlSchemaDatatype Datatype { get{} }
	public bool IsMixed { get{} set{} }
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

