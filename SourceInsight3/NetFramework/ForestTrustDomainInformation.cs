public class ForestTrustDomainInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DnsName { get{} }
	public string NetBiosName { get{} }
	public string DomainSid { get{} }
	public ForestTrustDomainStatus Status { get{} set{} }
}

