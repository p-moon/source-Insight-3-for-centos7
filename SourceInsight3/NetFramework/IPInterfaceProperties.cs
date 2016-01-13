public class IPInterfaceProperties
{

	// Methods
	public abstract virtual IPv4InterfaceProperties GetIPv4Properties() {}
	public abstract virtual IPv6InterfaceProperties GetIPv6Properties() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDnsEnabled { get{} }
	public string DnsSuffix { get{} }
	public bool IsDynamicDnsEnabled { get{} }
	public UnicastIPAddressInformationCollection UnicastAddresses { get{} }
	public MulticastIPAddressInformationCollection MulticastAddresses { get{} }
	public IPAddressInformationCollection AnycastAddresses { get{} }
	public IPAddressCollection DnsAddresses { get{} }
	public GatewayIPAddressInformationCollection GatewayAddresses { get{} }
	public IPAddressCollection DhcpServerAddresses { get{} }
	public IPAddressCollection WinsServersAddresses { get{} }
}

