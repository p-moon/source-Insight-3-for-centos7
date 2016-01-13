public class XmlAnyElementAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlAnyElementAttribute() {}
	public XmlAnyElementAttribute(string name) {}
	public XmlAnyElementAttribute(string name, string ns) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public string Namespace { get{} set{} }
	public int Order { get{} set{} }
	public object TypeId { get{} }
}

