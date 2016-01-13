public interface ISecurityPolicyEncodable
{

	// Methods
	public abstract virtual void FromXml(SecurityElement e, System.Security.Policy.PolicyLevel level) {}
	public abstract virtual SecurityElement ToXml(System.Security.Policy.PolicyLevel level) {}
}

