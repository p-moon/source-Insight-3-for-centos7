public class TcpClient : System.IDisposable
{

	// Constructors
	public TcpClient(System.Net.IPEndPoint localEP) {}
	public TcpClient() {}
	public TcpClient(AddressFamily family) {}
	public TcpClient(string hostname, int port) {}

	// Methods
	public void Connect(string hostname, int port) {}
	public void Connect(System.Net.IPAddress address, int port) {}
	public void Connect(System.Net.IPEndPoint remoteEP) {}
	public void Connect(System.Net.IPAddress[] ipAddresses, int port) {}
	public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state) {}
	public void EndConnect(System.IAsyncResult asyncResult) {}
	public NetworkStream GetStream() {}
	public void Close() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Socket Client { get{} set{} }
	public int Available { get{} }
	public bool Connected { get{} }
	public bool ExclusiveAddressUse { get{} set{} }
	public int ReceiveBufferSize { get{} set{} }
	public int SendBufferSize { get{} set{} }
	public int ReceiveTimeout { get{} set{} }
	public int SendTimeout { get{} set{} }
	public LingerOption LingerState { get{} set{} }
	public bool NoDelay { get{} set{} }
}

