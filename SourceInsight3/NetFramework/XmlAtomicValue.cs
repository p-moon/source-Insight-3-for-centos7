public class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
{

	// Methods
	public XmlAtomicValue Clone() {}
	public virtual object ValueAs(Type type, System.Xml.IXmlNamespaceResolver nsResolver) {}
	public virtual string ToString() {}
	public virtual object ValueAs(Type returnType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsNode { get{} }
	public XmlSchemaType XmlType { get{} }
	public Type ValueType { get{} }
	public object TypedValue { get{} }
	public bool ValueAsBoolean { get{} }
	public System.DateTime ValueAsDateTime { get{} }
	public double ValueAsDouble { get{} }
	public int ValueAsInt { get{} }
	public long ValueAsLong { get{} }
	public string Value { get{} }
}

