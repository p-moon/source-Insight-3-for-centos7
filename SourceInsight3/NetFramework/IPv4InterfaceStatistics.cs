public class IPv4InterfaceStatistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long BytesReceived { get{} }
	public long BytesSent { get{} }
	public long IncomingPacketsDiscarded { get{} }
	public long IncomingPacketsWithErrors { get{} }
	public long IncomingUnknownProtocolPackets { get{} }
	public long NonUnicastPacketsReceived { get{} }
	public long NonUnicastPacketsSent { get{} }
	public long OutgoingPacketsDiscarded { get{} }
	public long OutgoingPacketsWithErrors { get{} }
	public long OutputQueueLength { get{} }
	public long UnicastPacketsReceived { get{} }
	public long UnicastPacketsSent { get{} }
}

