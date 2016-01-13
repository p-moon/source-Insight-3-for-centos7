public class ProfileProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ProfileProviderAttribute(string providerName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ProviderName { get{} }
	public object TypeId { get{} }
}

