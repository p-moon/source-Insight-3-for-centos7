public class TypeLibTypeAttribute : System.Attribute, _Attribute
{

	// Constructors
	public TypeLibTypeAttribute(TypeLibTypeFlags flags) {}
	public TypeLibTypeAttribute(short flags) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public TypeLibTypeFlags Value { get{} }
	public object TypeId { get{} }
}

