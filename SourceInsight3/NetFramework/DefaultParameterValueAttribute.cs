public class DefaultParameterValueAttribute : System.Attribute, _Attribute
{

	// Constructors
	public DefaultParameterValueAttribute(object value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object Value { get{} }
	public object TypeId { get{} }
}

