public class StrongNameIdentityPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IBuiltInPermission
{

	// Constructors
	public StrongNameIdentityPermission(PermissionState state) {}
	public StrongNameIdentityPermission(StrongNamePublicKeyBlob blob, string name, System.Version version) {}

	// Methods
	public virtual System.Security.IPermission Copy() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual void FromXml(System.Security.SecurityElement e) {}
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
	public StrongNamePublicKeyBlob PublicKey { get{} set{} }
	public string Name { get{} set{} }
	public System.Version Version { get{} set{} }
}

