public class XmlArrayItemAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlArrayItemAttribute() {}
	public XmlArrayItemAttribute(string elementName) {}
	public XmlArrayItemAttribute(Type type) {}
	public XmlArrayItemAttribute(string elementName, Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type Type { get{} set{} }
	public string ElementName { get{} set{} }
	public string Namespace { get{} set{} }
	public int NestingLevel { get{} set{} }
	public string DataType { get{} set{} }
	public bool IsNullable { get{} set{} }
	public System.Xml.Schema.XmlSchemaForm Form { get{} set{} }
	public object TypeId { get{} }
}

