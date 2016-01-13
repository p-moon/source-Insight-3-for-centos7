public class IPv6MulticastOption
{

	// Constructors
	public IPv6MulticastOption(System.Net.IPAddress group, long ifindex) {}
	public IPv6MulticastOption(System.Net.IPAddress group) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.IPAddress Group { get{} set{} }
	public long InterfaceIndex { get{} set{} }
}

