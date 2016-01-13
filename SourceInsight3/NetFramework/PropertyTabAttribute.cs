public class PropertyTabAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PropertyTabAttribute() {}
	public PropertyTabAttribute(Type tabClass) {}
	public PropertyTabAttribute(string tabClassName) {}
	public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope) {}
	public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope) {}

	// Methods
	public virtual bool Equals(object other) {}
	public bool Equals(PropertyTabAttribute other) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type[] TabClasses { get{} }
	public PropertyTabScope[] TabScopes { get{} }
	public object TypeId { get{} }
}

