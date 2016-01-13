public class GenericPrincipal : IPrincipal
{

	// Constructors
	public GenericPrincipal(IIdentity identity, string[] roles) {}

	// Methods
	public virtual bool IsInRole(string role) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IIdentity Identity { get{} }
}

