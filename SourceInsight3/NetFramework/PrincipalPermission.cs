public class PrincipalPermission : System.Security.IPermission, System.Security.ISecurityEncodable, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public PrincipalPermission(PermissionState state) {}
	public PrincipalPermission(string name, string role) {}
	public PrincipalPermission(string name, string role, bool isAuthenticated) {}

	// Methods
	public virtual bool IsUnrestricted() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission other) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual System.Security.IPermission Copy() {}
	public virtual void Demand() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement elem) {}
	public virtual string ToString() {}
	public Type GetType() {}
}

