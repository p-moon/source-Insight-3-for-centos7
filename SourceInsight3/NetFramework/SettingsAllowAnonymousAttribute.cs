public class SettingsAllowAnonymousAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SettingsAllowAnonymousAttribute(bool allow) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Allow { get{} }
	public object TypeId { get{} }
}

