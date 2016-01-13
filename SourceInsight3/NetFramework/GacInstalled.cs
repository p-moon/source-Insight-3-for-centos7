public class GacInstalled : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public GacInstalled() {}

	// Methods
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}
}

