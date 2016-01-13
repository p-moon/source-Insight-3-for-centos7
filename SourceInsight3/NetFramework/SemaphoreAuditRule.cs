public class SemaphoreAuditRule : AuditRule
{

	// Constructors
	public SemaphoreAuditRule(System.Security.Principal.IdentityReference identity, SemaphoreRights eventRights, AuditFlags flags) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SemaphoreRights SemaphoreRights { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

