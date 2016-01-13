public class InterfaceTypeAttribute : System.Attribute, _Attribute
{

	// Constructors
	public InterfaceTypeAttribute(ComInterfaceType interfaceType) {}
	public InterfaceTypeAttribute(short interfaceType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ComInterfaceType Value { get{} }
	public object TypeId { get{} }
}

