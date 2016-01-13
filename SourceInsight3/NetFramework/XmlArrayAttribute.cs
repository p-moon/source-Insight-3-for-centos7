public class XmlArrayAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlArrayAttribute() {}
	public XmlArrayAttribute(string elementName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ElementName { get{} set{} }
	public string Namespace { get{} set{} }
	public bool IsNullable { get{} set{} }
	public System.Xml.Schema.XmlSchemaForm Form { get{} set{} }
	public int Order { get{} set{} }
	public object TypeId { get{} }
}

