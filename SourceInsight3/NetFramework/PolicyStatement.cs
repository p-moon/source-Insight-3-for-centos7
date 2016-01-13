public class PolicyStatement : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
{

	// Constructors
	public PolicyStatement(System.Security.PermissionSet permSet) {}
	public PolicyStatement(System.Security.PermissionSet permSet, PolicyStatementAttribute attributes) {}

	// Methods
	public PolicyStatement Copy() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement et) {}
	public virtual System.Security.SecurityElement ToXml(PolicyLevel level) {}
	public virtual void FromXml(System.Security.SecurityElement et, PolicyLevel level) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Security.PermissionSet PermissionSet { get{} set{} }
	public PolicyStatementAttribute Attributes { get{} set{} }
	public string AttributeString { get{} }
}

