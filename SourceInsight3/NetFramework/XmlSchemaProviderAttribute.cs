public class XmlSchemaProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlSchemaProviderAttribute(string methodName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string MethodName { get{} }
	public bool IsAny { get{} set{} }
	public object TypeId { get{} }
}

