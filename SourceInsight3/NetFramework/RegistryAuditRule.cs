public class RegistryAuditRule : AuditRule
{

	// Constructors
	public RegistryAuditRule(System.Security.Principal.IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}
	public RegistryAuditRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RegistryRights RegistryRights { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

