public class TcpConnectionInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.IPEndPoint LocalEndPoint { get{} }
	public System.Net.IPEndPoint RemoteEndPoint { get{} }
	public TcpState State { get{} }
}

