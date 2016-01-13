public class IPAddress
{

	// Constructors
	public IPAddress(long newAddress) {}
	public IPAddress(byte[] address, long scopeid) {}
	public IPAddress(byte[] address) {}

	// Methods
	public static bool TryParse(string ipStringout , IPAddress& address) {}
	public static IPAddress Parse(string ipString) {}
	public byte[] GetAddressBytes() {}
	public virtual string ToString() {}
	public static long HostToNetworkOrder(long host) {}
	public static int HostToNetworkOrder(int host) {}
	public static short HostToNetworkOrder(short host) {}
	public static long NetworkToHostOrder(long network) {}
	public static int NetworkToHostOrder(int network) {}
	public static short NetworkToHostOrder(short network) {}
	public static bool IsLoopback(IPAddress address) {}
	public virtual bool Equals(object comparand) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Fields
	public IPAddress Any;
	public IPAddress Loopback;
	public IPAddress Broadcast;
	public IPAddress None;
	public IPAddress IPv6Any;
	public IPAddress IPv6Loopback;
	public IPAddress IPv6None;

	// Properties
	public long Address { get{} set{} }
	public System.Net.Sockets.AddressFamily AddressFamily { get{} }
	public long ScopeId { get{} set{} }
	public bool IsIPv6Multicast { get{} }
	public bool IsIPv6LinkLocal { get{} }
	public bool IsIPv6SiteLocal { get{} }
}

