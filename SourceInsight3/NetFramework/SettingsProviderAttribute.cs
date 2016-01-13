public class SettingsProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SettingsProviderAttribute(string providerTypeName) {}
	public SettingsProviderAttribute(Type providerType) {}

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

