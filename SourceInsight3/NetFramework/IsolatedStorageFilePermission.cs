public class IsolatedStorageFilePermission : IsolatedStoragePermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public IsolatedStorageFilePermission(PermissionState state) {}

	// Methods
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual bool IsUnrestricted() {}
	public virtual void FromXml(System.Security.SecurityElement esd) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public long UserQuota { get{} set{} }
	public IsolatedStorageContainment UsageAllowed { get{} set{} }
}

