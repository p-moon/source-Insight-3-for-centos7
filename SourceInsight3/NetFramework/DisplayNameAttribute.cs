public class DisplayNameAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DisplayNameAttribute() {}
	public DisplayNameAttribute(string displayName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DisplayNameAttribute Default;

	// Properties
	public string DisplayName { get{} }
	public object TypeId { get{} }
}

