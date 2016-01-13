public class RoleGroup
{

	// Constructors
	public RoleGroup() {}

	// Methods
	public bool ContainsUser(System.Security.Principal.IPrincipal user) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.ITemplate ContentTemplate { get{} set{} }
	public string[] Roles { get{} set{} }
}

