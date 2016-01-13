public class UdpStatistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long DatagramsReceived { get{} }
	public long DatagramsSent { get{} }
	public long IncomingDatagramsDiscarded { get{} }
	public long IncomingDatagramsWithErrors { get{} }
	public int UdpListeners { get{} }
}

