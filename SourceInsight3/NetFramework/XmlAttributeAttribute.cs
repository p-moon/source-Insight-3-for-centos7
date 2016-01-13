public class XmlAttributeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlAttributeAttribute() {}
	public XmlAttributeAttribute(string attributeName) {}
	public XmlAttributeAttribute(Type type) {}
	public XmlAttributeAttribute(string attributeName, Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type Type { get{} set{} }
	public string AttributeName { get{} set{} }
	public string Namespace { get{} set{} }
	public string DataType { get{} set{} }
	public System.Xml.Schema.XmlSchemaForm Form { get{} set{} }
	public object TypeId { get{} }
}

