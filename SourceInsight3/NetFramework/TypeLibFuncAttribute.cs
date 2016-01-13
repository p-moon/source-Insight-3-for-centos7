public class TypeLibFuncAttribute : System.Attribute, _Attribute
{

	// Constructors
	public TypeLibFuncAttribute(TypeLibFuncFlags flags) {}
	public TypeLibFuncAttribute(short flags) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public TypeLibFuncFlags Value { get{} }
	public object TypeId { get{} }
}

