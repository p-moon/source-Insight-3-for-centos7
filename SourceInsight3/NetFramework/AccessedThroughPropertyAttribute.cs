public class AccessedThroughPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AccessedThroughPropertyAttribute(string propertyName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string PropertyName { get{} }
	public object TypeId { get{} }
}

