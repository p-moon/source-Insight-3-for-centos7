public class SecurityRoleAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public SecurityRoleAttribute(string role) {}
	public SecurityRoleAttribute(string role, bool everyone) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Role { get{} set{} }
	public bool SetEveryoneAccess { get{} set{} }
	public string Description { get{} set{} }
	public object TypeId { get{} }
}

