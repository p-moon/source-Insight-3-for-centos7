public class CoClassAttribute : System.Attribute, _Attribute
{

	// Constructors
	public CoClassAttribute(Type coClass) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type CoClass { get{} }
	public object TypeId { get{} }
}

