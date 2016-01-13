public class IPEndPoint : EndPoint
{

	// Constructors
	public IPEndPoint(long address, int port) {}
	public IPEndPoint(IPAddress address, int port) {}

	// Methods
	public virtual string ToString() {}
	public virtual SocketAddress Serialize() {}
	public virtual EndPoint Create(SocketAddress socketAddress) {}
	public virtual bool Equals(object comparand) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Fields
	public int MinPort;
	public int MaxPort;

	// Properties
	public System.Net.Sockets.AddressFamily AddressFamily { get{} }
	public IPAddress Address { get{} set{} }
	public int Port { get{} set{} }
}

