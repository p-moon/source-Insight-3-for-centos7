public class ActiveDirectoryAccessRule : System.Security.AccessControl.ObjectAccessRule
{

	// Constructors
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type) {}
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type, System.Guid objectType) {}
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType) {}
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type, System.Guid objectType, ActiveDirectorySecurityInheritance inheritanceType) {}
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}
	public ActiveDirectoryAccessRule(System.Security.Principal.IdentityReference identity, ActiveDirectoryRights adRights, System.Security.AccessControl.AccessControlType type, System.Guid objectType, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}

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
	public System.Security.AccessControl.AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get{} }
	public System.Security.AccessControl.PropagationFlags PropagationFlags { get{} }
}

