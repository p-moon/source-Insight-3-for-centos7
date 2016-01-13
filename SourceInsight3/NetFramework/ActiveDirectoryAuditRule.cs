public class ActiveDirectoryAuditRule : System.Security.AccessControl.ObjectAuditRule
{

	// Constructors
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags) {}
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags, System.Guid objectType) {}
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags, ActiveDirectorySecurityInheritance inheritanceType) {}
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags, System.Guid objectType, ActiveDirectorySecurityInheritance inheritanceType) {}
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}
	public ActiveDirectoryAuditRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AuditFlags auditFlags, System.Guid objectType, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectoryRights ActiveDirectoryRights { get{} }
	public ActiveDirectorySecurityInheritance InheritanceType { get{} }
	public System.Guid ObjectType { get{} }
	public System.Guid InheritedObjectType { get{} }
	public System.Security.AccessControl.ObjectAceFlags ObjectFlags { get{} }
	public System.Security.AccessControl.AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get{} }
	public System.Security.AccessControl.PropagationFlags PropagationFlags { get{} }
}

