public class IPGlobalProperties
{

	// Methods
	public static IPGlobalProperties GetIPGlobalProperties() {}
	public abstract virtual System.Net.IPEndPoint[] GetActiveUdpListeners() {}
	public abstract virtual System.Net.IPEndPoint[] GetActiveTcpListeners() {}
	public abstract virtual TcpConnectionInformation[] GetActiveTcpConnections() {}
	public abstract virtual TcpStatistics GetTcpIPv4Statistics() {}
	public abstract virtual TcpStatistics GetTcpIPv6Statistics() {}
	public abstract virtual UdpStatistics GetUdpIPv4Statistics() {}
	public abstract virtual UdpStatistics GetUdpIPv6Statistics() {}
	public abstract virtual IcmpV4Statistics GetIcmpV4Statistics() {}
	public abstract virtual IcmpV6Statistics GetIcmpV6Statistics() {}
	public abstract virtual IPGlobalStatistics GetIPv4GlobalStatistics() {}
	public abstract virtual IPGlobalStatistics GetIPv6GlobalStatistics() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DhcpScopeName { get{} }
	public string DomainName { get{} }
	public string HostName { get{} }
	public bool IsWinsProxy { get{} }
	public NetBiosNodeType NodeType { get{} }
}

