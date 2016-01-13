public class EventWaitHandleAuditRule : AuditRule
{

	// Constructors
	public EventWaitHandleAuditRule(System.Security.Principal.IdentityReference identity, EventWaitHandleRights eventRights, AuditFlags flags) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EventWaitHandleRights EventWaitHandleRights { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

