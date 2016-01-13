public class ClassInterfaceAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType) {}
	public ClassInterfaceAttribute(short classInterfaceType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ClassInterfaceType Value { get{} }
	public object TypeId { get{} }
}

