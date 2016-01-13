public class IPPacketInformation : System.ValueType
{

	// Methods
	public static bool op_Equality(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2) {}
	public static bool op_Inequality(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2) {}
	public virtual bool Equals(object comparand) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Net.IPAddress Address { get{} }
	public int Interface { get{} }
}

