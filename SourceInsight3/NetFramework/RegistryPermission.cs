public class RegistryPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public RegistryPermission(PermissionState state) {}
	public RegistryPermission(RegistryPermissionAccess access, string pathList) {}
	public RegistryPermission(RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) {}

	// Methods
	public void SetPathList(RegistryPermissionAccess access, string pathList) {}
	public void AddPathList(RegistryPermissionAccess access, string pathList) {}
	public void AddPathList(RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) {}
	public string GetPathList(RegistryPermissionAccess access) {}
	public virtual bool IsUnrestricted() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission other) {}
	public virtual System.Security.IPermission Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement esd) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
}

