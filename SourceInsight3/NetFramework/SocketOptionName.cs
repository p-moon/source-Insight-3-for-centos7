public class SocketOptionName : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public SocketOptionName Debug;
	public SocketOptionName AcceptConnection;
	public SocketOptionName ReuseAddress;
	public SocketOptionName KeepAlive;
	public SocketOptionName DontRoute;
	public SocketOptionName Broadcast;
	public SocketOptionName UseLoopback;
	public SocketOptionName Linger;
	public SocketOptionName OutOfBandInline;
	public SocketOptionName DontLinger;
	public SocketOptionName ExclusiveAddressUse;
	public SocketOptionName SendBuffer;
	public SocketOptionName ReceiveBuffer;
	public SocketOptionName SendLowWater;
	public SocketOptionName ReceiveLowWater;
	public SocketOptionName SendTimeout;
	public SocketOptionName ReceiveTimeout;
	public SocketOptionName Error;
	public SocketOptionName Type;
	public SocketOptionName MaxConnections;
	public SocketOptionName IPOptions;
	public SocketOptionName HeaderIncluded;
	public SocketOptionName TypeOfService;
	public SocketOptionName IpTimeToLive;
	public SocketOptionName MulticastInterface;
	public SocketOptionName MulticastTimeToLive;
	public SocketOptionName MulticastLoopback;
	public SocketOptionName AddMembership;
	public SocketOptionName DropMembership;
	public SocketOptionName DontFragment;
	public SocketOptionName AddSourceMembership;
	public SocketOptionName DropSourceMembership;
	public SocketOptionName BlockSource;
	public SocketOptionName UnblockSource;
	public SocketOptionName PacketInformation;
	public SocketOptionName HopLimit;
	public SocketOptionName NoDelay;
	public SocketOptionName BsdUrgent;
	public SocketOptionName Expedited;
	public SocketOptionName NoChecksum;
	public SocketOptionName ChecksumCoverage;
	public SocketOptionName UpdateAcceptContext;
	public SocketOptionName UpdateConnectContext;
}

