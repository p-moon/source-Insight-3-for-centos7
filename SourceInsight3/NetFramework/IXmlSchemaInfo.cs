public interface IXmlSchemaInfo
{

	// Properties
	public XmlSchemaValidity Validity { get{} }
	public bool IsDefault { get{} }
	public bool IsNil { get{} }
	public XmlSchemaSimpleType MemberType { get{} }
	public XmlSchemaType SchemaType { get{} }
	public XmlSchemaElement SchemaElement { get{} }
	public XmlSchemaAttribute SchemaAttribute { get{} }
}

