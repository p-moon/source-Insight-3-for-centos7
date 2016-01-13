public class XmlSchemaDatatype
{

	// Methods
	public abstract virtual object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) {}
	public virtual object ChangeType(object value, Type targetType) {}
	public virtual object ChangeType(object value, Type targetType, System.Xml.IXmlNamespaceResolver namespaceResolver) {}
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type ValueType { get{} }
	public System.Xml.XmlTokenizedType TokenizedType { get{} }
	public XmlSchemaDatatypeVariety Variety { get{} }
	public XmlTypeCode TypeCode { get{} }
}

