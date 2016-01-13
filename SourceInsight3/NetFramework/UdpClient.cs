public class UdpClient : System.IDisposable
{

	// Constructors
	public UdpClient() {}
	public UdpClient(AddressFamily family) {}
	public UdpClient(int port) {}
	public UdpClient(int port, AddressFamily family) {}
	public UdpClient(System.Net.IPEndPoint localEP) {}
	public UdpClient(string hostname, int port) {}

	// Methods
	public void Close() {}
	public void Connect(string hostname, int port) {}
	public void Connect(System.Net.IPAddress addr, int port) {}
	public void Connect(System.Net.IPEndPoint endPoint) {}
	public int Send(byte[] dgram, int bytes, System.Net.IPEndPoint endPoint) {}
	public int Send(byte[] dgram, int bytes, string hostname, int port) {}
	public int Send(byte[] dgram, int bytes) {}
	public System.IAsyncResult BeginSend(byte[] datagram, int bytes, System.Net.IPEndPoint endPoint, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginSend(byte[] datagram, int bytes, System.AsyncCallback requestCallback, object state) {}
	public int EndSend(System.IAsyncResult asyncResult) {}
	public byte[] Receive(System.Net.IPEndPoint& remoteEP) {}
	public System.IAsyncResult BeginReceive(System.AsyncCallback requestCallback, object state) {}
	public byte[] EndReceive(System.IAsyncResult asyncResult, System.Net.IPEndPoint& remoteEP) {}
	public void JoinMulticastGroup(System.Net.IPAddress multicastAddr) {}
	public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, System.Net.IPAddress localAddress) {}
	public void JoinMulticastGroup(int ifindex, System.Net.IPAddress multicastAddr) {}
	public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, int timeToLive) {}
	public void DropMulticastGroup(System.Net.IPAddress multicastAddr) {}
	public void DropMulticastGroup(System.Net.IPAddress multicastAddr, int ifindex) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Socket Client { get{} set{} }
	public int Available { get{} }
	public short Ttl { get{} set{} }
	public bool DontFragment { get{} set{} }
	public bool MulticastLoopback { get{} set{} }
	public bool EnableBroadcast { get{} set{} }
	public bool ExclusiveAddressUse { get{} set{} }
}

