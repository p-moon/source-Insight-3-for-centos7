public class StrongNameMembershipCondition : IMembershipCondition, System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, IConstantMembershipCondition
{

	// Constructors
	public StrongNameMembershipCondition(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) {}

	// Methods
	public virtual bool Check(Evidence evidence) {}
	public virtual IMembershipCondition Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement e) {}
	public virtual System.Security.SecurityElement ToXml(PolicyLevel level) {}
	public virtual void FromXml(System.Security.SecurityElement e, PolicyLevel level) {}
	public virtual string ToString() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get{} set{} }
	public string Name { get{} set{} }
	public System.Version Version { get{} set{} }
}

