public class XmlRootAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlRootAttribute() {}
	public XmlRootAttribute(string elementName) {}

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
	public string DataType { get{} set{} }
	public bool IsNullable { get{} set{} }
	public object TypeId { get{} }
}

