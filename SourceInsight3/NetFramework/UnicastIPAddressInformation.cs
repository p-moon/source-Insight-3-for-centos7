public class UnicastIPAddressInformation : IPAddressInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long AddressPreferredLifetime { get{} }
	public long AddressValidLifetime { get{} }
	public long DhcpLeaseLifetime { get{} }
	public DuplicateAddressDetectionState DuplicateAddressDetectionState { get{} }
	public PrefixOrigin PrefixOrigin { get{} }
	public SuffixOrigin SuffixOrigin { get{} }
	public System.Net.IPAddress IPv4Mask { get{} }
	public System.Net.IPAddress Address { get{} }
	public bool IsDnsEligible { get{} }
	public bool IsTransient { get{} }
}

