public class WindowsPrincipal : IPrincipal
{

	// Constructors
	public WindowsPrincipal(WindowsIdentity ntIdentity) {}

	// Methods
	public virtual bool IsInRole(string role) {}
	public virtual bool IsInRole(WindowsBuiltInRole role) {}
	public virtual bool IsInRole(int rid) {}
	public virtual bool IsInRole(SecurityIdentifier sid) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IIdentity Identity { get{} }
}

