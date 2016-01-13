public class XPathItem
{

	// Methods
	public virtual object ValueAs(Type returnType) {}
	public abstract virtual object ValueAs(Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsNode { get{} }
	public System.Xml.Schema.XmlSchemaType XmlType { get{} }
	public string Value { get{} }
	public object TypedValue { get{} }
	public Type ValueType { get{} }
	public bool ValueAsBoolean { get{} }
	public System.DateTime ValueAsDateTime { get{} }
	public double ValueAsDouble { get{} }
	public int ValueAsInt { get{} }
	public long ValueAsLong { get{} }
}

