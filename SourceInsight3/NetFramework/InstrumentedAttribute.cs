public class InstrumentedAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public InstrumentedAttribute() {}
	public InstrumentedAttribute(string namespaceName) {}
	public InstrumentedAttribute(string namespaceName, string securityDescriptor) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string NamespaceName { get{} }
	public string SecurityDescriptor { get{} }
	public object TypeId { get{} }
}

