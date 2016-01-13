public class WebServiceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebServiceAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public string DefaultNamespace;

	// Properties
	public string Description { get{} set{} }
	public string Namespace { get{} set{} }
	public string Name { get{} set{} }
	public object TypeId { get{} }
}

