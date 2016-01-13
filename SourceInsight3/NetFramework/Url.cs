public class Url : IIdentityPermissionFactory, IBuiltInEvidence
{

	// Constructors
	public Url(string name) {}

	// Methods
	public virtual System.Security.IPermission CreateIdentityPermission(Evidence evidence) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Value { get{} }
}

