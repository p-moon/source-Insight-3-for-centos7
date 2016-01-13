public class CustomProviderDataAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public CustomProviderDataAttribute(string customProviderData) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string CustomProviderData { get{} }
	public object TypeId { get{} }
}

