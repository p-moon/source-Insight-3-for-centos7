public class PingReply
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IPStatus Status { get{} }
	public System.Net.IPAddress Address { get{} }
	public long RoundtripTime { get{} }
	public PingOptions Options { get{} }
	public byte[] Buffer { get{} }
}

