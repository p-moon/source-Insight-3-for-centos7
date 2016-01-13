public class DefaultBindingPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DefaultBindingPropertyAttribute() {}
	public DefaultBindingPropertyAttribute(string name) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DefaultBindingPropertyAttribute Default;

	// Properties
	public string Name { get{} }
	public object TypeId { get{} }
}

