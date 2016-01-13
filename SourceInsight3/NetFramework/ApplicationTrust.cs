public class ApplicationTrust : System.Security.ISecurityEncodable
{

	// Constructors
	public ApplicationTrust(System.ApplicationIdentity applicationIdentity) {}
	public ApplicationTrust() {}

	// Methods
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement element) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ApplicationIdentity ApplicationIdentity { get{} set{} }
	public PolicyStatement DefaultGrantSet { get{} set{} }
	public bool IsApplicationTrustedToRun { get{} set{} }
	public bool Persist { get{} set{} }
	public object ExtraInfo { get{} set{} }
}

