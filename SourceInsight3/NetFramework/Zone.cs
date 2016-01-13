public class Zone : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public Zone(System.Security.SecurityZone zone) {}

	// Methods
	public static Zone CreateFromUrl(string url) {}
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Security.SecurityZone SecurityZone { get{} }
}

