public class FileIOPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public FileIOPermission(PermissionState state) {}
	public FileIOPermission(FileIOPermissionAccess access, string path) {}
	public FileIOPermission(FileIOPermissionAccess access, string[] pathList) {}
	public FileIOPermission(FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string path) {}
	public FileIOPermission(FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string[] pathList) {}

	// Methods
	public void SetPathList(FileIOPermissionAccess access, string path) {}
	public void SetPathList(FileIOPermissionAccess access, string[] pathList) {}
	public void AddPathList(FileIOPermissionAccess access, string path) {}
	public void AddPathList(FileIOPermissionAccess access, string[] pathList) {}
	public string[] GetPathList(FileIOPermissionAccess access) {}
	public virtual bool IsUnrestricted() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission other) {}
	public virtual System.Security.IPermission Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement esd) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public FileIOPermissionAccess AllLocalFiles { get{} set{} }
	public FileIOPermissionAccess AllFiles { get{} set{} }
}

