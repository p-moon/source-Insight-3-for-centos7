public class FileSystemAuditRule : AuditRule
{

	// Constructors
	public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, FileSystemRights fileSystemRights, AuditFlags flags) {}
	public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}
	public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, AuditFlags flags) {}
	public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public FileSystemRights FileSystemRights { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

