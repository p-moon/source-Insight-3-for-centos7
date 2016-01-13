public class KeyContainerPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public KeyContainerPermission(PermissionState state) {}
	public KeyContainerPermission(KeyContainerPermissionFlags flags) {}
	public KeyContainerPermission(KeyContainerPermissionFlags flags, KeyContainerPermissionAccessEntry[] accessList) {}

	// Methods
	public virtual bool IsUnrestricted() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement securityElement) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public KeyContainerPermissionFlags Flags { get{} }
	public KeyContainerPermissionAccessEntryCollection AccessEntries { get{} }
}

