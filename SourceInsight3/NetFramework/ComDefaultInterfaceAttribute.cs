public class ComDefaultInterfaceAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ComDefaultInterfaceAttribute(Type defaultInterface) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type Value { get{} }
	public object TypeId { get{} }
}

