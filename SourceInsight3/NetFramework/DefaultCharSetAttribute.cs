public class DefaultCharSetAttribute : System.Attribute, _Attribute
{

	// Constructors
	public DefaultCharSetAttribute(CharSet charSet) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public CharSet CharSet { get{} }
	public object TypeId { get{} }
}

