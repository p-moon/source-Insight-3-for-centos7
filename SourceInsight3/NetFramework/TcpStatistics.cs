public class TcpStatistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long ConnectionsAccepted { get{} }
	public long ConnectionsInitiated { get{} }
	public long CumulativeConnections { get{} }
	public long CurrentConnections { get{} }
	public long ErrorsReceived { get{} }
	public long FailedConnectionAttempts { get{} }
	public long MaximumConnections { get{} }
	public long MaximumTransmissionTimeout { get{} }
	public long MinimumTransmissionTimeout { get{} }
	public long ResetConnections { get{} }
	public long SegmentsReceived { get{} }
	public long SegmentsResent { get{} }
	public long SegmentsSent { get{} }
	public long ResetsSent { get{} }
}

