public class TypeLibVarAttribute : System.Attribute, _Attribute
{

	// Constructors
	public TypeLibVarAttribute(TypeLibVarFlags flags) {}
	public TypeLibVarAttribute(short flags) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public TypeLibVarFlags Value { get{} }
	public object TypeId { get{} }
}

