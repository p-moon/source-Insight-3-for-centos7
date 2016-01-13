public class UIPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission, IBuiltInPermission
{

	// Constructors
	public UIPermission(PermissionState state) {}
	public UIPermission(UIPermissionWindow windowFlag, UIPermissionClipboard clipboardFlag) {}
	public UIPermission(UIPermissionWindow windowFlag) {}
	public UIPermission(UIPermissionClipboard clipboardFlag) {}

	// Methods
	public virtual bool IsUnrestricted() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
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

	// Properties
	public UIPermissionWindow Window { get{} set{} }
	public UIPermissionClipboard Clipboard { get{} set{} }
}

