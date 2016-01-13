public class RegistryAccessRule : AccessRule
{

	// Constructors
	public RegistryAccessRule(System.Security.Principal.IdentityReference identity, RegistryRights registryRights, AccessControlType type) {}
	public RegistryAccessRule(string identity, RegistryRights registryRights, AccessControlType type) {}
	public RegistryAccessRule(System.Security.Principal.IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}
	public RegistryAccessRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RegistryRights RegistryRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

