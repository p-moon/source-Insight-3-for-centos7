public class DefaultSerializationProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DefaultSerializationProviderAttribute(Type providerType) {}
	public DefaultSerializationProviderAttribute(string providerTypeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ProviderTypeName { get{} }
	public object TypeId { get{} }
}

