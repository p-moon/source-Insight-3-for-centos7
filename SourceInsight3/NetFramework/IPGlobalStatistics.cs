public class IPGlobalStatistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int DefaultTtl { get{} }
	public bool ForwardingEnabled { get{} }
	public int NumberOfInterfaces { get{} }
	public int NumberOfIPAddresses { get{} }
	public long OutputPacketRequests { get{} }
	public long OutputPacketRoutingDiscards { get{} }
	public long OutputPacketsDiscarded { get{} }
	public long OutputPacketsWithNoRoute { get{} }
	public long PacketFragmentFailures { get{} }
	public long PacketReassembliesRequired { get{} }
	public long PacketReassemblyFailures { get{} }
	public long PacketReassemblyTimeout { get{} }
	public long PacketsFragmented { get{} }
	public long PacketsReassembled { get{} }
	public long ReceivedPackets { get{} }
	public long ReceivedPacketsDelivered { get{} }
	public long ReceivedPacketsDiscarded { get{} }
	public long ReceivedPacketsForwarded { get{} }
	public long ReceivedPacketsWithAddressErrors { get{} }
	public long ReceivedPacketsWithHeadersErrors { get{} }
	public long ReceivedPacketsWithUnknownProtocol { get{} }
	public int NumberOfRoutes { get{} }
}

