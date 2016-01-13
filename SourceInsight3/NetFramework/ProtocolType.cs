public class ProtocolType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public ProtocolType IP;
	public ProtocolType IPv6HopByHopOptions;
	public ProtocolType Icmp;
	public ProtocolType Igmp;
	public ProtocolType Ggp;
	public ProtocolType IPv4;
	public ProtocolType Tcp;
	public ProtocolType Pup;
	public ProtocolType Udp;
	public ProtocolType Idp;
	public ProtocolType IPv6;
	public ProtocolType IPv6RoutingHeader;
	public ProtocolType IPv6FragmentHeader;
	public ProtocolType IPSecEncapsulatingSecurityPayload;
	public ProtocolType IPSecAuthenticationHeader;
	public ProtocolType IcmpV6;
	public ProtocolType IPv6NoNextHeader;
	public ProtocolType IPv6DestinationOptions;
	public ProtocolType ND;
	public ProtocolType Raw;
	public ProtocolType Unspecified;
	public ProtocolType Ipx;
	public ProtocolType Spx;
	public ProtocolType SpxII;
	public ProtocolType Unknown;
}

