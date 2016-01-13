public class SocketAddress
{

	// Constructors
	public SocketAddress(System.Net.Sockets.AddressFamily family) {}
	public SocketAddress(System.Net.Sockets.AddressFamily family, int size) {}

	// Methods
	public virtual bool Equals(object comparand) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Net.Sockets.AddressFamily Family { get{} }
	public int Size { get{} }
	public byte Item { get{} set{} }
}

