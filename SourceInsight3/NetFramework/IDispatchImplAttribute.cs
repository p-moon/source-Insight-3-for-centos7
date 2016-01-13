public class IDispatchImplAttribute : System.Attribute, _Attribute
{

	// Constructors
	public IDispatchImplAttribute(IDispatchImplType implType) {}
	public IDispatchImplAttribute(short implType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public IDispatchImplType Value { get{} }
	public object TypeId { get{} }
}

