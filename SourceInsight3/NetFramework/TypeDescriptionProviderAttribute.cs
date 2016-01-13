public class TypeDescriptionProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TypeDescriptionProviderAttribute(string typeName) {}
	public TypeDescriptionProviderAttribute(Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string TypeName { get{} }
	public object TypeId { get{} }
}

