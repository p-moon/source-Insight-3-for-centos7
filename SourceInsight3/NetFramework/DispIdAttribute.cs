public class DispIdAttribute : System.Attribute, _Attribute
{

	// Constructors
	public DispIdAttribute(int dispId) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int Value { get{} }
	public object TypeId { get{} }
}

