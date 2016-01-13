public class StrongName : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public StrongName(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) {}

	// Methods
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public object Copy() {}
	public virtual string ToString() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get{} }
	public string Name { get{} }
	public System.Version Version { get{} }
}

