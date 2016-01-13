public class RolePrincipal : System.Security.Principal.IPrincipal, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public RolePrincipal(System.Security.Principal.IIdentity identity, string encryptedTicket) {}
	public RolePrincipal(System.Security.Principal.IIdentity identity) {}
	public RolePrincipal(string providerName, System.Security.Principal.IIdentity identity) {}
	public RolePrincipal(string providerName, System.Security.Principal.IIdentity identity, string encryptedTicket) {}

	// Methods
	public string ToEncryptedTicket() {}
	public string[] GetRoles() {}
	public virtual bool IsInRole(string role) {}
	public void SetDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public System.DateTime ExpireDate { get{} }
	public System.DateTime IssueDate { get{} }
	public bool Expired { get{} }
	public string CookiePath { get{} }
	public System.Security.Principal.IIdentity Identity { get{} }
	public bool IsRoleListCached { get{} }
	public bool CachedListChanged { get{} }
	public string ProviderName { get{} }
}

