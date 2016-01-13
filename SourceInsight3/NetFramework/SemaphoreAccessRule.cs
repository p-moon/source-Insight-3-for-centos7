public class SemaphoreAccessRule : AccessRule
{

	// Constructors
	public SemaphoreAccessRule(System.Security.Principal.IdentityReference identity, SemaphoreRights eventRights, AccessControlType type) {}
	public SemaphoreAccessRule(string identity, SemaphoreRights eventRights, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SemaphoreRights SemaphoreRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

