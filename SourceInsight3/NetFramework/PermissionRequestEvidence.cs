public class PermissionRequestEvidence : IBuiltInEvidence
{

	// Constructors
	public PermissionRequestEvidence(System.Security.PermissionSet request, System.Security.PermissionSet optional, System.Security.PermissionSet denied) {}

	// Methods
	public PermissionRequestEvidence Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.PermissionSet RequestedPermissions { get{} }
	public System.Security.PermissionSet OptionalPermissions { get{} }
	public System.Security.PermissionSet DeniedPermissions { get{} }
}

