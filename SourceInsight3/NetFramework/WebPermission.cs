public class WebPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, System.Security.Permissions.IUnrestrictedPermission
{

	// Constructors
	public WebPermission(System.Security.Permissions.PermissionState state) {}
	public WebPermission() {}
	public WebPermission(NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) {}
	public WebPermission(NetworkAccess access, string uriString) {}

	// Methods
	public void AddPermission(NetworkAccess access, string uriString) {}
	public void AddPermission(NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) {}
	public virtual bool IsUnrestricted() {}
	public virtual System.Security.IPermission Copy() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual void FromXml(System.Security.SecurityElement securityElement) {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public System.Collections.IEnumerator ConnectList { get{} }
	public System.Collections.IEnumerator AcceptList { get{} }
}

