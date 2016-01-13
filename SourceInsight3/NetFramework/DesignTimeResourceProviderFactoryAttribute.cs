public class DesignTimeResourceProviderFactoryAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignTimeResourceProviderFactoryAttribute(Type factoryType) {}
	public DesignTimeResourceProviderFactoryAttribute(string factoryTypeName) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string FactoryTypeName { get{} }
	public object TypeId { get{} }
}

