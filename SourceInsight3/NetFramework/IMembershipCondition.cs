public interface IMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
{

	// Methods
	public abstract virtual bool Check(Evidence evidence) {}
	public abstract virtual IMembershipCondition Copy() {}
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object obj) {}
}

