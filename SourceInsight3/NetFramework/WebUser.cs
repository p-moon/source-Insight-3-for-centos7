public class WebUser : User
{

	// Constructors
	public WebUser() {}

	// Methods
	public void InitializeWithWindowsUser() {}
	public bool IsInRole(string role) {}
	public bool IsInRole(BuiltInRole role) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public System.Security.Principal.IPrincipal CurrentPrincipal { get{} set{} }
	public bool IsAuthenticated { get{} }
}

