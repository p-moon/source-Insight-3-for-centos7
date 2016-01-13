public class AttributeProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AttributeProviderAttribute(string typeName) {}
	public AttributeProviderAttribute(string typeName, string propertyName) {}
	public AttributeProviderAttribute(Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string TypeName { get{} }
	public string PropertyName { get{} }
	public object TypeId { get{} }
}

