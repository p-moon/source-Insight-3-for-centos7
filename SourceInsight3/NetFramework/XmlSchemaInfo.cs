public class XmlSchemaInfo : IXmlSchemaInfo
{

	// Constructors
	public XmlSchemaInfo() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSchemaValidity Validity { get{} set{} }
	public bool IsDefault { get{} set{} }
	public bool IsNil { get{} set{} }
	public XmlSchemaSimpleType MemberType { get{} set{} }
	public XmlSchemaType SchemaType { get{} set{} }
	public XmlSchemaElement SchemaElement { get{} set{} }
	public XmlSchemaAttribute SchemaAttribute { get{} set{} }
	public XmlSchemaContentType ContentType { get{} set{} }
}

