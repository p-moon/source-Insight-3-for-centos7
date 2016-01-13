public class SocketPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, System.Security.Permissions.IUnrestrictedPermission
{

	// Constructors
	public SocketPermission(System.Security.Permissions.PermissionState state) {}
	public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber) {}

	// Methods
	public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber) {}
	public virtual bool IsUnrestricted() {}
	public virtual System.Security.IPermission Copy() {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
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

	// Fields
	public int AllPorts;

	// Properties
	public System.Collections.IEnumerator ConnectList { get{} }
	public System.Collections.IEnumerator AcceptList { get{} }
}

