public class MulticastOption
{

	// Constructors
	public MulticastOption(System.Net.IPAddress group, System.Net.IPAddress mcint) {}
	public MulticastOption(System.Net.IPAddress group, int interfaceIndex) {}
	public MulticastOption(System.Net.IPAddress group) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.IPAddress Group { get{} set{} }
	public System.Net.IPAddress LocalAddress { get{} set{} }
	public int InterfaceIndex { get{} set{} }
}

