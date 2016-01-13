public class FileSystemAccessRule : AccessRule
{

	// Constructors
	public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, FileSystemRights fileSystemRights, AccessControlType type) {}
	public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, AccessControlType type) {}
	public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}
	public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public FileSystemRights FileSystemRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

