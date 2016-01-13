public class PropertyAccessRule : ActiveDirectoryAccessRule
{

	// Constructors
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access) {}
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access, System.Guid propertyType) {}
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType) {}
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access, System.Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType) {}
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}
	public PropertyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type, PropertyAccess access, System.Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType, System.Guid inheritedObjectType) {}

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

