public class XmlTypeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlTypeAttribute() {}
	public XmlTypeAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AnonymousType { get{} set{} }
	public bool IncludeInSchema { get{} set{} }
	public string TypeName { get{} set{} }
	public string Namespace { get{} set{} }
	public object TypeId { get{} }
}

