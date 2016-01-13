public class EndPoint
{

	// Methods
	public virtual SocketAddress Serialize() {}
	public virtual EndPoint Create(SocketAddress socketAddress) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.Sockets.AddressFamily AddressFamily { get{} }
}

