public class PassportPrincipal : System.Security.Principal.GenericPrincipal, System.Security.Principal.IPrincipal
{

	// Constructors
	public PassportPrincipal(PassportIdentity identity, string[] roles) {}

	// Methods
	public virtual bool IsInRole(string role) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Principal.IIdentity Identity { get{} }
}

