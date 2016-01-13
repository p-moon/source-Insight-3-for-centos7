public class MutexAccessRule : AccessRule
{

	// Constructors
	public MutexAccessRule(System.Security.Principal.IdentityReference identity, MutexRights eventRights, AccessControlType type) {}
	public MutexAccessRule(string identity, MutexRights eventRights, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MutexRights MutexRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

