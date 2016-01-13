public class TcpListener
{

	// Constructors
	public TcpListener(System.Net.IPEndPoint localEP) {}
	public TcpListener(System.Net.IPAddress localaddr, int port) {}
	public TcpListener(int port) {}

	// Methods
	public void Start() {}
	public void Start(int backlog) {}
	public void Stop() {}
	public bool Pending() {}
	public Socket AcceptSocket() {}
	public TcpClient AcceptTcpClient() {}
	public System.IAsyncResult BeginAcceptSocket(System.AsyncCallback callback, object state) {}
	public Socket EndAcceptSocket(System.IAsyncResult asyncResult) {}
	public System.IAsyncResult BeginAcceptTcpClient(System.AsyncCallback callback, object state) {}
	public TcpClient EndAcceptTcpClient(System.IAsyncResult asyncResult) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Socket Server { get{} }
	public System.Net.EndPoint LocalEndpoint { get{} }
	public bool ExclusiveAddressUse { get{} set{} }
}

