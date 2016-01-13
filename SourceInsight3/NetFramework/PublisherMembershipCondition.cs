public class PublisherMembershipCondition : IMembershipCondition, System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, IConstantMembershipCondition
{

	// Constructors
	public PublisherMembershipCondition(System.Security.Cryptography.X509Certificates.X509Certificate certificate) {}

	// Methods
	public virtual string ToString() {}
	public virtual bool Check(Evidence evidence) {}
	public virtual IMembershipCondition Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement e) {}
	public virtual System.Security.SecurityElement ToXml(PolicyLevel level) {}
	public virtual void FromXml(System.Security.SecurityElement e, PolicyLevel level) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get{} set{} }
}

