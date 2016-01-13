public class WebDisplayNameAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebDisplayNameAttribute() {}
	public WebDisplayNameAttribute(string displayName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public WebDisplayNameAttribute Default;

	// Properties
	public string DisplayName { get{} }
	public object TypeId { get{} }
}

