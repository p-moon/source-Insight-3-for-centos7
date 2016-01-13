public class XmlIncludeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlIncludeAttribute(Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type Type { get{} set{} }
	public object TypeId { get{} }
}

