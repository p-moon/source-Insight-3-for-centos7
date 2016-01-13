public class SecurityCriticalAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SecurityCriticalAttribute() {}
	public SecurityCriticalAttribute(SecurityCriticalScope scope) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SecurityCriticalScope Scope { get{} }
	public object TypeId { get{} }
}

