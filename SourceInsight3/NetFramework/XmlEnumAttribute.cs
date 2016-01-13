public class XmlEnumAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlEnumAttribute() {}
	public XmlEnumAttribute(string name) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public object TypeId { get{} }
}

