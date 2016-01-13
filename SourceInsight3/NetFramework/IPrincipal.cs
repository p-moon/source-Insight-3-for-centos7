public interface IPrincipal
{

	// Methods
	public abstract virtual bool IsInRole(string role) {}

	// Properties
	public IIdentity Identity { get{} }
}

