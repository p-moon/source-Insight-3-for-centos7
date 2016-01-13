public class Site : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public Site(string name) {}

	// Methods
	public static Site CreateFromUrl(string url) {}
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Name { get{} }
}

