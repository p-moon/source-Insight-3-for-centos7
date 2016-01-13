public class EventWaitHandleAccessRule : AccessRule
{

	// Constructors
	public EventWaitHandleAccessRule(System.Security.Principal.IdentityReference identity, EventWaitHandleRights eventRights, AccessControlType type) {}
	public EventWaitHandleAccessRule(string identity, EventWaitHandleRights eventRights, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EventWaitHandleRights EventWaitHandleRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

